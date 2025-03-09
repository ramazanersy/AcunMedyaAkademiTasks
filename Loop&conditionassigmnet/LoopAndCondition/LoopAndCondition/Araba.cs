using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAndCondition
{
    public class Araba
    {
        public int DurumNe(int uretimyili)
        {
            int sonuc = 0;
            string durum = "";
            sonuc = DateTime.Now.Year - uretimyili;
            if (sonuc > 0 && sonuc <= 10)
            {
                durum = "Arabanız yeni";
            }
            else if (sonuc > 10 && sonuc <= 20)
            {
                durum = "Servise götürmeniz gerekebilir";
            }
            else if (sonuc > 20 && sonuc <= 30)
            {
                durum = "Arabanız hurdaya çıkabilir";
            }
            else
            {
                durum = "Ya Hiç üretilmedi ya da trafikten men edildi.";
            }
            Console.WriteLine(durum);
            return sonuc;



        }
    }
}
