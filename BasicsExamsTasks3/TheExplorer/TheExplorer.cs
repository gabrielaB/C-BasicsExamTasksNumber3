using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',n/2) + "*" + new string('-',n/2));
            int outerDash = n / 2 - 1;
            int innerDash = 1;
            for (int i=0; i < n/2; i++)
            {
                Console.WriteLine(new string('-',outerDash) + "*" + new string('-',innerDash)+ "*" + new string('-',outerDash));
                outerDash--;
                innerDash += 2;
            }
            outerDash = 1;
            innerDash = n - 3;
            for (int i=1; i < n/2 ; i++)
            {
                Console.WriteLine(new string('-',outerDash) + "*" + new string('-',innerDash -i) + "*" + new string('-',outerDash));
                outerDash++;
                innerDash--;
            }
            Console.WriteLine(new string('-',n/2) + "*" + new string('-', n / 2));
        }
    }
}
