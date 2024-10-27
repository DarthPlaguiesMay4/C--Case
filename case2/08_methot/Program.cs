using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _08_methot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region metot

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali yldiz");
            //    Console.WriteLine("fadimeyldiz");
            //    Console.WriteLine("Fatma yldiz");
            //}
            //CustomerList();


            #endregion
            #region toplama metot

            //void Sum(){
            //    int x = 1;
            //    int y =3;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion
            #region Geriye Deger Dondurmeyen  parametreli metot

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}
            //WriteMethod("Mehmet");

            //void CustomerCard(string name ,string surName)
            //{
            //    Console.WriteLine(" Musteri : "+ name + " " +surName );
            //}
            //CustomerCard("Mehmet ", "Yildiz");
            //CustomerCard("Veli ", "Galip ");


            #endregion

            #region Geriye dondurmeyen  string parametreli metot

            //void sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(4,1,2);

            #endregion

            #region geriye deger donduren metot
            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "fena";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCard());
            #endregion
            #region geriye deger dondurden paramnetreli metotlar
            string Country(string countryName, string capital, string flagColor)
            {
                string cardInfo = "Ulke:  " + countryName + "baskent" + capital;
                return cardInfo;
            }
            string x, y, z;
            Console.WriteLine("ulke adini giriniz");
            x = Console.ReadLine();
            Console.WriteLine("ulke baskenti giriniz");
            y = Console.ReadLine();
            Console.WriteLine("ulbayrakl rengi giriniz");
            z = Console.ReadLine();
            Country(x, y, z);

            #endregion
            #region geriye deger donduren int parametereli
            //int sum(int number1 ,int number2 )
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(sum(67, 389));
            //Console.WriteLine(sum(6347, 38433));
            //Console.WriteLine(sum(6227, 389345));
            //Console.WriteLine(sum(6, 9));

            #endregion
            #region
            //string Examresult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam3 + exam2) / 3;
            //    if (result >= 50)
            //    {
            //        return student + "ogrenci sinavi gecti" + "ortalama" + result;
            //    }
            //    else
            //    {
            //        return student + "ogrenci sinavi gecemedi" + "ortalama" + result;
            //    }
            //}
            //    Console.WriteLine(Examresult("ali", 37, 48, 17));


                
            //    Console.Read();
            }
        #endregion
    }
}

