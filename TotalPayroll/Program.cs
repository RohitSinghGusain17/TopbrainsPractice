using System;
using System.Collections.Generic;
using System.Globalization;

public abstract class Employee
{
    public abstract decimal CalculatePay();
}

public class HourlyEmployee : Employee
{
    private decimal rate;
    private decimal hours;

    public HourlyEmployee(decimal rate, decimal hours)
    {
        this.rate = rate;
        this.hours = hours;
    }

    public override decimal CalculatePay()
    {
        return rate * hours;
    }
}

public class SalariedEmployee : Employee
{
    private decimal monthlySalary;

    public SalariedEmployee(decimal monthlySalary)
    {
        this.monthlySalary = monthlySalary;
    }

    public override decimal CalculatePay()
    {
        return monthlySalary;
    }
}

public class CommissionEmployee : Employee
{
    private decimal commission;
    private decimal baseSalary;

    public CommissionEmployee(decimal commission, decimal baseSalary)
    {
        this.commission = commission;
        this.baseSalary = baseSalary;
    }

    public override decimal CalculatePay()
    {
        return baseSalary + commission;
    }
}

public class Program
{
    public static decimal ComputeTotalPayroll(string[] employees)
    {
        List<Employee> list = new List<Employee>();

        foreach (var emp in employees)
        {
            var parts = emp.Split(' ');

            switch (parts[0])
            {
                case "H":
                    list.Add(new HourlyEmployee(
                        decimal.Parse(parts[1]),
                        decimal.Parse(parts[2])
                    ));
                    break;

                case "S":
                    list.Add(new SalariedEmployee(
                        decimal.Parse(parts[1])
                    ));
                    break;

                case "C":
                    list.Add(new CommissionEmployee(
                        decimal.Parse(parts[1]),
                        decimal.Parse(parts[2])
                    ));
                    break;
            }
        }

        decimal total = 0;
        foreach (var e in list)
        {
            total += e.CalculatePay(); // polymorphism
        }

        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }

    public static void Main()
    {
        string[] employees =
        {
            "H 100 10",
            "S 5000",
            "C 2000 3000"
        };

        decimal result = ComputeTotalPayroll(employees);
        Console.WriteLine(result); // 11000.00
    }
}
