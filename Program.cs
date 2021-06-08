using System;

namespace _22222Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("The cost of x:");
            int xrates = int.Parse(Console.ReadLine());
            Console.Write("The cost of y:");
            int yrates = int.Parse(Console.ReadLine());
            Console.Write("Input petrol's price of x:");
            int petrolX = int.Parse(Console.ReadLine());
            Console.Write("Input petrol's price of y:");
            int petrolY = int.Parse(Console.ReadLine());
            x = xrates + petrolX;
            y = yrates + petrolY;
            if (x > y)
            {
                Console.WriteLine("2nd is chaper");
            }else if (x < y)
            {
                Console.WriteLine("1st is cheaper");
            }else if (x == y)
            {
                Console.WriteLine("Same cost");
            }
        }
    }
}
