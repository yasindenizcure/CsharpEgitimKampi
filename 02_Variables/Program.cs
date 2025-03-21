using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Ne
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            #endregion
            #region Double Degiskenler
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("-----Çilek KG Fiyatı: " + strawberryPrice +" TL");
            //Console.WriteLine("-----Domates KG Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine("-----Elma KG Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("-----Patates KG Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("-----Portakal KG Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double orangeGram, strawberryGram, appleGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double appleTotalPrice = appleGram * applePrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice );
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine();
            //double shopTotalPrice = appleTotalPrice+orangeTotalPrice+potatoTotalPrice+tomatoTotalPrice+strawberryTotalPrice;

            //Console.WriteLine("Alınan toplam ürün fiyatı: "+shopTotalPrice+" TL");

            #endregion
            #region Char degiskenler
            //ABDCEFGH
            //DEF...
            //TOPLANTI SAAT 20.00'DE  
            // " '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);
            //Console.Read();

            #endregion
            #region klavyeden veri girisleri


            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC Kimlik: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //Console.WriteLine("TC Kimlik: " + passengerIdentityNumber + " " + "Yolcu Ad-Soyad: " + passengerName + " " + passengerSurname+ " "+ passengerDistrict + " / " + passengerCity + " " +passengerAge);


            //Console.Read();

            #endregion
            #region klavyeden tam sayi girisleri ve donusumler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız pc sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice+computerPrice*computerCount+chairPrice*chairCount+tvPrice*tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+totalPrice+" TL");
            //Console.Read();

            #endregion
            #region klavyeden ondalıklı sayi degiskenleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen birinci sınav notunu girin: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sınav notunu girin: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen üçüncü sınav notunu girin: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: "+result) ;
            //Console.Read();
            #endregion
            #region klavyeden char degiskenleri
            //char gender;
            //Console.Write("Lütfen cinsiyetinizi giriniz: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            Console.Read();
            #endregion
        }
    }
}
