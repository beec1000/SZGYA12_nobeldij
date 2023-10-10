using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace nobeldij
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Nobeldijasok> dijazottak = new List<Nobeldijasok>();

            using var sr = new StreamReader(@"..\..\..\src\orvosi_nobeldijak.txt",
                encoding: Encoding.UTF8);
            _ = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                dijazottak.Add(new Nobeldijasok(sr.ReadLine()));
            }


            Console.WriteLine($"3. feladat: \nDíjazottak száma: {dijazottak.Count} fő");

            Console.WriteLine("4. feladat");

            var f4 = dijazottak.Max(k => k.Ev);

            Console.WriteLine($"Utolsó év: {f4}");

            Console.WriteLine("5. feladat");
            Console.WriteLine("Kérem adja meg egy ország kódját: ");
            var orK = Console.ReadLine();

            var f5 = dijazottak.Where(k => k.Orszag == orK);

            Console.WriteLine($"A megadott ország díjazottja: \nNév: {} \nÉv: {} \nSz/H: {}");

        }
    }
}
