using System;

namespace Lab3_301194572
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numer of courses: ");
            int courses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("residency status (domestic or international): ");
            string residency = Console.ReadLine().ToLower();

            switch (residency)
            {
                case "domestic":
                    int tution = 325;
                    Console.WriteLine($"{tution * courses:c}");
                    break;
                case "international":
                    tution = 1375;
                    Console.WriteLine($"{tution * courses:c}");
                    break;
            }
        }
    }
}






