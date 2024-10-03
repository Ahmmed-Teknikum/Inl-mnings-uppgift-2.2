using System;

namespace Inlämnings_._uppgift_._2_._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin, mätt i meter?");
            string Elin = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade Alma, mätt i meter?");
            string Alma = Console.ReadLine();
            int x = int.Parse(Elin);
            int y = int.Parse(Alma);
            int skillnad = x-y;
            
            Console.WriteLine("Elin hoppade " + skillnad + " meter längre än Alma.");


        }
    }
}