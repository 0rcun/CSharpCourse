using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(28, 43);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(number1,number2);
            //Console.WriteLine(result);
            //Console.WriteLine(result2);


            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4,5));
            Console.WriteLine(Add4(2,65,98,1,35,02,6878));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added !");
        }
        static int Add2(int number1=20, int number2=30) // eğer değer verilmezse number2 için bu değer kullanılır
        {
            var result = number1 + number2;
            return result;

        }  
        static int Add3(int number1, int number2) 
        {
            return  number1 + number2;
            

        }

        static int Multiply(int number1, int number2)
        { 
            return number1 * number2;
        } 
        static int Multiply(int number1, int number2, int number3)
        { 
            return number1 * number2*number3;
            // metotların aşırı yüklenmesi overlord
        }   

        static int Add4(params int[] numbers) // params ile metotumuza aynı tipte birden fazla değer gönderilebilir
        {
            return numbers.Sum(); 
        }
        



    }
}
