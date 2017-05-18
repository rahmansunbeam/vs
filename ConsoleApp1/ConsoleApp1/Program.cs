using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior maximus = new Warrior("Maximus", 1000, 120, 40);

            Warrior bob = new Warrior("Bob", 1000, 120, 40);

            Battle.StartFight(maximus, bob);

            Console.ReadLine();
            //try
            //{
            //    Console.WriteLine("Enter the first number, ");
            //    var a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter the second number, ");
            //    var b = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter the third number, ");
            //    var c = Convert.ToInt32(Console.ReadLine());

            //    var helper = new calculateNumber2();

            //    Console.Write("x * y + z = " + helper.calc2(a, b, c).Item1 +
            //    "\nx * y + x * z = " + helper.calc2(a, b, c).Item2 +
            //    "\nx in even? " + helper.calc2(a, b, c).Item3 + "\n");
            //}
            //catch (Exception)
            //{                
            //    throw;
            //}
        }

        //public static int calculateNumber(int x, int y)
        //{
        //    return x * y;
        //}

        //public class calculateNumber2
        //{
        //    public int calc1(int x, int y)
        //    {
        //        return x * y;
        //    }

        //    public Tuple<int, int, string> calc2(int x, int y, int z)
        //    {
        //        return Tuple.Create((x * y + z), (x * y + x * z), ((x % 2 == 0) ? "...it is" : "...no it's not"));
        //    }
        //}

    }    
}
