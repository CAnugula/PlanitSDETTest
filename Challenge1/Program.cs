using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                var output = "";
                if (i % 3 == 0)
                {
                    output += "Planit";
                }

                if (i % 5 == 0)
                {
                    output += "Testing";
                }

                if (output.Length == 0)
                {
                    output += i;
                }

                Console.Write($"{output} ");
            }

            Console.ReadLine();
        }
    }
}
