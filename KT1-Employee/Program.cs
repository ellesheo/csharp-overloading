using System;

class Program
{
    static void Main()
    {
        var e1 = new Employee();
        Console.WriteLine(e1);

        var e2 = new Employee("Иванов И.И.");
        Console.WriteLine(e2);

        var e3 = new Employee("Петров П.П.", "Разработчик");
        Console.WriteLine(e3);

        var e4 = new Employee("Сидоров С.С.", "Тимлид", 2500m);
        Console.WriteLine(e4);

        e4.Promote();
        Console.WriteLine(e4);

        e4.Promote(20m);
        Console.WriteLine(e4);

        e4.Promote("Старший тимлид");
        Console.WriteLine(e4);

        e4.Promote("Руководитель отдела", 15m);
        Console.WriteLine(e4);

        // Employee wrong = new Employee("", "Дизайнер", 1000m);
        // Employee wrong2 = new Employee("Иванов И.И.", "Дизайнер", -100m);
        // e4.Promote(-5m);
        // e4.Promote("");
    }
}