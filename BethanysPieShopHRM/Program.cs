
using System.Text;
using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;



Console.WriteLine("Creating an employee");
Console.WriteLine("-----------------------\n");

//Creating object.

IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany.smith@bethanyspieshop.com", new DateTime(1990, 1, 1), 25);

IEmployee mary = new Manager("Mary", "Jones", "mary.jones@bethanyspieshop.com", new DateTime(1965, 1, 16), 30);

IEmployee bobJunior = new JuniorResearcher("Bob", "Spencer", "bob.junior@bethanyspieshop.com", new DateTime(1988, 1, 23), 17);

IEmployee kevin = new StoreManager("Kevin", "Marks", "kevin.marks@bethanyspieshop.com", new DateTime(1953, 12, 12), 10);

IEmployee kate = new StoreManager("Kate", "Greggs", "kate.greggs@bethanyspieshop.com", new DateTime(1993, 8, 8), 10);

List<IEmployee> employees = new List<IEmployee>();
employees.Add(bethany);
employees.Add(mary);
employees.Add(bobJunior);
employees.Add(kevin);
employees.Add(kate);

foreach (Employee employee in employees)
{
    employee.DisplayEmployeeDetails();
    employee.GiveBonus();
    employee.GiveCompliment();
    //employee.AttendManagementMeeting();
}

#region First run Bethany

// bethany.DisplayEmployeeDetails();
// bethany.PerformWork(8);
// bethany.PerformWork();
// bethany.PerformWork(3);
// bethany.ReceiveWage();




// mary.DisplayEmployeeDetails();
// mary.PerformWork(2);
// mary.PerformWork();
// mary.PerformWork();
// mary.ReceiveWage();
// mary.AttendManagementMeeting();
// mary.GiveBonus();

// bobJunior.ResearchNewPieTastes(23);
// bobJunior.ResearchNewPieTastes(5);
// bobJunior.DisplayEmployeeDetails();

Employee jake = new Employee("Jake", "Nichols", "jake.nichols@bethanyspieshop.com", new DateTime(1995, 5, 5), 20, "New street", "123", "12345", "Pie ville");
string streetName = jake.Address.Street;

#endregion

// #region First run George

// george.PerformWork(10);
// george.PerformWork();
// george.PerformWork();
// george.ReceiveWage();
// george.DisplayEmployeeDetails();

// #endregion

// //Employee.taxRate = 0.02;

// #region Second run Bethany

// bethany.PerformWork();
// bethany.PerformWork(5);
// bethany.PerformWork();
// bethany.ReceiveWage();
// bethany.DisplayEmployeeDetails();

// #endregion

// #region Second run George

// george.PerformWork(10);
// george.PerformWork();
// george.PerformWork();
// george.ReceiveWage();
// george.DisplayEmployeeDetails();

// #endregion

// Employee.DisplayTaxRate();

// #region Record Run

// Accounts account1 = new Accounts("123456789"); //Created a positional record and value that pass cannot be changed after it has been initialized.  Immutability of the record.

// Console.WriteLine($"Account Number: {account1.AccountNumber}");

// #endregion

// #region Array
// Console.WriteLine("How many employees ID do you want to register?");

// int length = int.Parse(Console.ReadLine());
// int[] employeeIds = new int[length];

// var testID = employeeIds[0];
// Console.WriteLine($"The first employee ID is: {testID}");

// for (int i = 0; i < length; i++)
// {
//     Console.WriteLine($"Enter your employee ID {i}:");
//     employeeIds[i] = int.Parse(Console.ReadLine());
// }

// //Display ID
// for (int i = 0; i < employeeIds.Length; i++)
// {
//     Console.WriteLine($"Employee ID {i + 1}:  \t{employeeIds[i]}");
// }

// Array.Sort(employeeIds);

// Console.WriteLine("After sorting the array");

// for (int i = 0; i < employeeIds.Length; i++)
// {
//     Console.WriteLine($"Employee ID {i + 1}:  \t{employeeIds[i]}");
// }

// //Copy of the array

// int[] employeeIdsCopy = new int[length];
// employeeIds.CopyTo(employeeIdsCopy, 0);

// Array.Reverse(employeeIds);

// Console.WriteLine("After reversing the original array");

// for (int i = 0; i < employeeIds.Length; i++)
// {
//     Console.WriteLine($"Employee ID {i + 1}:  \t{employeeIds[i]}");
// }

// Console.WriteLine("Copy of the original array");

// for (int i = 0; i < employeeIdsCopy.Length; i++)
// {
//     Console.WriteLine($"Employee ID {i + 1}:  \t{employeeIdsCopy[i]}");
// }
// #endregion

// #region List

// List<int> employeeIdList = new List<int>();

// employeeIdList.Add(12);
// employeeIdList.Add(34);
// employeeIdList.Add(56);
// employeeIdList.Add(78);
// employeeIdList.Add(79);


// if (employeeIdList.Contains(78))
// {
//     Console.WriteLine("78 found!");
// }

// int currentAmountofEmployees = employeeIdList.Count;
// Console.WriteLine($"Current amount of employees: {currentAmountofEmployees}");

// var employeeIdsArray = employeeIdList.ToArray();

// employeeIdList.Clear();

// Console.WriteLine($"Current amount of employees after clearing the list: {employeeIdList.Count}");

// Console.WriteLine("How many employee IDs do you want to register?");
// int lengthTwo = int.Parse(Console.ReadLine());

// for (int i = 0; i < lengthTwo; i++)
// {
//     Console.WriteLine($"Enter your employee ID {i}:");
//     employeeIdList.Add(int.Parse(Console.ReadLine()));
// }
// Employee bethanyg = new Employee("Bethany", "Smith", "bethany.smith@bethanyspieshop.com", new DateTime(1990, 1, 1), 25, EmployeeType.StoreManager);

// Employee georged = new Employee("George", "Jones", "george.jones@bethanyspieshop.com", new DateTime(1992, 5, 15), null, EmployeeType.Research);

// Employee marry = new Employee("Marry", "Johnson", "marry.johnson@bethanyspieshop.com", new DateTime(1988, 3, 22), 30, EmployeeType.Manager);

// Employee bobjunior = new Employee("Bob", "Junior", "bob.junior@bethanyspieshop.com", new DateTime(1995, 7, 30), 22, EmployeeType.Intern);

// Employee kevin = new Employee("Kevin", "Brown", "kevin.brown@bethanyspieshop.com", new DateTime(1990, 1, 1), 25, EmployeeType.Manager);

// Employee kate = new Employee("Kate", "Williams", "kate.williams@bethanyspieshop.com", new DateTime(1992, 5, 15), null, EmployeeType.Research);

// List<Employee> employees1 = new List<Employee>();
// employees1.Add(georged);
// employees1.Insert(0, bethanyg);
// employees1.Add(marry);
// employees1.Add(bobjunior);
// employees1.Add(kevin);
// employees1.Add(kate);

// foreach (Employee employee in employees1)
// {
//     employee.DisplayEmployeeDetails();
// }

// #endregion