using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cityPlaque = new MyDictionary<int, string>();
            cityPlaque.Add(01, "Adana");
            Console.WriteLine(cityPlaque.Lenght);
            cityPlaque.Add(23, "Elazığ");
            Console.WriteLine(cityPlaque.Lenght);
            cityPlaque.Add(44, "Malatya");
            Console.WriteLine(cityPlaque.Lenght);
            cityPlaque.ToDictionary();

            
        }
    }
}
