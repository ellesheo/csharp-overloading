using System;

namespace ConsoleApp2
{
    public class Employee
    {
        public const string DefaultName = "Без имени";
        public const string DefaultPosition = "Стажёр";
        public const decimal DefaultSalary = 500m;
        public const decimal DefaultRaisePercent = 10m;

        public string Name { get; }
        public string Position { get; private set; }
        public decimal Salary { get; private set; }

        public Employee(string name, string position, decimal salary)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(position) || salary < 0)
                throw new ArgumentException("Имя и должность не должны быть пустыми, а зарплата — отрицательной.");

            Name = name;
            Position = position;
            Salary = salary;
        }

        public Employee(string name, string position) : this(name, position, DefaultSalary)
        {
        }

        public Employee(string name) : this(name, DefaultPosition)
        {
        }

        public Employee() : this(DefaultName)
        {
        }

        public void Promote(decimal raisePercent)
        {
            if (raisePercent <= 0)
                throw new ArgumentException("Процент повышения должен быть положительным.");

            Salary += Salary * raisePercent / 100;
        }

        public void Promote()
        {
            Promote(DefaultRaisePercent);
        }

        public void Promote(string newPosition)
        {
            if (string.IsNullOrWhiteSpace(newPosition))
                throw new ArgumentException("Должность не может быть пустой.");

            Position = newPosition;
        }

        public void Promote(string newPosition, decimal raisePercent)
        {
            Promote(raisePercent);
            Promote(newPosition);
        }

        public override string ToString() => $"{Name}, {Position}, {Salary}";
    }
}