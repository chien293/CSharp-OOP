using System;
using System.Collections.Generic;
using System.Linq;

class Human
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class Student : Human
{
    public double Grade { get; set; }

    public Student(string firstName, string lastName, double grade)
        : base(firstName, lastName)
    {
        Grade = grade;
    }
}

class Worker : Human
{
    public double WeekSalary { get; set; }
    public double WorkHoursPerDay { get; set; }

    public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
        : base(firstName, lastName)
    {
        WeekSalary = weekSalary;
        WorkHoursPerDay = workHoursPerDay;
    }

    public double MoneyPerHour()
    {
        return WeekSalary / (WorkHoursPerDay * 5); // Assuming a 5-day work week
    }
}

class Program
{
    static void Main()
    {
        // Initialize an array of 10 students
        var students = new List<Student>
        {
            new Student("Alice", "Johnson", 85.5),
            new Student("Bob", "Smith", 92.3),
            new Student("Carol", "Williams", 78.0),
            new Student("David", "Brown", 88.7),
            new Student("Eve", "Jones", 91.5),
            new Student("Frank", "Miller", 84.2),
            new Student("Grace", "Davis", 89.6),
            new Student("Hank", "Garcia", 76.3),
            new Student("Ivy", "Martinez", 90.0),
            new Student("John", "Lopez", 80.4)
        };

        // Sort students by grade in ascending order
        var sortedStudents = students.OrderBy(s => s.Grade).ToList();

        Console.WriteLine("Students sorted by grade (ascending):");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} - Grade: {student.Grade}");
        }

        // Initialize an array of 10 workers
        var workers = new List<Worker>
        {
            new Worker("Anna", "Taylor", 800, 8),
            new Worker("Bill", "Anderson", 900, 7),
            new Worker("Cathy", "Thomas", 1000, 6),
            new Worker("Dan", "Jackson", 950, 7),
            new Worker("Ella", "White", 850, 8),
            new Worker("Fred", "Harris", 1100, 5),
            new Worker("George", "Martin", 780, 8),
            new Worker("Helen", "Thompson", 980, 6),
            new Worker("Iris", "Clark", 1050, 5),
            new Worker("Jack", "Lewis", 1150, 4)
        };

        // Sort workers by money per hour in descending order
        var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour()).ToList();

        Console.WriteLine("\nWorkers sorted by money per hour (descending):");
        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine($"{worker.FirstName} {worker.LastName} - Money per Hour: {worker.MoneyPerHour():F2}");
        }
    }
}
