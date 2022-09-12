using System;

namespace Lab6_301194572
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;

            do
            {
                DisplayMenu();
                Console.WriteLine("");
                Console.Write("Enter a number: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (menu)
                {
                    case 3:
                        Console.WriteLine("Enter number of inputs: ");
                        int numOfInputs = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The sum is " + CalculateSum(numOfInputs));
                        break;
                    case 4:
                        Console.WriteLine("Enter number of inputs: ");
                        int numberOfInputs = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The sum is " + CalculateSumOfSquares(numberOfInputs));
                        break;
                    case 5:

                        Console.WriteLine("The sum is " + CalculateSumOfCubes());
                        break;
                    case 6:
                        Console.WriteLine("The average is " + CalculateAverage());
                        break;
                    case 0:
                        Console.WriteLine("Exited program");
                        break;
                    default:
                        Console.WriteLine("Invald choice");
                        Console.WriteLine("");
                        continue;
                }
            } while (menu > 0);
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("3) Calculate Sum");
            Console.WriteLine("4) Calculate Sum of Squares");
            Console.WriteLine("5) Calculate Sum of Cubes");
            Console.WriteLine("0) To Exit");
            Console.WriteLine("");
            Console.WriteLine("Enter the number that corresponds to your choice: ");
            Console.WriteLine("----------------------------");
        }
        static int CalculateSum(int numOfInputs)
        {
            int sum = 0;
            for (int i = 1; i <= numOfInputs; i++)
            {
                Console.WriteLine("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }

            return sum;
        }
        static int CalculateSumOfSquares(int numberOfInputs)
        {
            int sum = 0;
            for (int i = 1; i <= numberOfInputs; i++)
            {
                Console.WriteLine("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                num *= num;
                sum += num;
            }
            return sum;
        }
        static int CalculateSumOfCubes()
        {
            Console.WriteLine("Enter number of inputs: ");
            int noOfInputs = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= noOfInputs; i++)
            {
                Console.WriteLine("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                num = num * num * num;
                sum += num;
            }
            return sum;
        }
        static double CalculateAverage()
        {
            Console.WriteLine("Enter number of inputs: ");
            int numbOfInputs = Convert.ToInt32(Console.ReadLine());

            double average = 0;
            double sum = 0;
            for (int i = 1; i <= numbOfInputs; i++)
            {
                Console.WriteLine("Enter number: ");
                double num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                average = sum / numbOfInputs;
            }
            return average;
        }
    }
}
