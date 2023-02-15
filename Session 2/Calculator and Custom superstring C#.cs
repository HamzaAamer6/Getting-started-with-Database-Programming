using System;
using System.Net.Configuration;

namespace Calculator
{

    class Sys
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Calculator\n2. Super String\n3. Longest Word\nPick A Program : ");
            char choice=Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case '1':
                    calc.Calculator();
                    break;
                case '2':
                    Super.superstring();
                    break;
                case '3':
                    Longest.LongestWord();
                    break;
            }
        }
    }
    class calc
    {
        public static void Calculator()
        {
            int arg1 = 0;
            int arg2 = 0;
            char command;
            Console.WriteLine("Enter Num 1 : ");
            arg1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num 2 : ");
            arg2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***Operations***\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Modular Divison\n6.Prime Number\n7.Factorial\n8.Square Root\nSelect Operation : ");

            command = Convert.ToChar(Console.ReadLine());

            switch (command)
            {
                case '1':
                    Console.WriteLine(arg1 + " + " + arg2 + " = " + calc.addition(arg1, arg2));
                    break;
                case '2':
                    Console.WriteLine(arg1 + " - " + arg2 + " = " + calc.subtract(arg1, arg2));
                    break;
                case '3':
                    Console.WriteLine(arg1 + " * " + arg2 + " = " + calc.multiply(arg1, arg2));
                    break;
                case '4':
                    Console.WriteLine(arg1 + " / " + arg2 + " = " + calc.divide(arg1, arg2));
                    break;
                case '5':
                    Console.WriteLine(arg1 + " MOD " + arg2 + " = " + calc.mod(arg1, arg2));
                    break;
                case '6':
                    if (calc.prime(arg1))
                    {
                        Console.WriteLine(arg1 + " Is a Prime Number!");
                    }
                    else
                    {
                        Console.WriteLine(arg1 + " Is not a Prime Number!");
                    }

                    if (calc.prime(arg2))
                    {
                        Console.WriteLine(arg2 + " Is a Prime Number!");
                    }
                    else
                    {
                        Console.WriteLine(arg2 + " Is not a Prime Number!");
                    }
                    break;
                case '7':
                    Console.WriteLine(arg1 + "! = " + calc.factorial(arg1));
                    Console.WriteLine(arg2 + "! = " + calc.factorial(arg2));
                    break;
                case '8':
                    Console.WriteLine(arg1 + "sqrt = " + calc.sqareRoot(arg1));
                    Console.WriteLine(arg2 + "sqrt = " + calc.sqareRoot(arg2));
                    break;
            }
        }
        public static int addition(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
        public static int subtract(int arg1, int arg2)
        {
            return arg1 - arg2;
        }
        public static int multiply(int arg1, int arg2)
        {
            return arg1 * arg2;
        }
        public static int divide(int arg1, int arg2)
        {
            return arg1 / arg2;
        }
        public static int mod(int arg1, int arg2)
        {
            return arg1 % arg2;
        }
        public static bool prime(int arg1)
        {
            for(int x=2; x<arg1; x++)
            {
                if (arg1%x == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int factorial(int arg1)
        {
            int fact = 1;
            for (int x = 1; x <= arg1; x++)
            {
                fact *= x;
            }
            return fact;
        }
        public static double sqareRoot(int arg1)
        {
            return Math.Sqrt(arg1);
        }
    }
    class Super
    {
        public static void superstring()
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            int length=str.Length;
            int[] count = new int[200];
            for (int x = 0; x < 26; x++)
            {
                count[x] = 0;
            }

            for (int x = 0; x < length; x++)
            {
                count[Math.Abs( (((int)str[x]) - 91))]++;
            }
            for (int x = 0; x < 26; x++)
            {
                if (count[x] != 0 && count[x] != x)
                {
                    Console.WriteLine(str + " is not a superstring!");
                    return;
                }
            }


            Console.WriteLine(str + " is a superstring!");
            return;
        }
    }
    class Longest
    {
        public static void LongestWord()
        {
            Console.WriteLine("Enter String : ");
            string str = Console.ReadLine();
            int counter = 0;
            int maxword = -1;
            int len = str.Length;
            string max = " ";

            for (int i = 0; i < len; i++)
            {
                if (str[i] != ' ')
                {
                    counter++;
                }
                if (str[i] == ' ' || i == len - 1)
                {
                    if (counter > maxword)
                    {
                        maxword = counter;
                        if (i == len - 1)
                            max = str.Substring(i + 1 - maxword, maxword);
                        else
                            max = str.Substring(i - maxword, maxword);
                    }

                    counter = 0;
                }
            }
            Console.WriteLine("The longest word is : \"" + maxword + "\" with length :  " + max );
        }
    }
}