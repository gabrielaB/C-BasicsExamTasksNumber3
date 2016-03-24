using System;


namespace ConsoleApplication1
{
    class Headphones
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int asterisk = 3;
            int outerDash = n / 2 - 1;
            int innerDash = n - 2;
            Console.WriteLine(new string('-', n / 2) + new string('*', n + 2) + new string('-', n / 2));

            for(int i = 0; i <n;i++)
            {
                Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n) + "*" + new string('-', n / 2));
            }
            for (int j = 0; j < n / 2; j++)
            {
                Console.WriteLine(new string('-', outerDash) + new string('*', asterisk) + new string('-', innerDash) + new string('*', asterisk) + new string('-', outerDash));

                outerDash--;
                innerDash -= 2;
                asterisk += 2;
            }

            for (int k = n / 2 - 1; k >= 0; k--)
               {
                Console.WriteLine(new string('-', n/2-k)+ new string('*',2*k+1)+ new string('-', n-2*k) + new string('*', 2*k+1) + new string('-', n/2-k));

                
                }
            }
           
        }
    }

