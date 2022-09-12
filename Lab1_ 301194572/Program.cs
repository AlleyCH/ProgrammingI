using System;

namespace Lab1__301194572
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your social insurance numer: ");
            string socialInsuranceNumber = Console.ReadLine();
            Console.Write("Enter your hourly pay rate: ");
            double hourlyPayRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number of hours worked: ");
            double numberOfHoursWorked = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Summary for {name}");
            Console.WriteLine($"SIN: {socialInsuranceNumber}");
            Console.WriteLine($"You have worked {numberOfHoursWorked} hours for {hourlyPayRate:C} per hour");
            Console.WriteLine();
            double gross = hourlyPayRate * numberOfHoursWorked;
            Console.WriteLine($"Gross Pay: {gross,21:C}");
            double federalTax = gross * 0.15;
            Console.WriteLine($"Federal Tax {federalTax,20:C}");
            double provincialTax = gross * 0.1;
            Console.WriteLine($"Provincial Tax {provincialTax,17:C}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Net Pay {gross - federalTax - provincialTax,24:C}");

        }
    }
}