using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_vairables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("C# manavina hos geldiniz");
            //double applePrice, orangePrice, potatoPrice;
            //applePrice = 23.34;
            //orangePrice = 45.23;
            //potatoPrice = 12.34;
            //Console.WriteLine("-----Elma Birim Fiyati = " + applePrice + "Tl");
            //Console.WriteLine("-----portakal Birim Fiyati = " + orangePrice + "Tl");
            //Console.WriteLine("-----patates Birim Fiyati = " + potatoPrice + "Tl");
            //double appleGram, orangeGram, potatoGram;
            //appleGram = 1.234;
            //orangeGram = 2.650;
            //potatoGram = 7.50;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;


            //Console.WriteLine("alinan urun elma : ELma - " + "Birim Fiyati : " + applePrice + "-Gramaj:" + appleGram
            //    + " - toplam tutar :" + appleTotalPrice);
            //Console.WriteLine("alinan urun portakal : ELma - " + "Birim Fiyati : " + orangePrice + "-Gramaj:" + orangeGram
            //    + " - toplam tutar :" + orangeTotalPrice);



            #region
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region yolcu ucak
            //Console.WriteLine("****** Csharp HAva yollari ****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adi:");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu soyadi :");
            //passengerSurname = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("----------------");
            //Console.WriteLine("Yolcu: " + passengerName +" "+ passengerSurname);

            //Console.Read();
            #endregion

            #region
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 2000;
            //chairPrice = 3000;
            //tvPrice = 4000;
            //int shorCount, computerCount, chairCount, tvCount;
            //Console.WriteLine("lutfen kacayakkabi adet aldiginizi yaziniz");
            //shorCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("lutfen kac bilgisayar adet aldiginizi yaziniz");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("lutfen kacayakoltuk adet aldiginizi  yaziniz");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("lutfen kac televizyon adet aldiginizi  yaziniz");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoePrice * shorCount + computerPrice * computerPrice + chairPrice * chairPrice
            //    + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam odemniz :" + totalPrice +"TLdir");


            #endregion
            #region klavyeden cikan tam sayi
            double exam1 , exam2, exam3,result;
            Console.WriteLine("lutfen1. sinav notunu giriniz : ");
            exam1 = double.Parse(Console.ReadLine());
            Console.WriteLine("lutfen2. sinav notunu giriniz : ");
            exam2 = double.Parse(Console.ReadLine());
            Console.WriteLine("lutfen3. sinav notunu giriniz : ");
            exam3 = double.Parse(Console.ReadLine());
            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("ortalama notunuz: " + result);

            #endregion
            #region Klaavyeden kaarkter girisi
            //char gender;
            //Console.WriteLine("lutfen cinsiyetinizi girinuiz");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("sectihiniz cinsiyer: "+ gender);
            //#endregion

            Console.Read();


        }
    }
}
