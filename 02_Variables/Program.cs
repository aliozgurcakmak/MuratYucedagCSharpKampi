﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler


            //double number;

            //number = 4.85;
            //Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45.00;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyat: " + applePrice + "TL");
            //Console.WriteLine("---- Portakal Birim Fiyat: " + orangePrice + "TL");
            //Console.WriteLine("---- Çilek Birim Fiyat: " + strawberryPrice + "TL");
            //Console.WriteLine("---- Patates Birim Fiyat: " + potatoPrice + "TL");
            //Console.WriteLine("---- Domates Birim Fiyat: " + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma     -   " + "Birim Fiyat: " + applePrice        + " " + "- Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal -   " + "Birim Fiyat: " + orangePrice       + " " + "- Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek    -   " + "Birim Fiyat: " + strawberryPrice   + " " + "- Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates  -   " + "Birim Fiyat: " + potatoPrice       + " " + "- Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates  -   " + "Birim Fiyat: " + tomatoPrice       + " " + "- Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(  "Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");



            #endregion

            #region Char Değişkenler

            // ABCDEFGH
            // DEF...
            // TOPLANTI SAAT 20:00'DE
            //'

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);



            #endregion

            #region Klavyeden Gelen Veri Girişleri String Değişkenler

            //Console.WriteLine("**** Turkish Airlines Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIDNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName= Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname= Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIDNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu TC No: " + passengerIDNumber + " - Yolcu Adı: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge );


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount*shoePrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + " TL");



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri


            //double exam1, exam2, exam3, result;

            //Console.Write("Birinci sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("İkinci sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Üçüncü sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.ReadKey();

        }
    }
}
