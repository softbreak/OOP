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
            Seviye = 1;
            MaksimumCan = 100;
            MaksimumEnerji = 50;
            
        }

        
        public string Isim { get; set; } //Auto Property
        public int Seviye { get; set; }

        int _maksimumCan; //İlgili degerimiz Bir Encapsulation'a girecegi zaman field'inizi acıkca yazmalısınız...

        public int MaksimumCan 
        {
            //get ve set metotlarınız Property'nin Ram'deki ilgili degişken veri getirmesi veya o degişkeni veri ataması icin kullanacagınız metotlar
            get
            {
                if(Seviye == 1 && _maksimumCan != 100)
                {
                    throw new Exception("Karakter 1. seviyede olmasına ragmen can puanın bir sıkıntı var");
                }

                return _maksimumCan;
            }
            set
            {
                if(Seviye == 1 && value == 100)
                {
                    _maksimumCan = value;
                }
                else if( Seviye > 1 &&  value > _maksimumCan)
                {
                    _maksimumCan = value;
                }
                else
                {
                    //Console.WriteLine("Yanlıs bir can puanı atanmaya calısıldıgı icin deger otomatik 100'e cekildi");
                    //_maksimumCan = 100;
                    throw new Exception("Can puanı ile ilgili bir sorun olustu. 1. Seviyedeki bir karakterin can puanını lütfen kurcalamayın");
                }
            }
        
        } // Property , Karakterin ilgili seviye alabilecegi maksimum can puanıdır...
        public int MevcutCan { get; set; } //Karakterin mevcut sürecteki canını bildirir


        int _maksimumEnerji;


        public int MaksimumEnerji
        {
            get
            {
                if (Seviye == 1 && _maksimumEnerji != 100)
                {
                    throw new Exception("Karakterinizin enerji seviyesinde 1. seviyede olan bir karakter icin bir dengesizlik var");
                }

                return _maksimumEnerji;
            }

            set
            {
                if(Seviye == 1 && value == 50)
                {
                    _maksimumEnerji = value;
                }
                else if(Seviye>1 && value > _maksimumEnerji)
                {
                    _maksimumEnerji = value;
                }
                else
                {
                    throw new Exception("Karakterinizin enerji seviyesinde bir sorun var lütfen kontrol ediniz");
                }
            }
        }
        public int MevcutEnerji { get; set; }

    }
}
