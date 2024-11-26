using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        HashSet<int> takenCodes = new HashSet<int>();  // A lefoglalt kódok

        for (int i = 0; i < N; i++)
        {
            string[] parts = Console.ReadLine().Split();
            string type = parts[0];
            int x = int.Parse(parts[1]);

            if (type == "1")
            {
                // Új turista érkezik
                // Ha a kedvenc szám már foglalt, keressük meg a legkisebb szabad kódot
                while (takenCodes.Contains(x))
                {
                    x++;
                }

                // Kiírjuk a turistának kiosztott kódot
                Console.WriteLine(x);

                // Lefoglaljuk a kódot
                takenCodes.Add(x);
            }
            else
            {
                // Feloldjuk a kódot
                takenCodes.Remove(x);
            }
        }
    }
}
// Sajnos nem fut zöldre 0.06 s nél nem tudom gyorsabbra. 
// nem pharsoltam az első karaktert, hogy ott ne veszítsek időt.