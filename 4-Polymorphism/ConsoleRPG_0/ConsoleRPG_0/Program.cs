using ConsoleRPG_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleRPG_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Irk i = new Irk("insan");
            Sinif s = new Sinif("savasci");

            Karakter k = new Karakter(s, i);

            Console.WriteLine(k.YakinSaldiri());

            Console.ReadLine();
           
        }
    }
}
