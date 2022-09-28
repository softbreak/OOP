using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_0.Models
{
   
    internal class Karakter
    {
        public Karakter()
        {
            Can = 100;
            Enerji = 50;
        }


        public string Isim { get; set; }
        public int Enerji { get; set; }
        public int Can { get; set; } // Property

    }
}
