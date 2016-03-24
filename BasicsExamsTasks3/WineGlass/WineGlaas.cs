using System;


namespace _16.WineGlass
{
    class WineGlaas
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outerDot = 0;
            int asterisk = n - 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.', outerDot) + "\\" + new string('*', asterisk) + "/" + new string('.', outerDot));
                outerDot++;
                asterisk -= 2;

            }
            if (n < 12)
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine(new string('.', outerDot - 1) + "|" + "|" + new string('.', outerDot - 1));

                }
            else
                for (int i = 0; i < n / 2 - 2; i++)
                {
                    Console.WriteLine(new string('.', outerDot - 1) + "|" + "|" + new string('.', outerDot - 1));

                }
            if (n < 12)
            {
                Console.WriteLine(new string('-', n));

            }
            else
            {
                Console.WriteLine(new string('-', n));
                Console.WriteLine(new string('-', n));
            }
        }
    }
}
