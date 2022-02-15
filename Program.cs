using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isım = "Efe";
            ogrenci1.OgrenciNo = 1;
            ogrenci1.Sinifi = 1;
            ogrenci1.Alani = "Sayısal";

            ogrenci1.OgrenciBilgileriniYazdir();

            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniYazdir();

        }

        class Ogrenci
        {
            private string isim;
            private string alani;
            private int sinifi;
            private int ogrenciNo;

            public string Isım
            {
                get { return isim; } // 2. tanımlama ***> get => isim;
                set { isim = value; } // set => isim = value;
            }

            //Diğer tanımla yolu
            public int OgrenciNo { get => ogrenciNo;

                set 
                {
                    if (value > 0 && value <= 100)
                    {
                        this.ogrenciNo = value;
                    }
                    else
                    {
                        this.ogrenciNo = 1;
                        Console.WriteLine("Öğrenci No Yalnız 1-100 arasında olabilir.");
                    }
                }
            }

            public int Sinifi
            {
                get
                {
                    if (sinifi >= 1)
                    {
                        return sinifi;
                    }
                    else
                    {
                        Console.WriteLine("*** Sınıf 1'den küçük olamaz. ***");
                        return 1;
                    }
                }

                set => sinifi = value;
            }
        

            public string Alani 
            { 
                get 
                {
                    if (sinifi >= 10)
                    {
                        return alani;
                    }
                    else
                        return "*** Sınıfı 10 dan küçük olduğu için alanı henüz yoktur ***";
                }

                set { alani = value; }
            }

            public void SinifDusur()
            {
                this.Sinifi--;
            }


            public void OgrenciBilgileriniYazdir()
            {
                Console.WriteLine("****** Öğrenci Bilgileri ******");
                Console.WriteLine("Öğrenci Adı: {0}", this.Isım);
                Console.WriteLine("Öğrenci Numarası: {0}", this.OgrenciNo);
                Console.WriteLine("Öğrenci Sınıfı: {0}", this.Sinifi);
                Console.WriteLine("Öğrenci Alanı: {0}", this.Alani);

            }
        }
    }
}
