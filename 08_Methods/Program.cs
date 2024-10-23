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

            // Bir yapıyı metot yapmak için () gereklidir.
            // 1- Geriye değer döndürmeyen metotlar.
            // Customer-Listele, Ekle, Sil, Güncelle
            // Değer görmek için tekrar çağırım gerekir.
            // Void metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}            

            //Sum();




            #endregion

            #region Methods With String Parameters That Do Not Return Backward Value

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);


            //}

            //WriteMethod("Mehmet Yıldırım");

            //void customerCard(string name, string surname) 
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //customerCard("Mehmet", "Yıldız");
            //customerCard("Ayşegül", "Kaya");


            #endregion

            #region Methods With Integer Parameters That Do Not Return Backward Value

            //void Sum(int number1, int number2, int number3)

            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}

            //Sum(4,5,6);

            #endregion

            #region Methods That Do Return Backward Value

            //string customerName()
            //{
            //    return "Buse Yıldız";

            //}

            //customerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;

            //}

            //Con/*sole.WriteLine(StudentCard());   */

            #endregion

            #region  Methods with String Parameters That Do Return Backward Value

            //    string CountryCard(string CountryName, string Capital, string FlagColor)
            //{
            //    string cardInfo = "Ülke: " + CountryName + " - Başkent: " + Capital + " - Bayrak Rengi: " + FlagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();
            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak Rengi Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Ukrayna", "Kiev", "Kırmızı-Beyaz"));


            #endregion

            #region Methods with Int Parameters That Do Return Backward Value

            //int Sum(int number1, int number2)
            //{
            //    int result = number1+ number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));

            #endregion

            #region Sample Application

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti. " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi. " + "Ortalama: " + result;

            //    }

            //}
            //Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

            #endregion

            Console.Read();
        }
    }
}
