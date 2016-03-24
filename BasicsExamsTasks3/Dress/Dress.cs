using System;


namespace ConsoleApplication3
{
    class Dress
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outerDot = n - 2;
            int innerDot = n + 2;
            int firstDots = n - 4;
            int secondDots = 1;
            int middledotsBottom = n;
            Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
             
            for (int i =0; i < n/2; i++)
            {
                Console.WriteLine(new string('.', outerDot) + "*" + new string('.', innerDot) + "*" + new string('.', outerDot));
                outerDot -= 2;
                innerDot += 4;
            }
            Console.WriteLine("*" + new string('.', n - 2) + "*" + new string('.', n) + "*" + new string('.', n - 2) + "*");

            for ( int j = 0; j < n/2-1; j++ )
            {
                
                Console.WriteLine("*" + new string('.', firstDots) + "*" + new string('.', secondDots) + "*" + new string('.', n) + "*" + new string('.', secondDots) + "*" + new string('.', firstDots) + "*");
                firstDots -= 2;
                secondDots += 2;
            }
            for (int k = 0; k < n-1; k++ )
            {
                Console.WriteLine(new string('.', n - 1 - k) + "*" + new string('.', middledotsBottom) + "*" + new string('.', n - 1 - k));
                middledotsBottom += 2;
            }
            Console.WriteLine(new string('*', n * 3));
            
        }
    }
}
