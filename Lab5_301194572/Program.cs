using System;
//Q11: Print the decimal, octal, and hexadecimal values of all characters between the start and stop 
//characters entered by a user. For example, if the user enters an a and a z, the program should 
//print all the characters between a and z and their respective numerical values. Make sure that the 
//second character entered by the user occurs later in the alphabet than the first character. If it does
//not, write a loop that repeatedly asks the user for a valid second character until one is entered. 
//Your output should be formatted as shown below
namespace Lab5_301194572
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a' ;
            char letter2 = 'z';
           
            while ((int)letter < (int)letter2 || (int)letter >= (int)letter2)
            {
                Console.WriteLine("Enter the first letter ");
                letter = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter a letter that is lower than the first letter entered ");
                letter2 = Convert.ToChar(Console.ReadLine());

                if ((int)letter >= (int)letter2)
                {
                    Console.WriteLine("Not vaild, enter another letter");
                    continue;
                }
                else
                {
                    break;
                }            
            }

            Console.WriteLine("Letter \t\t Decimal \t\t Octal \t\t Hex");

            while ( (int)letter <= (int)letter2)
            {
                Console.WriteLine($"{letter} \t\t {((int)letter)} \t\t\t {(Convert.ToString((int)letter, 8))}\t\t {(Convert.ToString((int)letter, 16))}");
                letter++;
            }
        }
    }
}
