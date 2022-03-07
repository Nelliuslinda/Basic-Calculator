using System;

namespace Calculator
{
    internal class Program
    {
        public static int Sum(int x, int y)
        {
            return x + y;           
        }

        public static int Diff(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Div(int x, int y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            //Start menu for Calculator

            Console.WriteLine("Welcome to the Calculator App\n\n 1. Sum \n 2. Subtraction\n 3. Multiplication\n 4. Division\n Choose an option to start");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.WriteLine("\nInsert the first number:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insert the second number:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nThe answer is: " + Sum(num1,num2));
                    break;

                case 2:
                    Console.WriteLine("\nInsert the first number:");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insert the second number:");
                    int num4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nThe answer is: " + Diff(num3, num4));
                    break;

                case 3:
                    Console.WriteLine("\nInsert the first number:");
                    int num5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insert the second number:");
                    int num6 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nThe answer is: " + Multiply(num5, num6));
                    break;

                case 4:
                    Console.WriteLine("\nInsert the first number:");
                    int num7 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insert the second number:");
                    int num8 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nThe answer is: " + Div(num7, num8));
                    break;

            }


        }
    }
}
