using System;


namespace ConsoleApplication2
{
    class Boat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int asterisk = 1;
            int dot = n - 1;

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(new string('.', dot) + new string('*', asterisk) + new string('.', n));
                asterisk += 2;
                dot -= 2;
            }
           
            for (int j = 1; j <=n / 2; j++)
            {
                Console.WriteLine(new string('.', dot + 2) + new string('*', asterisk - 2) + new string('.', n));
                asterisk -= 2;
                dot += 2;
            }
           
                if (n / 2 == 1)


                {
                    Console.WriteLine(new string('*', n * 2));
                }
            
            
            else
                for (int k = 1; k< n / 2; k++)
                {
                    Console.WriteLine(new string('*', n * 2));
                    Console.WriteLine(new string('.', 1) + new string('*', 2 * n - 2) + new string('.', 1));
                }
        }
    }
}
