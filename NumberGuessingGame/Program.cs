// See https://aka.ms/new-console-template for more information
namespace NumberGuessingGame;

class Program
{
    static void Main(string[] args)
    {
        // Random sınıfını kullanarak 1 ile 10 arasında rastgele bir sayı üretin.

        int randomNumber = 0; // 1 ile 10 arasında rastgele bir sayı üretmek için kullanılacak.
        int guessNumber = 0;
        int guessCount = 0;

        Console.WriteLine("Bilgisayar 1 ile 10 arasında bir sayı tuttu. Tahmin et bakalım!");

        while (guessNumber != randomNumber) // Bu döngü kullanıcı doğru tahmin yapana kadar devam eder.
        {
            guessNumber = Convert.ToInt32(Console.ReadLine()); // Hesap makinesi ödevinde öğrendiğimiz gibi kullanıcıdan tahmin alınır.
                                                               // İlk bu ödevden başlamışsanız hesap makinesinde zorlanmazsınız :)
            guessCount++;
            // if-else yapısı kullanarak kullanıcının tahminini kontrol edin ve büyük/küçük olduğunu belirtin.
        }
        Console.WriteLine($"Tebrikler! {guessCount}. tahminde doğru sayıyı buldunuz.");
    }
}