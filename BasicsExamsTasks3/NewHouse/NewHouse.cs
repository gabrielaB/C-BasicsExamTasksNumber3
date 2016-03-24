using System;


namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.', n / 2) + "*" + new string('.', n / 2));
            int outerDots = n / 3;
            int innerDots = 1;
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine(new string('.', outerDots) + "*" + new string('.', innerDots) + "*" + new string('.', outerDots));
                outerDots--;
                innerDots += 2;
            }
            Console.WriteLine(new string('*', n));

            {
                outerDots = n / 2 - 2;
                for (int i = 0; i < n / 2 - 1; i++)
                    if (n <= 5)
                    {
                        outerDots = 1;
                        innerDots = 1;
                        Console.WriteLine(new string('.', outerDots) + "*" + new string('.', innerDots) + "*" + new string('.', outerDots));
                        Console.WriteLine(new string('.', outerDots) + new string('*', n - 2) + new string('.', outerDots));
                    }
                    else
                    {
                        outerDots = n / 2 - 2;
                        innerDots = 3;
                        Console.WriteLine(new string('.', outerDots) + "*" + new string('.', innerDots) + "*" + new string('.', outerDots));
                        Console.WriteLine(new string('.',n/2-2)+new string('*',5)+ new string('.',n/2-2));
                    }
               
            }
        }
    }
}
