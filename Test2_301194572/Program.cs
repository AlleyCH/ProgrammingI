using System;

namespace Test2_301194572
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting Kg ");
            double startKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter ending Kg ");
            double endKg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kg \t\t Pounds");
            Console.WriteLine("-- \t\t ------");

            do
            {
                if (startKg > 50 || endKg < 0)
                {
                    break;
                }
                double pounds = 2.205;
                pounds = startKg * pounds;
                Console.WriteLine($"{startKg} \t\t {(pounds):f3}");
                startKg = startKg - 2;


            } while (startKg >= endKg);

        }
    }
}







//Console.WriteLine("Enter starting Kg ");
//double startKg = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter ending Kg ");
//double endKg = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Kg \t\t Pounds");

//do
//{
//    double pounds = 2.205;
//    pounds = startKg * pounds;
//    Console.WriteLine($"{startKg} \t\t {(pounds):f3}");
//    startKg = startKg + 1;

//} while (startKg < endKg || startKg > endKg);


//Console.WriteLine("Enter the start value ");
//int num = Convert.ToInt32(Console.ReadLine());
//while (num > 0)
//{
//    if (num % 9 == 0)
//        Console.Write($"{num} ");
//    num = num - 1;
//}





//Console.WriteLine("Enter start litre ");
//double startLit = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter end litre ");
//double endLit = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Litre \t\t Gallon ");

//for (; startLit < endLit;)
//{
//    double gallon = startLit * 0.26;
//    Console.WriteLine($"{startLit} \t\t {(gallon)}");
//    startLit = startLit + 2;
//}