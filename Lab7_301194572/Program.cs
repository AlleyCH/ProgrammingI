using System;

namespace Lab7_301194572
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int [] array = Number(size);
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
        }
        static int[] Number(int numSize)
        {
            int[] num = new int[numSize];

            for ( int i = 0; i < numSize; i++ )
            {
                num[i] = rand.Next(100, 200);
            }          
            return num;
        }
    }
}
