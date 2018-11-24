using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CumledekiKelimeleriSay
{
    class Program
    {
        static void Main(string[] args)
        {
            // girilen cumledeki kelimeleri sayan program
            // MERHABA DÜNYA
            // STRİNG içindeki char a erişme 
            //string[indexno]


            string cumle;
            Console.Write("Cümlenizi Girin : ");
            cumle = Console.ReadLine().Trim().ToLower();

            // butun harflere tek tek ulaş ? 
            int indexno = 0;
            int kelimesayaci = 0;
            int harfsayisi = 0;
        kontrolet:
            if (cumle[indexno] == ' ' && cumle[indexno + 1] != ' ')
            {
                kelimesayaci++;
            }
            else harfsayisi++;
            indexno++;
            if (indexno < cumle.Length) goto kontrolet;

            Console.WriteLine("Girilen Cümle {0} kelimelidir {1} harflidir", kelimesayaci + 1, harfsayisi);

            Console.ReadKey();







        }
    }
}
