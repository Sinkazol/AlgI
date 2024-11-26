using System;
using System.Collections.Generic;

class Program
{
    // Bézout-tétel alapján ellenőrizzük, hogy előállítható-e a kívánt mennyiség
    static bool IsPossible(int a, int b, int c)
    {
        return c <= Math.Max(a, b) && c % LKO(a, b) == 0;
    }

    // Legnagyobb közös osztó (LKO) kiszámítása
    static int LKO(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Minimális lépések kiszámítása
    static int MinSteps(int a, int b, int c)
    {
        if (!IsPossible(a, b, c))
            return -1;

        // Állapotok tárolása (x: első edény vízszintje, y: második edény vízszintje)
        var visited = new bool[a + 1, b + 1];
        var queue = new Queue<Tuple<int, int, int>>();
        queue.Enqueue(new Tuple<int, int, int>(0, 0, 0));

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            int x = current.Item1; // Az első edény vízszintje
            int y = current.Item2; // A második edény vízszintje
            int steps = current.Item3; // Jelenlegi lépések száma

            // Ha elértük a kívánt vízmennyiséget
            if (x == c || y == c)
                return steps;

            // Már látogatott állapot
            if (visited[x, y]) continue;

            visited[x, y] = true;

            // Lehetséges állapotok generálása
            var nextStates = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(a, y), // Töltsd meg az első edényt
                new Tuple<int, int>(x, b), // Töltsd meg a második edényt
                new Tuple<int, int>(0, y), // Ürítsd ki az első edényt
                new Tuple<int, int>(x, 0), // Ürítsd ki a második edényt
                new Tuple<int, int>(x - Math.Min(x, b - y), y + Math.Min(x, b - y)), // Önts át az első edényből a másodikba
                new Tuple<int, int>(x + Math.Min(y, a - x), y - Math.Min(y, a - x))  // Önts át a második edényből az elsőbe
            };

            // További állapotok hozzáadása
            foreach (var state in nextStates)
            {
                if (!visited[state.Item1, state.Item2])
                {
                    queue.Enqueue(new Tuple<int, int, int>(state.Item1, state.Item2, steps + 1));
                }
            }
        }

        return -1;
    }

    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine()); // Tesztesetek száma
        var results = new List<int>();

        for (int i = 0; i < t; i++)
        {
            int a = int.Parse(Console.ReadLine()); // Az első edény kapacitása
            int b = int.Parse(Console.ReadLine()); // A második edény kapacitása
            int c = int.Parse(Console.ReadLine()); // A kívánt vízmennyiség

            results.Add(MinSteps(a, b, c));
        }

        // Az összes teszteset kimenete egyszerre jelenjen meg
        Console.WriteLine(string.Join("\n", results));
    }
}
