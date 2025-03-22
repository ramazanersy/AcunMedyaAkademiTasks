// See https://aka.ms/new-console-template for more information
using System;

class User
{
    private string adSoyad;
    private int yas;

    public string Email { get; set; }

    // Getter ve Setter metodları
    public string GetAdSoyad()
    {
        return adSoyad;
    }

    public void SetAdSoyad(string value)
    {
        adSoyad = value;
    }

    public int GetYas()
    {
        return yas;
    }

    public void SetYas(int value)
    {
        if (value > 0)
        {
            yas = value;
        }
        else
        {
            Console.WriteLine("Yaş geçerli bir değer olmalıdır!");
        }
    }

    // Bilgileri ekrana yazdıran metod
    public void BilgileriGoster()
    {
        Console.WriteLine($"Ad Soyad: {adSoyad}\nYaş: {yas}\nEmail: {Email}");
    }
}

class Program
{
    static void Main()
    {
        User kullanici = new User();
        kullanici.SetAdSoyad("Ahmet Yılmaz");
        kullanici.SetYas(25);
        kullanici.Email = "ahmet.yilmaz@example.com";

        kullanici.BilgileriGoster();
    }
}
