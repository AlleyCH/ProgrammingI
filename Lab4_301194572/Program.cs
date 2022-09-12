using System;
//Q11: A machine purchased for $28,000 depreciates at a rate of $4,000 a year for seven years.
//Write and run a C# program that computes and displays a depreciation table for seven years.
//The table should have the form:  
namespace Lab4_301194572
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("YEAR" + "\t\t" + "DEPRECIATION" + "\t\t" + "END - OF - YEAR VALUE" + "\t\t" + "ACCUMULATED DEPRECIATION");
            Console.WriteLine("----" + "\t\t" + "------------" + "\t\t" + "---------------------" + "\t\t" + "-----------------------");

            int purchase = 28000;
            int rate = 4000;
            int years = 0;

            do
            {
                years = years + 1;
                int endYear = purchase - rate;
                purchase = purchase - rate;
                int ratePlus = years * rate; 
                Console.WriteLine($"{years, 3} {(rate), 20} {(endYear), 30} {(ratePlus),30}");                
            } while (years < 7);     
        }
    }
}


