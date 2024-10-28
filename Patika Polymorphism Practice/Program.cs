using Patika_Polymorphism_Practice;

BaseGeometrikSekil kare = new Kare(8);
BaseGeometrikSekil dikdortgen = new Dikdortgen(5, 6);
BaseGeometrikSekil ucgen = new Ucgen(4, 6);

Console.WriteLine($"Karenin Alanı: {kare.AlanHesapla()}");
Console.WriteLine($"Dikdörtgenin Alanı: {dikdortgen.AlanHesapla()}");
Console.WriteLine($"Dik Üçgenin Alanı: {ucgen.AlanHesapla()}");
