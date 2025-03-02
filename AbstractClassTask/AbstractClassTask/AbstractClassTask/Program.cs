// See https://aka.ms/new-console-template for more information
using AbstractClassTask.Abstracts;

Bmw bm=new Bmw();
Mercedes me=new Mercedes();
Porche po=new Porche();

double toplamyakit = 0.0;
toplamyakit += bm.kaclitre();
toplamyakit += me.kaclitre();
toplamyakit += po.kaclitre();
Console.WriteLine("Toplam harcanan yakıt: " + "" + toplamyakit + " " + "Litredir.");