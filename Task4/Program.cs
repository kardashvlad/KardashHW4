using System;
using Task4.Classes;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            River river = new River();
            Console.WriteLine(river.GetInfo());
            Mountain mountain = new Mountain();
            Console.WriteLine(mountain.GetInfo());
            Console.ReadKey();
        }
    }
}
