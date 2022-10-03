using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_0.Models
{

    internal class Karakter : BaseEntity
    {

        //todo : Karakter , KarakterYaratikSpec'ten miras almalı
        public Karakter()
        {
            Seviye = 1;
            MaksimumCan = 100;
            MaksimumEnerji = 50;

            switch (Sinifi.Isim.ToLower())
            {
                case "savasci":
                    Guc = 3;
                    Dayaniklilik = 3;
                    Ceviklik = 2;
                    Irade = 1;
                    break;
                case "okcu":
                    Guc = 2;
                    Dayaniklilik = 2;
                    Ceviklik = 3;
                    Irade = 1;
                    break;
                case "buyucu":
                    Guc = 1;
                    Dayaniklilik = 1;
                    Irade = 3;
                    Ceviklik = 2;
                    break;
                case "sovalye":
                    Guc = 3;
                    Irade = 3;
                    Ceviklik = 1;
                    Dayaniklilik = 2;
                    break;
                case "ninja":
                    Guc = 2;
                    Irade = 2;
                    Ceviklik = 3;
                    Dayaniklilik = 2;
                    break;
            }

        }

        #region EncapsulationKodlari
        int _maksimumCan; //İlgili degerimiz Bir Encapsulation'a girecegi zaman field'inizi acıkca yazmalısınız...

        public int MaksimumCan
        {
            //get ve set metotlarınız Property'nin Ram'deki ilgili degişken veri getirmesi veya o degişkeni veri ataması icin kullanacagınız metotlar
            get
            {
                if (Seviye == 1 && _maksimumCan != 100)
                {
                    throw new Exception("Karakter 1. seviyede olmasına ragmen can puanın bir sıkıntı var");
                }

                return _maksimumCan;
            }
            set
            {
                if (Seviye == 1 && value == 100)
                {
                    _maksimumCan = value;
                }
                else if (Seviye > 1 && value > _maksimumCan)
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
                if (Seviye == 1 && value == 50)
                {
                    _maksimumEnerji = value;
                }
                else if (Seviye > 1 && value > _maksimumEnerji)
                {
                    _maksimumEnerji = value;
                }
                else
                {
                    throw new Exception("Karakterinizin enerji seviyesinde bir sorun var lütfen kontrol ediniz");
                }
            }
        }
        #endregion

        #region MevcutCanEnerji
        public int MevcutCan { get; set; } //Karakterin mevcut sürecteki canını bildirir
        public int MevcutEnerji { get; set; }
        #endregion


        #region NormalOzellikler
        public int Seviye { get; set; }

        public Sinif Sinifi { get; set; }
        #endregion




        //Stats
        public int Guc { get; set; }
        public int Ceviklik { get; set; }
        public int Irade { get; set; }
        public int Dayaniklilik { get; set; }



    }
}
