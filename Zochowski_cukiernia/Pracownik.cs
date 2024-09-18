using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zochowski_cukiernia
{
    internal class Pracownik
    {
        static int number = 1;
        public int Numer { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Stanowisko { get; set; }
        public Pracownik(string name, string lastName, string stanowisko)
        {
            this.Numer = number;
            number += 1;
            this.Imie = name;
            this.Nazwisko = lastName;
            this.Stanowisko = stanowisko;
        }
    }
}
