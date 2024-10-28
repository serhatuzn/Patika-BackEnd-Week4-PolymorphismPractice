using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patika_Polymorphism_Practice
{
    public class BaseGeometrikSekil
    {
        // Genişlik ve yükseklik özellikleri
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor: Genişlik ve yükseklik değerlerini ayarlamak için
        public BaseGeometrikSekil(double genislik, double yukseklik) 
        {
            this.Width = genislik;
            this.Height = yukseklik;
        }

        // Sanal (virtual) alan hesaplama metodu, alt sınıflar tarafından override edilebilir
        public virtual double AlanHesapla()
        {
            return 0;  // Varsayılan olarak 0 döner, alt sınıflarda bu metot özelleştirilir
        }
    }
    // Kare sınıfı, BaseGeometrikSekil sınıfından türetilir
    public class Kare : BaseGeometrikSekil
    {
        public Kare(double kenar) : base(kenar, kenar) { }//Constructor
        public override double AlanHesapla()
        {
            return Width * Height; // Kenar * Kenar
        }

    }

    // Dikdortgen sınıfı, BaseGeometrikSekil sınıfından türetilir
    public class Dikdortgen : BaseGeometrikSekil
    {
        public Dikdortgen(double genislik, double yukseklik) : base(genislik, yukseklik) { }//Constructor
        public override double AlanHesapla()
        {
            return Height * Width; // Kenar * Kenar
        }
    }

    // Üçgen sınıfı, BaseGeometrikSekil sınıfından türetilir
    public class Ucgen : BaseGeometrikSekil
    {
        public Ucgen(double genislik, double yukseklik) : base(genislik, yukseklik) { }//Constructor
        public override double AlanHesapla()
        {
            return (Width * Height) / 2;
        }
    }
}