using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Add();
            var result = Add2(20);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);

            //Console.WriteLine(number1);// number1 20 dir çünkü biz bruda değer tiple çalışıyoruz
            //// değer tiplerde mevzu tamamen değişkenin deperiyle ilgilidir.

            //Console.WriteLine(result2);


            Console.WriteLine(Multiply(2, 8));
            Console.WriteLine(Multiply(2, 8, 4));

            Console.WriteLine(Add4(1, 8, 51, 4));
            Console.WriteLine(Add5(1, 5, 4, 3));
                
            Console.ReadLine();// konsol dursun diye



        }

        static void Add()// metod
        {

            Console.WriteLine("ADDED!!");

        }

        static int Add2(int sayi1, int sayi2 = 30)
        {
            var result = sayi1 + sayi2;

            return result;

        }

        static int Add3(ref int number1, int number2)// number1 değişsin istiyorsak ref kullanırız. ||out ref number1 e atama bekler out ise beklemz
        {

            number1 = 30;
            return number1 + number2;

        }

        static int Multiply(int number1, int number2)// metodun imzası
        {

            return number1 * number2;



        }
        static int Multiply(int number1, int number2, int number3)//aynı ismi kullanıp farklı parametreler kullanıyorsanız hiçbir sıkıntı olmaz 
                                                                  // method overloading metotların aşırı yüklenmesi diyoruz
        {

            return number1 * number2 * number3;

        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();


        }
        static int Add5(int number1, params int[] numbers)// number1 consoleWriteLine da Console.WriteLine(Add5(1, 5, 4, 3));de 1 tekabul ediyor sonucumuz 12 çıkıyor
        {
            return numbers.Sum();
        }
    }
}