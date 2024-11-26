using System;

class Program
{
    static long CountDecodings(string s)
    {
        int n = s.Length;

        //  tömb[i] a dekódolások számát tárolja az első i karakterre
        long[] tömb = new long[n + 1];

        // Üres string-nek egyetlen dekódolása van
        tömb[0] = 1;

        for (int i = 1; i <= n; i++)
        {
            // Az aktuális karakter egyedül is dekódolható, ha nem 0
            if (s[i - 1] != '0')
            {
                tömb[i] += tömb[i - 1];
            }

            // Ha az előző két karakter érvényes szám, akkor hozzáadjuk a tömb[i - 2] értéket
            if (i > 1 && s[i - 2] != '0' && int.Parse(s.Substring(i - 2, 2)) >= 10 && int.Parse(s.Substring(i - 2, 2)) <= 26)
            {
                tömb[i] += tömb[i - 2];
            }
        }

        return tömb[n];
    }

    static void Main()
    {
        string input;

        // Bemenet beolvasása egyetlen sorban
        while (true)
        {
            input = Console.ReadLine().Trim();

            // A 0-s bemenet jelzi a befejezést
            if (input == "0")
                break;

            
            Console.WriteLine(CountDecodings(input));
        }
    }
}
