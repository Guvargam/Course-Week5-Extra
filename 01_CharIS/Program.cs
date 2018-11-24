using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CharIS
{
    class Program
    {
        static void Main(string[] args)
        {

            string metin = "mErhaba";
           // Console.WriteLine( metin[1]);
            bool yanıt = char.IsNumber(metin[0]);      
            // metot parametre olarak char alır. geriye bool döndürür
            char birincikarakter = metin[0];
            sor:
            Console.Write("Karakter Gir : ");
            char karakter = char.Parse(Console.ReadLine());
            if (char.IsLetter(karakter))  // birincikarakter char ı bir harf mi ? 
            {
                Console.WriteLine(" Karakter bir harf" );
            }
             if (char.IsPunctuation(karakter)) // noktalama işaret,
            {
                Console.WriteLine(" Karakter. bir noktalama işareti");
            }
             if (char.IsSeparator(karakter))
            {
                Console.WriteLine("karakter bir Seperator");
            }

            if (char.IsSymbol(karakter))
            {
                Console.WriteLine("bir sembol");
            }
            if (char.IsWhiteSpace(karakter))
            {
                Console.WriteLine("white space");
            }

            if (char.IsDigit(karakter))
            {
                Console.WriteLine("karakter bir DİGİT");
            }
            if (char.IsNumber(karakter))
            {
                Console.WriteLine("karakter bir rakam");
            }
            Console.WriteLine("-------");
            goto sor;




        }
    }
}
