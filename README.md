# Bethany's Pie Shop HRM

A C# learning project built while studying **C# Fundamentals on Pluralsight**.

## 📖 About the Project

Bethany's Pie Shop HRM (Human Resource Management) is a learning project designed to practise fundamental C# programming concepts through an employee management application.

This project is part of my ongoing journey to strengthen my C# and .NET development skills through hands-on coding and unit testing.

## 🎯 Learning Objectives

The project explores the following C# fundamentals:

- Classes, objects, fields, properties, and methods
- Constructors and constructor overloading
- Encapsulation and access modifiers
- Inheritance and polymorphism
- Interfaces and abstraction
- Nullable types and null-coalescing operators
- Static members and constants
- Method overloading and optional parameters
- Exception handling and basic validation
- Working with collections and data types
- JSON serialization
- Basic employee wage and bonus calculations
- Unit testing with xUnit

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET
- **Testing:** xUnit
- **IDE:** Visual Studio Code
- **Version Control:** Git and GitHub
- **Learning Resource:** Pluralsight — C# Fundamentals

## 📂 Project Structure

```text
BethanysPieShopHRM/
├── BethanysPieShopHRM/
│   ├── Accounting/
│   ├── HR/
│   ├── Libraries/
│   ├── Program.cs
│   └── BethanysPieShopHRM.csproj
├── BethanysPieShopHRM.Tests/
│   ├── EmployeeTests.cs
│   └── BethanysPieShopHRM.Tests.csproj
├── BethanysPieShopHRM.sln
└── README.md
```

*The structure above represents the intended solution layout; individual files may vary as the project evolves.*

## 🧪 Unit Testing

An xUnit test project is included to practise writing automated tests and validating application behaviour.

The tests cover employee work-hour calculations, including:

- Adding a specified number of working hours
- Adding the default number of working hours when no argument is provided

Run the tests from the solution's root directory:

```bash
dotnet test
```

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/)

### Run the Application

1. Clone this repository:

   ```bash
   git clone https://github.com/HansageeSJ/BethanysPieShopHRM.git
   ```

2. Navigate to the project directory:

   ```bash
   cd BethanysPieShopHRM
   ```

3. Restore dependencies:

   ```bash
   dotnet restore
   ```

4. Run the application project:

   ```bash
   dotnet run --project BethanysPieShopHRM/BethanysPieShopHRM.csproj
   ```

5. Run the unit tests:

   ```bash
   dotnet test
   ```

## 🌱 Learning Journey

This repository documents my practical learning journey with C# and .NET.

My goal is to build a strong foundation in object-oriented programming, write cleaner and more maintainable code, and develop confidence in automated testing.

The project will continue to evolve as I learn and apply more software development concepts.

## 📚 Acknowledgement

Learning resource: **C# Fundamentals — Pluralsight**

This project was developed for learning and practice purposes while following the course and applying the concepts through hands-on exercises.

