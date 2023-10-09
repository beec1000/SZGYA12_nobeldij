using System;
using System.Collections.Generic;
using System.Text;

namespace nobeldij
{
    class Nobeldijasok
    {
        public int DijazasEve { get; set; }
        public string Nev { get; set; }
        public int SzuletesHalalozas { get; set; }
        public string Orszagkod { get; set; }

        public Nobeldijasok(string r)
        {
            string[] v = r.Split(';', '-');
            this.DijazasEve = int.Parse(v[0]);
            this.Nev = v[1];
            this.SzuletesHalalozas = int.Parse(v[2]);
            this.Orszagkod = v[3];
        }


    }
}
