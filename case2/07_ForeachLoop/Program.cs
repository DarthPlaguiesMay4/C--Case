using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region sehirler
            //string[] cities = { "milano", "Roma ", "ankara " };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.Read();
            #endregion
            #region sayilar
            //int[] numbers = { 1, 2, 3 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.Read();

            #endregion
            #region
            //int[] numbers = { 134, 2345, 3234, 5433, 2346, 23467, 76567};
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //Console.Read();

            #endregion
            #region toplama
            //int[] numbers = { 134, 2345, 3234, 5433, 2346, 23467, 76567 };
            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);
            //
            #endregion
            #region list
            //List<int> numbers = new List<int>()
            //{
            //    1,2,34,56,7,8,9
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion
            #region Merhaba parcalama
            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion
            #region ornek sinav sistemi
            Console.WriteLine("*****C# egitim kapmiy ***");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("sinifinizda kac ogrenci vcar");
            int studenCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------");
            string[] studentNames = new string[studenCount];
            double[] studentExamavg = new double[studenCount];

            for (int i = 0; i < studenCount; i++)
            {
                Console.Write($"{i + 1}. ogrencinin simini gioriniz");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{studentNames[i]} isimli ogrenicinin {j + 1}. sinav notunu giriniz:");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                studentExamavg[i] = totalExamResult / 3;
            }
            for (int i = 0; i < studenCount; i++)
            {
                Console.WriteLine($"{studentNames} adli gorenicinin puan ortalamasi : {studentExamavg[i]}");
                if (studentExamavg[i] <= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adli gorenci dersten kaldi");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adli gorenci dersten gecti");
                }
                Console.WriteLine("-------------");
            }

            #endregion

            #region

            #endregion

            #region
            #endregion


            Console.Read();
        }
    }
}
