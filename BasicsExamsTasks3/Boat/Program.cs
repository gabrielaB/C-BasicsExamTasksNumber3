using System;


namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.',n-1)+ "*" + new string('.',n));
            int outerDots = n - 3;
            int asterisk = 3;
            for (int i =0;i< n / 2; i++)
            {
                Console.WriteLine(new string('.',outerDots) + new string('*',asterisk) + new string('.',n));
                outerDots -= 2;
                asterisk += 2;
            }
            outerDots = 2;
            asterisk = n - 2;
            for (int i =0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.',outerDots) + new string('*',asterisk) + new string('.',n));
                outerDots += 2;
                asterisk -= 2;
            }
            Console.WriteLine(new string('*',n*2));
            if (n >= 5)
            {
                Console.WriteLine("." + new string('*',n*2-2) + ".");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
