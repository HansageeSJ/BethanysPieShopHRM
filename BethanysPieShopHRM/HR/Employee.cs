using BethanysPieShopHRM.Logic;
using Newtonsoft.Json;

namespace BethanysPieShopHRM.HR;

public class Employee : IEmployee
{
    private string firstName;
    private string lastName;
    private string email;

    private int numberofHoursWorked;
    private double wage;
    private double? hourlyRate; //Represent null value by add ? suffix the double, means hourly rate can be null or double. 

    private DateTime birthDay;
    private const int minimalHoursWorkedUnit = 1;
    private Address address;

    // Add the field of EmployeeType to the Employee class.

    //Declare static variable
    public static double taxRate = 0.15;


    /* Creating properties to above private fields to control the access and modification of the data of an object */

    public string FirstName
    {
        get { return firstName; }
        set
        {
            firstName = value;
        }
    }
    public string LastName
    {
        get { return lastName; }
        set
        {
            lastName = value;
        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            email = value;
        }
    }
    public int NumberOfHoursWorked
    {
        get { return numberofHoursWorked; }
        protected set
        {
            numberofHoursWorked = value;
        }
    }
    public double Wage
    {
        get { return wage; }
        private set
        {
            wage = value;
        }
    }
    public double? HourlyRate
    {
        get { return hourlyRate; }
        set
        {
            if (hourlyRate < 0)
            {
                hourlyRate = 0;
            }
            else
            {
                hourlyRate = value;
            }
        }
    }
    public DateTime BirthDay
    {
        get { return birthDay; }
        set
        {
            birthDay = value;
        }
    }

    public Address Address
    {
        get { return address; }
        set
        {
            address = value;
        }
    }

    //Creating the constructor for this class to initiate the object. We don't use default constructor here.

    //Constructors can be overloaded. To calling another constructor from within a constructor, use the 'this' keyword.

    public Employee(string firstName, string lastName, string email, DateTime birthDay)
            : this(firstName, lastName, email, birthDay, 0)
    {
    }

    public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        BirthDay = birthDay;
        HourlyRate = hourlyRate ?? 10;
    }

    //In the constructor we can pass the double value and also the nullable values (values that store in DB might be null)
    public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate, string street, string houseNumber, string zip, string city)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        BirthDay = birthDay;
        HourlyRate = hourlyRate ?? 10;


        Address = new Address(street, houseNumber, zip, city); //instantiate the address, use the constructor address

    }

    public void PerformWork()
    {
        //numberofHoursWorked++;
        //Console.WriteLine($"{firstName} {lastName} has worked for: {numberofHoursWorked} hour(s)!");

        PerformWork(minimalHoursWorkedUnit);
    }

    public void PerformWork(int numberOfHours)
    {
        NumberOfHoursWorked += numberOfHours;

        Console.WriteLine($"{FirstName} {LastName} has worked for: {numberOfHours} hour(s)!");


    }

    public int CalculateBonus(int bonus)
    {
        if (NumberOfHoursWorked > 10)
            bonus *= 2;

        Console.WriteLine($"The employee got a bonus of {bonus}");
        return bonus;
    }

    public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
    {
        bonusTax = 0;
        if (NumberOfHoursWorked > 10)
            bonus *= 2;

        if (bonus >= 200)
        {
            bonusTax = bonus / 10;
            bonus -= bonusTax;
        }

        Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
        return bonus;
    }

    public virtual void GiveBonus() //polymorphic method. We use virtual to allow overring in derived class (inherited class)
    {
        Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
    }

    public double ReceiveWage(bool resetHours = true)
    {
        double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
        double taxAmount = wageBeforeTax * taxRate;

        wage = wageBeforeTax - taxAmount;

        Console.WriteLine($"{FirstName} {LastName} has received a wage of: {Wage} for {NumberOfHoursWorked} hour(s) of work!");

        if (resetHours)
            NumberOfHoursWorked = 0;
        return Wage;

    }
    public double CalculateWage()
    {
        WageCalculations wageCalculations = new WageCalculations();
        double calculateValue = wageCalculations.ComplexWageCalculation(wage, taxRate, 3, 42);
        return calculateValue;
    }


    // if (employeeType == EmployeeType.Manager)
    // {
    //     Console.WriteLine($"An extra was added to the wage since {firstName} is a manager");
    //     wageBeforeTax = numberofHoursWorked * hourlyRate.Value * 1.25;
    // }
    // else
    // {
    //     wageBeforeTax = numberofHoursWorked * hourlyRate.Value; //.Value or HasValue to take the default value from the nullable field.
    // }

    // double taxAmount = wageBeforeTax * taxRate;

    // wage = wageBeforeTax - taxAmount;

    // Console.WriteLine($"{firstName} {lastName} has received a wage of: {wage} for {numberofHoursWorked} hour(s) of work!");

    // if (resetHours)

    //     numberofHoursWorked = 0;

    // return wage;

    public string ConvertToJson()
    {
        string json = JsonConvert.SerializeObject(this);
        return json;
    }


    //Static method, that runs only on static data

    public static void DisplayTaxRate()
    {
        Console.WriteLine($"The current tax rate is: {taxRate}");
    }



    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"\nFirst name:\t{FirstName}\nLast name:\t{LastName}\nEmail:\t\t{Email}\nBirthday:\t{BirthDay.ToShortDateString()}\n");

    }

    public void GiveCompliment()
    {
        Console.WriteLine($"Good job {FirstName} {LastName}!");
    }
}

