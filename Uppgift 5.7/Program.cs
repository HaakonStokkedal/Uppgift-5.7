using System;

namespace Uppgift_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] länder = new string[5];

            länder[0] = "Kina";
            länder[1] = "Indien";
            länder[2] = "USA";
            länder[3] = "Indonesien";
            länder[4] = "Pakistan";

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. {länder[i]}");
            }
            Console.WriteLine("Vilka siffror ska visas igen? (sätt mellanrum mellan siffrorna)");
            string siffror = Console.ReadLine();
            string[] Siffror = siffror.Split(' ');
            foreach(string siffraText  in Siffror)
            {
                int siffra = int.Parse(siffraText);
                Console.WriteLine($"{siffra}. {länder[siffra - 1]}");
            }
            Console.ReadKey();
        }
    }
}