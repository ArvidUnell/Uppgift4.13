using System;
namespace Uppgift4_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv 2 ord på varsin rad");

            string ord1 = Console.ReadLine();
            string ord2 = Console.ReadLine();

            for (int i = 0; i < ord2.Length; i++)
            {
                if (ord1.Contains(ord2[i]))
                {
                    ord1 = ord1.Remove(ord1.IndexOf(ord2[i]), 1);
                }
            }

            for (int i = 0;i < ord1.Length; i++)
            {
                if (ord1[(i+1)..].Contains(ord1[i]))
                {
                    ord1 = ord1.Remove(i, 1);
                }
            }

            Console.WriteLine(ord1);

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}