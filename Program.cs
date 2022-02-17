using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Fatmagül";
            ogrenci.Soyisim="Gencel";
            ogrenci.Sinif=11;
            ogrenci.No= 05;

            ogrenci.OgrenciBilgileriGetir();

            ogrenci.sinifAtlat();
            ogrenci.OgrenciBilgileriGetir();
            ogrenci.sinifDusur();
            ogrenci.OgrenciBilgileriGetir();

            Ogrenci ogrenci2 = new Ogrenci("Gökhan","Çam",5,1);
            ogrenci2.sinifDusur();
            ogrenci2.sinifDusur();
            ogrenci2.sinifDusur();
            ogrenci2.OgrenciBilgileriGetir();

            

            
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int no;
        private int sinif;

        public string Isim 
        { get => isim; set => isim = value; 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sinif { 
            get => sinif; 
            set 
            {
                if(value <=1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir");
                    sinif =1;
                }
                else
                sinif = value;

            }
            }

        public Ogrenci(string isim, string soyisim, int no, int sinif)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.no = no;
            this.sinif = sinif;
        }

        public Ogrenci()
        {

        }

        public void OgrenciBilgileriGetir()
        {
            Console.WriteLine("********* Öğrenci Bilgileri********");
            Console.WriteLine("Öğrenci adı: {0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı: {0}",this.Soyisim);
            Console.WriteLine("Öğrenci No: {0}",this.No);
            Console.WriteLine("Öğrenci Sınıfı: {0}",this.Sinif);


        }

        public void sinifAtlat()
        {
            this.Sinif = Sinif+1;
        }

        public void sinifDusur()
        {
            this.Sinif = Sinif-1;
        }

    }
}