using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_0.Models
{
    internal class Sehir:BaseEntity
    {
        public List<Irk> Irklari { get; set; }
        public Bolge Bolge { get; set; }


    }
}
