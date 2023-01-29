using System;

namespace Imposible_Figur_triangle_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    if (j > i && j < 10 + (10 - i))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
