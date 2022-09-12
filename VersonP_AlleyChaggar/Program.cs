using System;

namespace VersonP_AlleyChaggar
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            char choice;
            do
            {
                DisplayMenu();

                choice = Convert.ToChar(Console.ReadLine().ToLower());
                switch (choice)
                {
                    case 'q':
                        char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
                        DisplayOnlyVowels(vowel );
                        //DemoQuestion3();
                        break;
                    case 'r':
                         DemoQuestion4();
                        break;
                    case 's':
                         DemoQuestion5();
                        break;
                    case 't':
                         DemoQuestion6();
                        break;
                    case 'x':
                        Console.WriteLine("Program Ends here...>");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        continue;
                }
            } while ((int)choice >= 'a');
        }
        static void DisplayMenu()
        {
            Console.WriteLine("--------------------Alley Chaggar--------------------------");

            Console.WriteLine("q) Working with array of characters  ");
            Console.WriteLine("r) Metric to Imperial Conversion  ");
            Console.WriteLine("s) Using Stokes's Law  ");
            Console.WriteLine("t) Working with Bills ");
            Console.WriteLine("x) Calculate Tax ");
            Console.WriteLine();
            Console.WriteLine("Press the letter corresponding to your choice->");

            Console.WriteLine("------------------------------------------------------");
        }
        static void DemoQuestion3() //driver
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            //code for invoking question 3 goes here
            char[] arrays = GenerateCharAray(40);
            DisplayCharAray(arrays);
            Console.WriteLine();
            DisplayOnlyVowels(arrays);
            Console.WriteLine();
            DisplayCharAray(arrays);
            Console.WriteLine();

            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }
        static void DisplayOnlyVowels(char[] array) //driver
        {


            foreach (char vowel in array)
            {
                Console.Write($"{vowel}");
            }
        }
        static void DisplayCharAray(char[] arrayOfChar)
        {
            for (char letter = 'a'; (int)letter >= 0; letter++)
            {
                Console.Write(letter);
            }
        }
        static char[] GenerateCharAray(int numOfChar)
        {
            char[] num = new char[numOfChar];

            for (int i = 0; i < numOfChar; i++)
            {
                num[i] = (char)rand.Next('a', 'z' + 1);
            }

            return num;
        }
        static void DemoQuestion4() //driver
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            //code for invoking question 4 goes here
            double initialValue = 0.15;
            double lb = 0, ounces = 0, tons = 0;
            MetricToImperial(initialValue, ref lb, ref ounces, ref tons);
            Console.WriteLine($"{initialValue} kg is equal to {lb} lb, {ounces} oz, {tons} tonne");
            initialValue = 150;
            MetricToImperial(initialValue, ref lb, ref ounces, ref tons);
            Console.WriteLine($"{initialValue} kg is equal to {lb} lb, {ounces} oz, {tons} tonne");
            Console.WriteLine("\n**********End Question 4 **********\n\n");
        }
        static void MetricToImperial(double kg, ref double lb, ref double ounces, ref double tons)
        {
            kg = 0.15;
            lb = kg * 2.205;
            ounces = kg * 35.274;
            tons = kg * 0.0011;
        }

        static void DemoQuestion5() //driver 
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            //code for invoking question 5 goes here
            float radius = 0.00317f;
            double viscosity = 1.3, velocity = 0.108;
            double e = Stokes(radius, viscosity, velocity);
            Console.WriteLine($"The drag on a body of raduis {radius } with speed {velocity} thru a liquid of viscosity {viscosity:n} is {e:n}");
            radius = 0.00232f;
            e = Stokes(radius, viscosity, velocity);
            Console.WriteLine($"The drag on a body of raduis {radius } with speed {velocity} thru a liquid of viscosity {viscosity:n} is {e:n}");
            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }
        static double Stokes(double viscosity, double radius, double velocity)
        {
            const double PI = 3.14;
            viscosity = 1.3;
            radius = 0.00317;
            velocity =  0.108;
            double dragForce = 6 * PI * viscosity * radius * velocity;
        
                return dragForce;

        }

            static void DemoQuestion6() //driver
        {
            Console.WriteLine("\n\n**********Begin Question 6 **********");
            //code for invoking question 6 goes here
            double federialTax = 6750;

            double income = 44500;           
            Console.WriteLine($"Your federial tax will be {federialTax:c} if your income is {income:C}");
            income = 72000;
            federialTax = 12705;
            Console.WriteLine($"Your federial tax will be {federialTax:c} if your income is {income:C}");
            federialTax = 21891;
            income = 115000;
            Console.WriteLine($"Your federial tax will be {federialTax:c} if your income is {income:C}");
          
            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }

        //static double CalculateTax(double annualTaxIncome)
        //{
        //    double federialTax = 0;
        //    double firstRate = 0.15;
        //    double secRate = 0.20;
        //    double thirdRate = 0.26;

        //    if (federialTax < 48535)
        //    {
        //        firstRate;
        //    }
        //    if(federialTax >48535 && federialTax < 97069)
        //    {
        //        secRate;
        //    }
        //    if (federialTax > 97069)
        //    {
        //        federial * thirdRate;
        //    }
           
        //    return federialTax;



        //}


    }
}

