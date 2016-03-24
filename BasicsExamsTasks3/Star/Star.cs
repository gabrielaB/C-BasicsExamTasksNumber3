using System;


namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.', n) + "*" + new string('.', n));
            int outerDots = n - 1;
            int innerdots = 1;
            int bottomMiddleDot = 1;
            for ( int i =0; i < n/2 -1; i++)
            {
                Console.WriteLine(new string('.', outerDots) + "*" + new string('.', innerdots) + "*" + new string('.', outerDots));
                outerDots--;
                innerdots += 2;
            }
            {
                Console.WriteLine(new string('*', (n * 2) / 3) + new string('.', n - 1) + new string('*', (n * 2) / 3));
            }

            outerDots = 1;
            innerdots = n * 2 - 3;
            for ( int i =0; i < n/2; i++)
            {

                Console.WriteLine(new string('.', outerDots) + "*" + new string('.', innerdots) + "*" + new string('.', outerDots));
                outerDots++;
                innerdots -= 2;
            }
            {
                Console.WriteLine(new string('.', n / 2) + "*" + new string('.', n / 2 - 1) + "*" + new string('.', n / 2 - 1) + "*" + new string('.', n / 2));
            }
            outerDots = n / 2 - 1;
            innerdots = n / 2 - 1;
            for( int i = 0; i < n/2-1; i++)
            {
                Console.WriteLine(new string('.', outerDots) + "*" + new string('.', innerdots) + "*" + new string('.', bottomMiddleDot) + "*" + new string('.', innerdots) + "*" + new string('.', outerDots));
                outerDots--;
                bottomMiddleDot += 2;
            }
            Console.WriteLine(new string('*', n / 2 + 1) + new string('.', n - 1) + new string('*', n / 2 + 1));
                
               

        }
    }
}
