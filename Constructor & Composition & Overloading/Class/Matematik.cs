using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor___Composition___Overloading.Class
{
    public class Matematik
    {
        public int topla(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public double topla(double sayi1, double sayi2,double sayi3)
        {
            double sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public int carp(int sayi1, int sayi2, int sayi3)
        {
            int sonuc = 1;
            sonuc = sayi1*sayi2;
            return sonuc;
        }
        public double carp(double sayi1, double sayi2)
        {
            double sonuc = 1;
            sonuc = sayi1 * sayi2;
            return sonuc;
        }
    }
}
