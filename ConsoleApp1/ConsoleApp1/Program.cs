// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Net.Http.Headers;
    {

    }

    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please Enter a num:");
            int num =int.Parse(Console.ReadLine());
            int product = 1;
            int digit;
            while (num > 0)
            {
                digit = num % 10;
                if (digit  != 0)
                {
                    product *= digit;
                    num /= 10;
                    Console.WriteLine("The product of the digits of the entered num without zero:" + product);
                }
            }
        }
    }
