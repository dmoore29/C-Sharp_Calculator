using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //fields
            double num1;
            double num2;
            double result;
            char op;
            String cont = "y";

            //loop until "p" is typed
            while (cont != "n")
            {
                //get first number
                Console.WriteLine("Enter First Number ");
                num1 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("\n");

                //get second number
                Console.WriteLine("Enter Second Number ");
                num2 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("\n");

                //get operator
                Console.WriteLine("Enter Operator (*, /, -, +) ");
                op = Convert.ToChar(Console.ReadLine());
                //Console.WriteLine("\n");

                //gets result and prints it
                result = getResult(num1, num2, op);
                Console.WriteLine("Result: ");
                Console.WriteLine(result);
                Console.WriteLine("\n");

                Console.WriteLine("Continue? (Y/N): ");
                cont = Convert.ToString(Console.ReadLine());
                cont = cont.ToLower();
                Console.WriteLine("\n");
            }
        }

        //preforms operation
        public static double getResult(double num1, double num2, char op)
        {
            //cases for op
            switch (op)
            {
                case '*': return num1 * num2;
                case '/': return num1 / num2;
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                default: return 0;
            }
        }
    }
}

//TEST BRANCH?