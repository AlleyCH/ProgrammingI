using System;

namespace Test1_3011194572
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Monthly salary: ");
            double monthlySalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name} I have calculated your annual salary to be {monthlySalary * 12:c}");
            Console.Write("Press any key to continue . . . ");
            Console.WriteLine();
        }
    }
}