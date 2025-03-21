using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Dongusu

            //döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21  


            //For(x;y;z)
            //x: başlangıç değeri
            //y: bitiş
            //z: artış-azalış değeri

            //int i;
            //for ( i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i < 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz miktarı giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++) 
            //{
            //    Console.WriteLine("GELME ISTEMEM");
            //}
            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //} 
            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++) 
            //{
            //    if (i % 2 == 0) 
            //    {
            //        totalValue+= i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0) 
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bakteri = 1;
            //for (int i = 1; i <=24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i+ ".Saat Sonunda: "+bakteri);
            //}




            #endregion

            #region While Dongusu
            //While (Şart)
            //{
            //işlemler
            //}

            //int i = 1;

            //while (i <= 10) 
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10) 
            //{
            //    if (i % 3 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10) 
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Ornek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplayan kodu yazınız.
            //456 = 15

            //Console.Write("Sayıyı Giriniz.");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10; //10'a böler birler basamağı kalır
            //tens = (number % 100) / 10; //100'ü bölebildiği kalar böler
            //hundreds = number / 100; //100'ü bölebildiği kadar böler kalan sayı örnek: 425 ise 4.25 olur int olduğu için 4 yazar
            //Console.WriteLine(ones + "-"+ tens + "-"+ hundreds);
            //sum = ones+tens+hundreds;
            //Console.WriteLine(sum);

            #endregion
            
        }
    }
}
