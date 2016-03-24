using System;


namespace ConsoleApplication4
{
    class Plane
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outerDots = (n * 3 - 2) / 2;
            int innerDots = 1;
            int secondOuterDots = n - 4;
            int secondInnerDots = 1;
            int bottomOuterDots = n - 1;
            int bottomInnerDots = n;
            Console.WriteLine(new string('.', (n * 3 - 1) / 2) + "*" + new string('.', (n * 3 - 1) / 2));

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine(new string('.', outerDots) + "*" + new string('.', innerDots) + "*" + new string('.', outerDots));
                outerDots--;
                innerDots += 2;

            }
            outerDots = n;
            innerDots = n + 2;

            for (int i = 0; i < n/2; i++)
            {
                outerDots -= 2;
                Console.WriteLine(new string('.', outerDots) + "*" + new string('.', innerDots) + "*" + new string('.', outerDots));
                innerDots += 4;
            }
            for ( int i = 1; i < n/2-1; i++)
                {
                
                    Console.WriteLine("*" + new string('.', n - 2) + "*" + new string('.', n) + "*" + new string('.', n - 2) + "*");
                
                }
                for (int j = 1; j < n / 2; j++)
                {
                    Console.WriteLine("*" + new string('.', secondOuterDots) + "*" + new string('.', secondInnerDots) + "*" + new string('.', n) + "*" + new string('.', secondInnerDots) + "*" + new string('.', secondOuterDots) + "*");
                    secondOuterDots -= 2;
                    secondInnerDots += 2;
                }
                for (int y = 1; y < n; y++)
                {
                    Console.WriteLine(new string('.', bottomOuterDots) + "*" + new string('.', bottomInnerDots) + "*" + new string('.', bottomOuterDots));
                    bottomOuterDots--;
                    bottomInnerDots += 2;
                }
                Console.WriteLine(new string('*', n * 3));




            }
        }
    }



