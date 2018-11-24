using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {


            /// C # ta 4 tane döngü kelimesi var
            /// 1-- WHILE DONGUSU


            /*
            // kısayolu : while yazıp 2 tab

            while (şart )
            {// dongu baslangıc


                // komutlar

            } // dongu sonu



            // parantez içinde verilen şart sağlandıgı muddetce dongu çalışır
            // -->  şart sağlanıyorsa donguye girer

            // isim ahmet girilene kadar isim iste ?


            string isim ="";
            while (isim!="ahmet")               // bak 
            {
                Console.Write("isim gir");      //yap 
                isim = Console.ReadLine();
            }

            // daha cok sayac kullanılmayan durumlarda tercşh edilebilir
            // 2-- DO WHILE dongusu
            do   // yap 
            {
                //komutlar

            } while (şart);         //bak

            // dongunun en az bir defa  calısması gereken durumlarda ytercih edilir
            // cunku şart sondadır

            do
            {
                string ad = Console.ReadLine();
            } while (ad!="ali");

            // Kullanıya klavyeden bir tuş girlmesine iste tus Escape değilse tekrar et


            ConsoleKeyInfo tus;
            do
            {
                Console.Write("Tus gir? ");
                tus = Console.ReadKey();

            } while (tus.Key!=ConsoleKey.Escape);

            // do içinde tanımlanan değişken while da görünmez !
            // scope içinde tanımlanana değişkenlerin ömrü scope tamamlandıgında sora erer
            int sayi;
            do
            {
                sayi=5;
            }
            while (sayi==5);


            // sonsuz döngü
            while (true)
            {

            }


            // 3-- FOR DONGUSU 
            // kere , adet, defa  vb. oldugu durumlarda  veya ardısık ıslemlerde daha cok kullanılır

            //kısayolu for 2  tab

            for (int i = 0; i < length; i++)// (değişkentanımla ; şart; değişkenartıs, azaloıs mıktarı )
            {

            }
            // not eüer şart saglanıyorsa donguye gırer saglandıgı muddetce tekrar eder

            // 10 defa ekrana "merhaba " yaz

            for (int sayac = 0; sayac < 10; sayac++)
            {
                Console.WriteLine("merhaba");
            }

            int sayac1 = 0;
            while (sayac1<10)
            {
                Console.WriteLine("merhaba");
                sayac1++;
            }

            // 1 -10 arası sayıları  2ser  2 ser ekrana yaz

            for (int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }

            /// 4- FOREACH DONGUSU        
            //dizi liste vb koleksyion durumlarındak kullanılan  döngü
            // otomotik olarak dizinin eleman sayısına gore dondurur
            */
            string[] isimler = { "ali", "ahmet", "veli" };

            foreach (var ad in isimler)
            {
                Console.WriteLine(ad);
            }
             //not: foreach te index lerle ıslem yapılamaz
            for (int i = 1; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }



       
        }
    }
}
