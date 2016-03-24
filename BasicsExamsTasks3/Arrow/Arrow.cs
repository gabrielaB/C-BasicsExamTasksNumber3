using System;
using System.Collections.Generic;


namespace _15.Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outerDot;
            int innerDot;

            Console.WriteLine(new string('.', n / 2) + new string('#', n) + new string('.', n / 2));   
            for (int i=0; i < n-2; i++)
            {
                Console.WriteLine(new string('.', n/2) + "#" + new string('.', n - 2) + "#" + new string('.',n/2));
            }
            Console.WriteLine(new string('#', n / 2 + 1) + new string('.', n - 2) + new string('#', n / 2 + 1));

            outerDot = 1;
            innerDot = 2 * n - 5;
                     for (int i =1;i < n-1; i++)
            {
                Console.WriteLine(new string('.',outerDot)+ "#" + new string('.',innerDot) + "#" + new string('.',outerDot));
                outerDot++;
                innerDot -= 2;
            }
            Console.WriteLine(new string('.',n-1)+ "#" + new string('.',n-1));
        }
    }
}
