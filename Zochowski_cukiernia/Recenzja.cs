using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zochowski_cukiernia
{
    internal class Recenzja
    {
        public int Ocena { get; set; }
        public string Tresc { get; set; }
        public string Autor { get; set; }
        public Recenzja(string autor, int ocena, string tresc)
        {
            this.Autor = autor;
            this.Ocena = ocena;
            this.Tresc = tresc;
        }
    }
}
