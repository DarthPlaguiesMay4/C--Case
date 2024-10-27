using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string customerName, customerSurName, customerPhone, wantFood;
            int hamburgerPrice = 30, cokePrice = 25, pizzaPrice = 50;

            Console.WriteLine("****restoran menu Fiyat *********");
            Console.WriteLine();
            Console.WriteLine("------ Hamburger:   " + hamburgerPrice + " TL");
            Console.WriteLine("------ pasta:   " + cokePrice + " TL");
            Console.WriteLine("------ pizza:   " + pizzaPrice + " TL");
            Console.WriteLine("Lutfen ne almak istediginizi giriniz");
            wantFood = Console.ReadLine();



            Console.WriteLine("adinizi giriniz");
            customerName = Console.ReadLine();
            Console.WriteLine("soyadinizi giriniz");
            customerSurName =Console.ReadLine();
            Console.WriteLine("telefon numaraniz giriniz");
            customerPhone = Console.ReadLine();
            Console.WriteLine("*************Rezervasyon Karti *************");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("musteri ;"+ customerName + "  " +customerSurName);
            Console.WriteLine("iltisim belgesi"+ customerPhone);
            Console.WriteLine(" almak istedigi urun " + wantFood) ;
            Console.WriteLine("----------------------------------------------");
            Console.Read();


        }
    }
}
