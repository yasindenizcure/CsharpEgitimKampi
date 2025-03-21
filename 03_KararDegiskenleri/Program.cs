using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KararDegiskenleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz.");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru.");
            //}
            //else 
            //{
            //    Console.WriteLine("Şifre Yanlış.");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler doğru.");
            //}
            //else 
            //{
            //    Console.Write("Hatalı bilgi.");
            //}
            //Console.Read();

            //int sayi;
            //Console.Write("Sayıyı Giriniz: ");
            //sayi = int.Parse(Console.ReadLine());
            //if (sayi == 5)
            //{
            //    Console.WriteLine("Sayı Doğru.");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı hatalı.");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların Ortalaması: " + average);


            //if (average > 0 & average <= 50) 
            //{
            //    result = "Sonuç başarısız.";
            //}
            //if (average > 50 & average <= 70) 
            //{
            //    result = "Sonuç ortalama.";
            //}
            //if (average > 70 & average <= 84) 
            //{
            //    result = "Sonuç iyi.";
            //}
            //if (average > 84) 
            //{
            //    result = "Sonuç çok iyi.";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehri giriniz: ");
            //city = Console.ReadLine();

            //if (city == "amasya" | city == "samsun" | city == "trabzon" | city == "rize")
            //{
            //    Console.WriteLine("Karadenizlisiniz bravo uşağum!");
            //}
            //else 
            //{
            //    Console.WriteLine("Hayatınızın hatası, karadenizli değilsiniz.");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez.");
            //}
            //else 
            //{
            //    Console.Write("Sisteme Hoşgeldiniz.");
            //}
            #endregion

            #region Mod islemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz.");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz.");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("Birinci sayının 2. sayıya bölümünden kalan: " +result);

            //Console.Write("Lütfen Sayıyı Giriniz.");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir.");
            //}
            //else 
            //{
            //    Console.Write("Sayı Tektir.");
            //}
            #endregion

            #region Char Degiskenler ile Karar Yapilari
            //char team;
            //Console.Write("Lütfen tuttuğunuz takımı giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G') 
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F') 
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //Console.Read();
            #endregion

            #region Ornek Proje Uygulamasi
            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();
            //string menuItem;
            //Console.Write("Lütfen detayını görmek istediğiniz menü seçin: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1") 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Tavuk Sote");
            //    Console.WriteLine("3- Kuru Fasulye");
            //    Console.WriteLine("4- Patlıcan Musakka");
            //    Console.WriteLine("5- Köfte");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Domates Çorbası");
            //    Console.WriteLine("3- Yayla Çorbası");
            //    Console.WriteLine("4- Kelle Paça Çorbası");
            //    Console.WriteLine("5- Beyran Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Margarita Pizza");
            //    Console.WriteLine("2- Karışık Pizza");
            //    Console.WriteLine("3- Mantarlı Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar----");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----İçecekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Soda");
            //    Console.WriteLine("4- Şalgam");
            //    Console.WriteLine("5- Su");
            //    Console.WriteLine();
            //    Console.WriteLine("-----İçecekler-----");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Trileçe");
            //    Console.WriteLine("2- Katmer");
            //    Console.WriteLine("3- Künefe");
            //    Console.WriteLine("4- Sütlaç");
            //    Console.WriteLine("5- Baklava");
            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch-Case

            //Console.Write("Hangi Ay Girişi Yapınız. ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi"); break;    
            //}
            //Console.Read();
            #endregion

            #region Switch-Case Hesap_Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");

            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol) 
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " +result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //    default: Console.WriteLine("Hatalı Veri Girişi"); break;
            //}
            Console.Read();
            #endregion
        }
    }
}
