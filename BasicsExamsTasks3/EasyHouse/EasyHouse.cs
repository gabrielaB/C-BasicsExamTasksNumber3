using System;


namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outerDash = n / 2;
            int symbol = 1;
            for (int i =0; i < n/2+1; i++)
            {
                Console.WriteLine(new string('-', outerDash) + new string('*', symbol) + new string('-', outerDash));
                outerDash--;
                symbol += 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("|" + new string('*', n - 2) + "|");
            }
            

        }
    }
}
