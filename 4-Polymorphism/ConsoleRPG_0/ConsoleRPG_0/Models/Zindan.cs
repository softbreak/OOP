using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_0.Models
{
    
    internal class Zindan:BaseEntity
    {
        public Bolge Bolge { get; set; }
        public Sehir Sehir { get; set; }
        public List<Yaratik> Yaratiklar { get; set; }
        public List<ElitYaratik> ElitYaratiklar { get; set; }


    }
}
