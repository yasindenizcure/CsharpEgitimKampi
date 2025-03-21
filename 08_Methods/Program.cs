using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Methods

            //() parantez varsa metotlar. C#'ta sol tarafında mor renkli küp alırlar.
            // Geriye değer döndürmeyen metotlar.
            // Customer--> Listele, ekle, sil, güncelle
            // void 

            //void customerList() 
            //{
            //    Console.WriteLine("yasincure_");
            //    Console.WriteLine("umutmrfof");
            //    Console.WriteLine("cevher4rslan");
            //    Console.WriteLine("kcmnemin");
            //    Console.WriteLine("avciahmmet");
            //}

            //customerList();
            //customerList();
            //customerList();

            //void sum() 
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreleri Metotlar

            //void WriteMethod(string customerName) 
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Yasin Cüre");

            //void CustomerCard(string name, string surname) 
            //{
            //    Console.WriteLine("Müşteri: "+name+" "+surname);
            //}
            //CustomerCard("Deniz", "Cüre");
            //CustomerCard("Onur", "Cüre");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreleri Metotlar

            //void Sum(int number1, int number2, int number3) 
            //{
            //    int result= number1 + number2+number3;
            //    Console.WriteLine(result);
            //}
            //Sum(3,4,5);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName() 
            //{
            //    return "cürecüre";
            //}

            //CustomerName();

            //string StudentCard() 
            //{
            //    string name = "Ender";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor) 
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2) 
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(22, 78));
            //Console.WriteLine(Sum(36, 31));
            //Console.WriteLine(Sum(25, 24));
            #endregion

            #region Örnek Uygulama
            //string ExamResult (string student, int exam1, int exam2, int exam3) 
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci dersi başarıyla geçti." + "Ortalama: " +result ;
            //    }
            //    else 
            //    {
            //        return student + " isimli öğrenci dersi geçemedi." + "Ortalama: " + result;
            //    }
                

            //}
            //Console.WriteLine(ExamResult("Yasin",80,41,50));
            //Console.WriteLine(ExamResult("Ayşenur",70,65,85));
            //Console.WriteLine(ExamResult("Mehmet",22,31,15));
             
            #endregion
            Console.Read();
        }
    }
}
