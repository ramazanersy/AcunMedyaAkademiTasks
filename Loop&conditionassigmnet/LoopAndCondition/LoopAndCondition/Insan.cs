using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAndCondition
{
    public class Insan
    {
         public int yasHesapla(int dogumyili)
        {
            int sonuc = 0;
            string durum = "";
            sonuc = DateTime.Now.Year - dogumyili;
            if (sonuc > 0 && sonuc <= 18)
            {
                durum = "Küçüksünüz";
            }
            else if (sonuc > 18 && sonuc <= 35)
            {
                durum = "Gençsiniz";
            }
            else if (sonuc > 35 && sonuc <= 55)
            {
                durum = "Yetişkinsiniz";
            }
            else if (sonuc > 55 && sonuc <= 75)
            {
                durum = "Yaşlısınız";
            }
            else if (sonuc > 75 && sonuc <= 99)
            {
                durum = "Çok yaşlısınız";
            }
            else
            {
                durum = "Ya Hiç doğmadınız ya da çoktan öldünüz";
            }
            Console.WriteLine(durum);
            return sonuc;
           

            
        }
    }
}
