using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            int sayi1, sayi2, sonuç;
            char islem;
            Console.WriteLine("Adınızı Giriniz: ");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz: ");
            soyad = Console.ReadLine();
            DateTime dt = DateTime.Now;
            Console.WriteLine("************Hesap Makinesi Uygulamasına Hoşgeldiniz*************");
            Console.WriteLine("*********BİLGİLERİNİZ*********");
            Console.WriteLine(ad + " " + soyad + " " + "Erişim Tarihiniz" + dt);
            Console.WriteLine("1.Sayıyı Giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*************İşlem Seçiniz*************");
            Console.WriteLine("Toplama: T" + "Çıkarma: Ç" + "Çarpma: X" + "Bölme: B" + "Mod: M");
            Console.WriteLine("İşlem Seçiniz: ");
            islem = Convert.ToChar(Console.ReadLine());
            switch (islem)
            {
                case 'T':
                    sonuç = sayi1 + sayi2;
                    Console.WriteLine("Hesap Sonucu: " + sonuç);
                    break;
                case 'Ç':
                    sonuç = sayi1 - sayi2;
                    Console.WriteLine("Hesap Sonucu: " + sonuç);
                    break;
                case 'X':
                    sonuç = sayi1 * sayi2;
                    Console.WriteLine("Hesap Sonucu: " + sonuç);
                    break;
                case 'B':
                    sonuç = sayi1 / sayi2;
                    Console.WriteLine("Hesap Sonucu: " + sonuç);
                    break;
                case 'M':
                    sonuç = sayi1 % sayi2;
                    Console.WriteLine("Hesap Sonucu: " + sonuç);
                    break;
                default:
                    Console.WriteLine("Yanlış İşlem");
                    break;

            }


        }
    }
}
