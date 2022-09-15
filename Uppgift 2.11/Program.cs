using System;

namespace Uppgift_2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många meter hoppade Alma?");
            string a = Console.ReadLine();
            Console.WriteLine("Och hur längre hoppade Elin?");
            string b = Console.ReadLine();
            a =  a + b;
            Console.WriteLine("Så Elin hoppade" a);
        }
    }    
}