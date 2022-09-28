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
            
            Karakter birinciOyuncu = new Karakter();

           
            

            
            Console.WriteLine("Lütfen karakterinizin ismini veriniz");
            birinciOyuncu.Isim = Console.ReadLine();


            Console.WriteLine($"Yarattıgınız karakterin ismi => {birinciOyuncu.Isim} , canı => {birinciOyuncu.Can}, enerjisi => {birinciOyuncu.Enerji}");
            Console.ReadLine();
            
           
        }
    }
}
