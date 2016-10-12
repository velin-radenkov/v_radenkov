using System;


namespace Print
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Printing odd numbers from 1 to 100");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("End");
        }
    }
}
