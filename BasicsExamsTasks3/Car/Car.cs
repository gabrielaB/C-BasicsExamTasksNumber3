using System;


namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
            int outerDots = n - 1;
            int innerDots = n;

            for (int i = 0; i < n/2-1; i++)
            {
                Console.WriteLine(new string('.', outerDots) + "*" + new string('.', innerDots) + "*" + new string('.', outerDots));
                outerDots--;
                innerDots += 2;
            }
            {
                Console.WriteLine(new string('*',n / 2 + 1) + new string('.',n * 2 - 2) + new string('*',n / 2 + 1));
            }
            for (int i =0; i < n/2 -2; i++)
            {
                Console.WriteLine("*" + new string('.', n * 3 - 2) + "*");
            }
            Console.WriteLine(new string('*', n * 3));
            for ( int i = 0; i < n/2 -2; i++)
            {
                Console.WriteLine(new string('.', n / 2) + "*" + new string('.', n / 2 - 1) + "*" + new string('.', n - 2) + "*" + new string('.', n / 2 - 1) + "*" + new string('.', n / 2));
            }
            Console.WriteLine(new string('.', n / 2) + new string('*', n / 2 + 1) + new string('.', n - 2) + new string('*', n / 2 + 1) + new string('.', n / 2));
        }
    }
}
