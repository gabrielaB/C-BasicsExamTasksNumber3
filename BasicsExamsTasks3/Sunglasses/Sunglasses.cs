using System;


namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n * 2) + new string(' ',n) + new string('*', n * 2));

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("*" + new string('/', n * 2 - 2) + "*" + new string(' ', n) + "*" + new string('/', n * 2 - 2) + "*");
            }
            Console.WriteLine("*" + new string('/', n * 2 - 2) + "*" + new string('|',n) + "*" + new string('/', n * 2 - 2) + "*");

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("*" + new string('/', n * 2 - 2) + "*" + new string(' ', n) + "*" + new string('/', n * 2 - 2) + "*");
            }
            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));
        }
    }
}


