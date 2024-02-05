using System;

namespace Uppgift_3_Listor_inl
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> area = new Dictionary<string, int>();
            area["sverige"] = 450;
            area["norge"] = 385;
            area["danmark"] = 43;
            area["finland"] = 338;
            string land = Console.ReadLine();
            Console.WriteLine(area[land]);

        }

    }
}