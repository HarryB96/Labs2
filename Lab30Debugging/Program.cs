using System;

namespace Lab30Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                var j = $"Your number doubled is {i * 2}";
                Console.WriteLine($"{i} ");
            }

            
        }
    }
}
