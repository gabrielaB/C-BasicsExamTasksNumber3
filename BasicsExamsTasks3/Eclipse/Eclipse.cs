using System;


namespace _13
{
    class Program
    {
        static void Main(string[] args)   razstoqnieto na tiretata  v  tretiq Console.WriteLine ????????
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" " + new string('*',n*2-2) + new string(' ',n+2) + new string('*',n*2-2) + " ");
            for (int i = 1; i < n/2; i++)
            {
                Console.WriteLine("*" + new string('/', n * 2 - 2) + "*" + new string(' ', n) + "*" + new string('/', n * 2 - 2) + "*");
            }
            Console.WriteLine("*" + new string('/',n*2-2) + "*"   + new string ('-', n-1) +  "*" + new string('/', n * 2 - 2) + "*" );
            for (int i=1; i< n/2; i++)
            {
                Console.WriteLine("*" + new string('/', n * 2 - 2) + "*" + new string(' ', n) + "*" + new string('/', n * 2 - 2) + "*");
            }
            Console.WriteLine(" " + new string('*', n * 2 - 2) + new string(' ', n + 2) + new string('*', n * 2 - 2) + " ");

        }
    }
}
