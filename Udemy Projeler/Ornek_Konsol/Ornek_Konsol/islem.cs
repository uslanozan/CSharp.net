using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Konsol
{
    internal class islem
    {
        public int topla(int sayi1,int sayi2)
        {
            int sayi3=sayi1+ sayi2;
            Console.WriteLine("Sonuç: " + sayi3);   
            return sayi3;
        }

        public int kare(int sayi1)
        {
            int sonuc = sayi1 * sayi1;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;
        }
    }
}
