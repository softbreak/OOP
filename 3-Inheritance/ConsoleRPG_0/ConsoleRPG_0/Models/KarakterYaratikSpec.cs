using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_0.Models
{
    internal class KarakterYaratikSpec:BaseEntity
    {
        public string MaksimumCan { get; set; }
        public string MevcutCan { get; set; }
        public string MaksimumEnerji { get; set; }
        public string MevcutEnerji { get; set; }

    }
}
