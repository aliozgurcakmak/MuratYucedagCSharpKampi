using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları
            ////Console.WriteLine("Hello World!");
            ////Console.Write("Hi!");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");


            #endregion


            #region String Değişkenler

            //String
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Özgür";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali Özgür";
            //customerSurname = "Çakmak";
            //customerPhone = "+90 534 883 68 34";
            //customerEmail = "aliozgurcakmakk@gmail.com";
            //district = "Şile";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Berkan";
            //customerSurname = "Gültekin";
            //customerPhone = "+90 544 883 90 29";
            //customerEmail = "berkan.gultekin@bilgi.edu.tr";
            //district = "Şişli";
            //city = "İstanbul";

            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");

            #endregion


            #region Integer Degiskenler

            int number = 24;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("----- Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("----- Kızartmalar: " + friesPrice + "TL");
            Console.WriteLine("----- Kola: " + cokePrice + "TL");
            Console.WriteLine("----- Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("----- Su: " + waterPrice + "TL");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("------------------------");
            Console.WriteLine("Hamburger Tutar: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutar: " + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutar: " + totalFriesPrice + "TL");
            Console.WriteLine("Kola Tutar: " + totalCokePrice + "TL");
            Console.WriteLine("Limonata Tutar: " + totalLemonadePrice + "TL");
            Console.WriteLine("Su Tutar: " + totalWaterPrice + "TL");
            Console.WriteLine();

            int totalPrice = totalWaterPrice + totalCokePrice + totalLemonadePrice + totalHamburgerPrice + totalFriesPrice + totalPizzaPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");



            #endregion

            Console.ReadKey();

        }
    }
}

