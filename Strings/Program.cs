using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Orçun";
            var result=sentence.Length;
            var result2=sentence.Clone();
            sentence = "My name is Orçun";

            bool result3=sentence.EndsWith("n"); // cümle sonu
            bool result4=sentence.StartsWith("ç");// cümle başı

            var result5 = sentence.IndexOf("name"); // cümlede var mı diye bakar yoksa -1 döndürür
            var result6 = sentence.IndexOf(" "); // metinde yer alan keliemelere bakar ilk bulduğunu indexini yazar
            var result7 = sentence.LastIndexOf(" "); // aramaya sondan başlar
            var result8 = sentence.Insert(0,"Hello "); // cümleye girilen indexe göre yazılan kelime yazılır
            var result9=sentence.Substring(3); // metni parçalamak için kullanılır
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" "," ");
            var result13 = sentence.Remove(2);


            Console.WriteLine(result13);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            Console.WriteLine(string.Format("{0} {1} ", city, city2));
        }
    }
}
