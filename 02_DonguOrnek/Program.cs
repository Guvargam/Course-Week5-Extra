using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DonguOrnek
{
    class Program
    {
        static void Main(string[] args)
        {


            // girilen sayıdan geriye dogru 3 er 3 er yazdır

            Console.WriteLine("Sayı Girin : ");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = sayi; i >= 0; i -= 3)
            {
                Console.WriteLine(i);
            }
            // Rastgele üretilen sayıya kadar olan sayıları ekrana yaz 

            Random rnd = new Random();

            int sinir = rnd.Next(20);
            for (int i = 0; i < sinir; i++)
            {
                Console.WriteLine(i);
            }

            // rastgele 5 adet sayı üret ? 


            int uretilen = rnd.Next(50);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(uretilen);
            }


            // NOT: sayac yukarda artmak zorunda değil !

            for (int i = 0; i < 10; )
            {
                i++;
            }


            // rastgele 5 adet CİFT sayı üret

         
            for (int i = 0; i < 5; )
            {
                uretilen = rnd.Next(50);
                if (uretilen % 2 == 0)
                {
                    Console.WriteLine(uretilen);
                    i++;
                }
            }

            // NOT : sorgu birden fazla olabilir


            int girilensayi = 5;

            for (int i = 0; i < 5 && girilensayi!=10; i++)
            {
                Console.WriteLine("sayı " );
                girilensayi = int.Parse(Console.ReadLine());
            }

            for (int i = 0, y=0; i < 5 && y>-15; i++,y-=3)
            {


            }


            // NOT: donguler iç içe kullanılabılır

            for (int i = 0; i < 10; i++)
            {
                for (int j   = 0; j < 20; j++)
                {
                    Console.WriteLine(i);
                }
            }
            while (true)
            {
                for (int i = 0; i < length; i++)
                {

                   
                }
            }

            for (int i = 0; i < length; i++)
            {
                while (true)
                {

                }
            }


            Console.ReadKey();

        }
    }
}
