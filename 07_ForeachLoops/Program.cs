using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach (1;2;3;4)
            //1: Değişken Türü
            //2: Değişken Adı
            //3: In komutu
            //4: Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "varşona", "ankara", "londra" };

            //foreach (string city in cities) 
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 22, 4, 96, 45, 356, 789 };
            //foreach (int i in numbers) 
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 1, 22, 4, 96, 45, 353, 789 };

            //foreach (int number in numbers) 
            //{
            //    if(number%2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 1, 22, 4, 96, 45, 356, 789 };

            //int total = 0;

            //foreach (int i in numbers) 
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9
            //};

            //foreach (int number in numbers) 
            //{
            //    Console.WriteLine(number);
            //}

            //string Yasin = "Merhaba";

            //foreach (char c in Yasin) 
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması
           // Console.Write("***** Yasin Cüre Sınav Uygulaması *****");
           // Console.WriteLine();
           // Console.WriteLine();
           // Console.WriteLine();
           // Console.WriteLine();

           // //sınıftaki öğrenci sayısı kullanıcıdan alma
           // Console.WriteLine("--------------------------------");
           // Console.Write("Sınıfınızda kaç öğrenci var: "); 
           // int studentCount = int.Parse(Console.ReadLine());
           // Console.WriteLine("--------------------------------");

           ////öğrenci isimlerini ve not ortalamalarını saklayacak diziler
           // string[] studentName = new string[studentCount];
           // double[] studentExamAvg = new double[studentCount];

           // for (int i = 0; i < studentCount; i++) 
           // {
            //    Console.Write($"{i+1}.öğrencinin ismini giriniz: ");
            //    studentName[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    // her öğrenci için 3 sınav notu

            //    for (int j = 0; j < 3; j++) 
            //    {
            //        Console.Write($"{studentName[i]} isimli öğrencinin {j + 1} sınav notunu giriniz: ");

            //        double value = double.Parse(Console.ReadLine());

            //        totalExamResult += value; //notları topluyoruz.
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            ////Sınav ortalamaları 

            //for (int i = 0; i < studentCount; i++) 
            //{
            //    Console.WriteLine("--------------------------------");

            //    Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    //öğrencinin ortalaması ve geçip-kalma durumları
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı.");
            //    }

            //    Console.WriteLine("--------------------------------");
            }
            #endregion
         
        }
    }

