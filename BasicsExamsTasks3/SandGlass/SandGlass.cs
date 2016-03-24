using System;


namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*',n));
            int outerDots = 1;
            int symbol = n - 2;
            for (int i =0;i < n/2; i++)
            {
                Console.WriteLine(new string('.',outerDots) + new string('*',symbol) + new string('.',outerDots));
                outerDots++;
                symbol -= 2;
            }
            outerDots = n / 2 - 1;
            symbol = n * 3 / n;
            for ( int i =0; i < n/2-1; i ++ )
            {
                Console.WriteLine(new string('.', outerDots) + new string('*', symbol) + new string('.', outerDots));
                outerDots--;
                symbol += 2;
                
            }
            Console.WriteLine(new string('*',n));
        }
    }
}
