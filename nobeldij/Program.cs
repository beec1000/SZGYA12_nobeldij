using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nobeldij
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Nobeldijasok> nobeldijasok = new List<Nobeldijasok>();

            using var sr = new StreamReader(@"..\..\..\src\orvosi_nobeldijak.txt");
            _ = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                nobeldijasok.Add(new Nobeldijasok(sr.ReadLine()));
            }


            Console.WriteLine($"3. feladat: \nDíjazottak száma: {nobeldijasok.Count} fő");


            Console.WriteLine("4. feladat");

            var f4 = nobeldijasok.OrderByDescending(k => k.DijazasEve).First();

            Console.WriteLine($"Utolsó év: {f4}");

            Console.WriteLine("5. feladat");

        }
    }
}
