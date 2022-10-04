using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_0.Models
{
    //Irk BaseEntity'den miras aldı... Irk aslında BaseEntity'dir...
    internal class Irk : BaseEntity
    {
        public Irk(string isim)
        {
            Isim = isim;
            switch (Isim.ToLower())
            {
                case "insan":
                    IradeModifikasyonu = 1;
                    break;
                case "ork":
                    GucModifikasyonu = 2;
                    break;
                case "elf":
                    CeviklikModifikasyonu = 1;
                    break;
                case "cuce":
                    DayaniklilikModifikasyonu = 2;
                    break;
                case "undead":
                    GucModifikasyonu = 3;
                    IradeModifikasyonu = 1;
                    break;

            }
        }
        public int GucModifikasyonu { get; set; }
        public int CeviklikModifikasyonu { get; set; }
        public int IradeModifikasyonu { get; set; }
        public int DayaniklilikModifikasyonu { get; set; }

        public List<Karakter> Karakterler { get; set; }
        public Sehir BaslangicSehri { get; set; }



    }
}
