// See https://aka.ms/new-console-template for more information
using LoopAndCondition.Araclar;
using LoopAndCondition.Calisanlar;
using LoopAndCondition.InsanVeArabaYasi;

Insan i=new Insan();
i.yasHesapla(1925);

Araba ar=new Araba();
ar.DurumNe(2019);

GenelMudur gm=new GenelMudur();
gm.adi = "Ertan";
gm.soyadi = "Acar";
gm.mesleği = "Genel Müdür";
gm.departman = "Yönetim";



Mudur mu=new Mudur();
mu.adi = "Ahmet";
mu.soyadi = "Kaya";
mu.mesleği = "Müdür";
mu.departman = "Finans";


Programci pro=new Programci();
pro.adi = "Ramazan";
pro.soyadi = "Ersoy";
pro.mesleği = "Programci";
pro.departman = "Bilgi İşlem";



Stajyer st= new Stajyer();
st.adi = "Mehmet";
st.soyadi = "Ünsal";
st.mesleği = "Stajyer";
st.departman = "Muhasebe";




string[] calisanGm = { gm.adi, gm.soyadi, gm.mesleği, gm.departman };
for (int sayac = 0; sayac < calisanGm.Length; sayac++)
{
    Console.WriteLine(calisanGm[sayac]);
}
Console.WriteLine(gm.KacparaMaas()+"Tl Maaş almaktadır...");
string[] calisanMu = {mu.adi,mu.soyadi,mu.mesleği,mu.departman };
for (int sayac1 = 0; sayac1 < calisanMu.Length; sayac1++)
{
    Console.WriteLine(calisanMu[sayac1]);
}
Console.WriteLine(mu.KacparaMaas()+"Tl maaş almaktadır...");

string[] calisanPr= {pro.adi,pro.soyadi,pro.mesleği,pro.departman };
for (int sayac2 = 0; sayac2 < calisanPr.Length; sayac2++)
{
    Console.WriteLine(calisanPr[sayac2]);
}
Console.WriteLine(pro.KacparaMaas()+"Tl maaş almaktadır...");
string[] calisanSt= {st.adi,st.soyadi,st.mesleği,st.departman };
for (int sayac3 = 0; sayac3 < calisanSt.Length; sayac3++)
{
    Console.WriteLine(calisanSt[sayac3]);
}
Console.WriteLine(st.KacparaMaas()+"Tl maaş almaktadır...");
double toplamMaas = 0.0;
toplamMaas += gm.KacparaMaas();
toplamMaas += mu.KacparaMaas();
toplamMaas += pro.KacparaMaas();
toplamMaas += st.KacparaMaas();
Console.WriteLine("Toplam Maaşları:" + toplamMaas);

Mercedes me = new Mercedes();
me.marka = "Mercedes";
me.model = "E-Class";
me.camsayisi = 6;
me.kapisayisi = 4;
me.yakitturu = "Dizel";


Bmw bm = new Bmw();
bm.marka = "BMW";
bm.model = "X3";
bm.camsayisi = 6;
bm.kapisayisi = 4;
bm.yakitturu = "Benzin";



Porche po = new Porche();
po.marka = "Porche";
po.model = "Cayan";
po.camsayisi= 6;
po.kapisayisi = 2;
po.yakitturu = "benzin";

Renault re = new Renault();
re.marka = "Renault";
re.model = "Fluence";
re.camsayisi = 6;
re.kapisayisi=4;
re.yakitturu = "Dizel";


Audi au = new Audi();
au.marka = "Audi";
au.model = "RS6";
au.camsayisi = 6;
au.kapisayisi = 2;
au.yakitturu = "benzin";

string[] Mercedes = { me.marka, me.model,"Cam Sayısı:"+me.camsayisi,"Kapı Sayısı:"+me.kapisayisi,me.yakitturu,"Yaktığı yakıt Litre:"+me.KacLitre()+"Litre"};
for (int sayacx=0;sayacx<Mercedes.Length;sayacx++)
{
    Console.WriteLine(Mercedes[sayacx]);
}
string[] BMW = { bm.marka, bm.model, "Cam Sayısı:" + bm.camsayisi, "Kapı Sayısı:" + bm.kapisayisi, bm.yakitturu, "Yaktığı yakıt Litre:" + bm.KacLitre() + "Litre" };
for (int sayacy = 0; sayacy < BMW.Length; sayacy++)
{
    Console.WriteLine(BMW[sayacy]);
}
string[] Porche = { po.marka, po.model, "Cam Sayısı:" + po.camsayisi, "Kapı Sayısı:" + po.kapisayisi, po.yakitturu, "Yaktığı yakıt Litre:" + po.KacLitre() + "Litre" };
for (int sayacz = 0; sayacz < Porche.Length; sayacz++)
{
    Console.WriteLine(Porche[sayacz]);
}
string[] Renault = { re.marka, re.model, "Cam Sayısı:" + re.camsayisi, "Kapı Sayısı:" + re.kapisayisi, re.yakitturu, "Yaktığı yakıt Litre:" + re.KacLitre() + "Litre" };
for (int sayacm = 0; sayacm < Porche.Length; sayacm++)
{
    Console.WriteLine(Renault[sayacm]);
}
string[] Audi = { au.marka,"Model: "+ au.model, "Cam Sayısı:" + au.camsayisi, "Kapı Sayısı:" + au.kapisayisi, au.yakitturu, "Yaktığı yakıt Litre:" + au.KacLitre() + "Litre" };
for (int sayaco = 0; sayaco < Audi.Length; sayaco++)
{
    Console.WriteLine(Audi[sayaco]);
}
double toplamLitre = 0.0;
toplamLitre += bm.KacLitre();
toplamLitre += po.KacLitre();
toplamLitre += au.KacLitre();
toplamLitre += me.KacLitre();
toplamLitre += re.KacLitre();
Console.WriteLine("Toplam harcanan Yakıt/litre:" + toplamLitre);

