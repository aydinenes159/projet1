﻿
    
    Kurs kurs1 =new Kurs();
kurs1.kursAdi = "c#";
kurs1.Egitmen = "engin demirog";
kurs1.kursİzlenimi = 68;

Kurs kurs2 = new Kurs();
kurs2.kursAdi = "c++";
kurs2.Egitmen = "Enes AYDIN";
kurs2.kursİzlenimi = 67;

Kurs kurs3 = new Kurs();
kurs3.kursAdi = "JAVA";
kurs3.Egitmen = "AHMET BEY";
kurs3.kursİzlenimi = 123;

//Console.WriteLine(kurs1.kursAdi + " " + kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.kursAdi + " : " +kurs.Egitmen +" : "+ kurs.kursİzlenimi); 
}

class Kurs
{
    public string kursAdi { get; set; }
    public string Egitmen { get; set; }
    public int kursİzlenimi { get; set; }


}



