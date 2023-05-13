using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uçakbiletsatışprogramı;

namespace UcakBiletSatisProgrami
    {
    internal class uygulama
    {
        public static string musteriAdSoyad;
        static void Main(string[] args)
        {
            Ucak ucak = new Ucak();
            ucak.Model = "Airbus A330";
            ucak.Marka = "Pegasus";
            ucak.SeriNo = "ABC123";
            ucak.KoltukKapasitesi = 400;


            Musteri musteri = new Musteri();

            Console.WriteLine("Yolcunun adı soyadı?");
            musteri.AdSoyad = (Console.ReadLine());

            Console.WriteLine("Yolcunun cinsiyeti?");
            musteri.Cinsiyet = (Console.ReadLine());

            Console.WriteLine("Yolcunun Telefon Numarası?");
            musteri.TelefonNO = (Console.ReadLine());

            Console.WriteLine("Yolcunun Yaşı?");
            musteri.Yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Engelli mi? (Evet/Hayır): ");
            bool engelli = (Console.ReadLine().ToUpper() == "Evet");

            Console.Write("Yaşlı mı? (Evet/Hayır): ");
            bool yasli = (Console.ReadLine().ToUpper() == "Evet");




            Lokasyon lokasyon = new Lokasyon();

            Console.WriteLine("Lokasyon bilgilerini giriniz:");

            Console.Write("Ülke: ");
            string ulke = Console.ReadLine();

            Console.Write("Şehir: ");
            string sehir = Console.ReadLine();

            Console.Write("Havaalanı: ");
            string havaalani = Console.ReadLine();

            Console.WriteLine("Lokasyonun aktif/pasif durumunu giriniz: ");
            bool aktifPasif = Console.ReadLine() == "aktif";




            Rezervasyon rezervasyon = new Rezervasyon();

            rezervasyon.AdSoyad = musteri.AdSoyad;
            rezervasyon.Ucak = ucak;
            rezervasyon.KalkisYeri = new Lokasyon();


            Console.WriteLine("Varış yerinin bilgilerini giriniz:");
            Console.Write("Ülke: ");
            ulke = Console.ReadLine();

            Console.Write("Şehir: ");
            sehir = Console.ReadLine();

            Console.Write("Havaalanı: ");
            havaalani = Console.ReadLine();

            Console.WriteLine("Lokasyonun aktif/pasif durumunu giriniz: ");
            aktifPasif = Console.ReadLine() == "aktif";

            rezervasyon.VarisYeri = new Lokasyon();

            Console.WriteLine("Uçuşun kalkış tarihini giriniz GG.AA.YYYY:  ");
            DateTime kalkisTarihi = Convert.ToDateTime(Console.ReadLine());
            rezervasyon.KalkisTarihi = kalkisTarihi;

            Console.WriteLine("Kaç kişi için rezervasyon yapmak istiyorsunuz?");
            int kisiSayisi = Convert.ToInt32(Console.ReadLine());
            rezervasyon.KisiSayisi = kisiSayisi;

            Console.WriteLine("Rezervasyon onaylansın mı? (Evet/Hayır)");
            bool onaylandiMi = Console.ReadLine().ToUpper() == "Evet";
            rezervasyon.OnaylandiMi = onaylandiMi;

            Console.WriteLine("Rezervasyon tamamlandı!");
         

            Console.WriteLine("Rezervasyon Bilgileri:");
            Console.WriteLine("Uçak: " + rezervasyon.Ucak.Marka + " " + rezervasyon.Ucak.Model + " (" + rezervasyon.Ucak.SeriNo + ")");
            Console.WriteLine("Kalkış Yeri: " + rezervasyon.KalkisYeri.Ulke + ", " + rezervasyon.KalkisYeri.Sehir + " - " + rezervasyon.KalkisYeri.Havaalani);
            Console.WriteLine("Varış Yeri: " + rezervasyon.VarisYeri.Ulke + ", " + rezervasyon.VarisYeri.Sehir + " - " + rezervasyon.VarisYeri.Havaalani);
            Console.WriteLine("Kalkış Tarihi: " + rezervasyon.KalkisTarihi.ToShortDateString());
            Console.WriteLine("Kişi Sayısı: " + rezervasyon.KisiSayisi);
        }
    }




































        }
