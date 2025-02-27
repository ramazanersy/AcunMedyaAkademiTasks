// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Classes;

Bmw bm=new Bmw();
bm.marka = "BMW";
bm.vites = "Düz Viteslidir";
bm.vitesinigoster(bm.marka, bm.vites);

Porsche po=new Porsche();
po.marka = "Porsche";
po.vites = "Otomatik Viteslidir";
po.vitesinigoster(po.marka, po.vites);

Mercedes me=new Mercedes();
me.marka = "Mercedes";
me.vites = "Otomatik Viteslidir";
me.vitesinigoster(me.marka, me.vites);  

Togg t=new Togg();
t.marka = "Togg";
t.vites = "Düz Viteslidir";
t.vitesinigoster(t.marka, t.vites);

Audi a=new Audi();
a.marka = "Audi";
a.vites = "Otomatik";
a.vitesinigoster(a.marka, a.vites);

Toyota to=new Toyota();
to.vitesinigoster("Toyota", "Düz Viteslidir");
