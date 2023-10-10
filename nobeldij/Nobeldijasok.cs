using System;
using System.Collections.Generic;
using System.Text;

namespace nobeldij
{
    class Nobeldijasok
    {
        public int Ev { get; set; }
        public string Nev { get; set; }
        public string SzHStr { get; set; }

        public (int Szuletes, int? Halal) SzH { get; set; }

        public string Orszag { get; set; }



        public Nobeldijasok(string s)
        {
            string[] v = s.Split(';');
            this.Ev = int.Parse(v[0]);
            this.Nev = v[1];
            this.SzHStr = v[2];

            var szhv = v[2].Split('-');
            SzH = (Szuletes: int.Parse(szhv[0]),
                   Halal: szhv[1].Length == 0 ? 0 : int.Parse(szhv[1]));

            this.Orszag = v[3];
        }
    }
}

