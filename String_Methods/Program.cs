using System;

namespace String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculation(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine(CountOfSymbols(Console.ReadLine()));
            Console.WriteLine(CountOfWords(Console.ReadLine()));
            Console.WriteLine(SumOfNumbers(Console.ReadLine()));
        }

        static int Calculation(int x, int y)
        {
            int result = default; 
            Console.WriteLine("Operator daxil edin:");
            char simvol = Convert.ToChar(Console.ReadLine());

            switch (simvol)
            {
                case '-':
                    result = x - y; break;
                case '+':
                    result = x + y; break;
                case '*':
                    result = x * y; break;
                case '/':
                    if (y == 0)
                        Console.WriteLine("0-a bolmek olmaz");
                    else
                        result = x / y; break;
                default: Console.WriteLine("duzgun simvol daxil et"); break;

            }
            return result;

        }

        static int CountOfSymbols(string symbols)
        {
            return symbols.Length;
        }

        static int CountOfWords(string word)
        {
            string[] words = word.Split(new char[] { ' ' });
            return words.Length;
        }

        static int SumOfNumbers(string num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += Convert.ToInt32(num[i]);
            }
            return sum;
        }
    }
}
