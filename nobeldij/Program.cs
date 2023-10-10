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

            var f5 = dijazottak.Where(k => k.Orszag == orK).ToList();

            if (f5.Count == 0) Console.WriteLine("\t A megadott országból nem volt díjazott");
            else if (f5.Count == 1)
            {
                Console.WriteLine($"A megadott ország díjazottja: \n\tNév: {f5[0].Nev} \n\tÉv: {f5[0].Ev} \n\tSz/H: {f5[0].SzHStr}");
            }
            else Console.WriteLine($"\tA megadott országból {f5.Count} díjazott volt.");

            

        }
    }
}
