using System;

namespace EWTRLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool even = n % 2 == 0 ? true : false;
            
            if (n >= 2 && n <= 27)
            {
                for (int i = n; i > 0; i--)
                {
                    Console.Write(new string(' ', i * 2));
                    Console.Write(new string('\\', i));
                    Console.Write(new string('-', (n - i) * 6));
                    Console.WriteLine(new string('/', i));
                }
                
                Console.Write('|' + new string('-', n - 1));
                Console.Write(new string('#', n * 4));
                Console.WriteLine(new string('-', n - 1) + '|');
                
                if (even)
                {
                    Console.Write('|' + new string('-', n - 1));
                    Console.Write(new string('#', n * 4));
                    Console.WriteLine(new string('-', n - 1) + '|');
                }

                Console.Write('|' + new string('~', n - 1));
                Console.Write(new string('\\', 2 * n - 3) + " ESTD " + new string('/', 2 * n - 3));
                Console.WriteLine(new string('~', n - 1) + '|');

                Console.Write('|' + new string('-', n - 1));
                Console.Write(new string('#', n * 4));
                Console.WriteLine(new string('-', n - 1) + '|');
                
                if (even)
                {
                    Console.Write('|' + new string('-', n - 1));
                    Console.Write(new string('#', n * 4));
                    Console.WriteLine(new string('-', n - 1) + '|');
                }
                
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(new string(' ', i * 2));
                    Console.Write(new string('\\', i));
                    Console.Write(new string('-', (n - i) * 6));
                    Console.WriteLine(new string('/', i));
                }
            }
        }
    }
}
