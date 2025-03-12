using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LoopAndCondition.InsanVeArabaYasi
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

            //SWITCH CASE İLE NASIL YAPARDIK ?
            //switch-case yapısında doğrudan aralıklarla işlem yapamayız, ancak C# 7.0 ve sonrası için "pattern matching" (desen eşleme) ile bunu gerçekleştirebiliriz.
            //C#’ta switch-case yapısı normalde belirli sabit değerlere göre çalışır. Ancak bir sayının belirli bir aralıkta olup olmadığını kontrol etmek için C# 7.0 ile gelen pattern matching (desen eşleme) özelliğini kullanabiliriz.

            //Bunun için switch-case içinde when koşulu kullanılır.when, case bloğunda belirli bir aralık sağlandığında çalışmasını sağlar.Örneğin, araba yaşı 0 ile 10 arasındaysa bir mesaj, 10 ile 20 arasındaysa başka bir mesaj döndürmek için case int n when (n >= 0 && n < 10):
            //  gibi bir ifade kullanabiliriz.

            //Alternatif olarak, C# 8.0 ve sonrasında switch expression kullanarak kodu daha sade ve okunaklı hale getirebiliriz. Switch expression, => operatörü ile çalışır ve doğrudan belirli bir değeri döndürür. Örneğin, yas switch { >= 0 and < 10 => "Arabanız yeni", ... } şeklinde bir yapı ile if-else kullanmadan hızlıca karar verebiliriz.

            //Bu yöntemler sayesinde switch-case, sadece sabit değerlere bağlı kalmak yerine, koşullu ifadelerle esnek hale getirilmiş olur ve kodun okunabilirliği artırılır.Özellikle switch expression, modern C# sürümlerinde performans açısından daha iyi sonuçlar verebilir.









        }
    }
}
