// See https://aka.ms/new-console-template for more information
/*
* İşlem numarası girildiğinde, o işlemi yapacak fonksiyonu çağıran bir program yazınız.
* 
* İşlemler:
* 1 - Toplama
* 2 - Çıkarma
* 3 - Çarpma
* 4 - Bölme
*/

namespace OcakOdev2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("İlk sayıyı giriniz: ");
        double a = 0; // Konsol ekranına girilen değeri "a" değişkenine atayan kodu yazınız.

        Console.Write("İkinci sayıyı giriniz: ");
        double b = 0; // Konsol ekranına girilen değeri "b" değişkenine atayan kodu yazınız.

        Console.Write("İşlem numarası giriniz: ");
        int islem = 0; // Konsol ekranına girilen değeri "islem" değişkenine atayan kodu yazınız.

        if (islem == 1)
        {
            Toplama(a, b);
        }

        /*
            int islem = ...;
            
            if (islem == 1)
            {
                Toplama();
            }
            else if (islem == 2)
            {
                Cikarma();
            }

            - Diğer 2 işlem için de aynı işlemi yapınız.
            - Geçersiz bir işlem numarası girildiğinde "Geçersiz işlem numarası" yazdırınız.        
        */

    }
    static void Toplama(double a, double b)
    {
        Console.WriteLine("Toplama işlemi yapılıyor...");
        double sonuc = a + b;
        Console.Write("İşlem sonucu: " + sonuc);
    }
    static void Cikarma()
    {
        Console.WriteLine("Çıkarma işlemi yapılıyor...");
    }
    static void Carpma()
    {
        Console.WriteLine("Çarpma işlemi yapılıyor...");
    }
    static void Bolme()
    {
        Console.WriteLine("Bölme işlemi yapılıyor...");
    }
}