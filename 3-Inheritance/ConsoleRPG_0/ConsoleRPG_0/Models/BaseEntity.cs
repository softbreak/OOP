using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_0.Models
{
    internal class BaseEntity 
    {
        public string Isim { get; set; }
        public DateTime VeriYaratmaTarihi { get; set; }
        public DateTime? VeriDegistirmeTarihi { get; set; } //tipin sonuna ? koyarak onun nullable olmasını sagladık
        public DateTime?  VeriSilmeTarihi { get; set; } //Pasife cekme

       


    }
}
