using System;
using System.Text;

public class Test
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine()); // Tesztesetek száma
        for (int caseNumber = 1; caseNumber <= t; caseNumber++)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
           int b = int.Parse(input[1]);

            
            // a c# kód túl lassu volt ezért ezt az optimálást találtam.
            const int MODULO = 100000;// a Fibonacci-értékeket MODULO = 100000 alapján számoljuk, csak ennyi különböző érték lehet.
            int[] frequency = new int[MODULO];
            //egyes Fibonacci-értékek előfordulását tárolja a MODULO tartományon belül.

            // Kezdő Fibonacci értékek
            int f1 = 0, f2 = 1;

            // Fibonacci számítás az A-tól A+B tartományban
            for (int i = 1; i <= a + b; i++)
            {
                if (i >= a)
                {
                    frequency[f1]++;
                }

                int fn = (f1 + f2) % MODULO;
                f1 = f2;
                f2 = fn;
            }

            // Kimenet generálása frekvenciatömb alapján
            StringBuilder result = new StringBuilder();
            result.Append($"Case {caseNumber}: ");
            int count = 0;

            for (int i = 0; i < MODULO; i++)
            {
                while (frequency[i] > 0 && count < 100)
                {
                    result.Append(i).Append(" ");
                    frequency[i]--;
                    count++;
                }
                if (count == 100) break;
            }

            // Kimenet megjelenítése
            Console.WriteLine(result.ToString().Trim());
        }
    }
}
