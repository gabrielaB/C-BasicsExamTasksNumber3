using System;


namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.',n-1)+ "*" + new string('.',n-1));
            int outerDots = n - 2;
            int innerDots = 1;
            int bottomDots = n / 2;
            for (int i =0; i < n-2; i++)
            {
                Console.WriteLine(new string('.',outerDots) + "*" + new string('.',innerDots) + "*" + new string('.',outerDots));
                outerDots--;
                innerDots += 2;
            }
            Console.WriteLine("*" + new string('.',n*2-3) + "*");
            for (int i = 1; i < n/4; i++)
            {
                Console.WriteLine("*" + new string('.',n*2-3) + "*");
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("*" + new string('.',n/2) + new string('*',n-3) + new string('.',n/2) + "*");
            }
            for (int i = 0; i < n / 4; i++)
            {
                Console.WriteLine("*" + new string('.', n * 2 - 3) + "*");
            }
            Console.WriteLine(new string('*', n * 2 - 1));
                
        }
    }
}
