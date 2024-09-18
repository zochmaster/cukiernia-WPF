using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zochowski_cukiernia
{
    internal class Produkt
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public string Rodzaj { get; set; }
        public Produkt(string nazwa, double cena, string rodzaj)
        {
            this.Nazwa = nazwa;
            this.Cena = cena;
            this.Rodzaj = rodzaj;
        }
        public Produkt()
        {
            this.Rodzaj = "";
        }

    }
}
