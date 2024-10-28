# 🚀 Patika Polymorphism Practice

Bu proje, C# dilinde **polimorfizm** konseptini anlamak ve pratik yapmak için hazırlanmıştır. 
Proje kapsamında **Kare, Dikdörtgen ve Üçgen** sınıflarının alan hesaplamaları, `BaseGeometrikSekil` sınıfından türetilerek gerçekleştirilmiştir.

## 📋 İçindekiler
- 🎯 Genel Bakış
- 📂 Proje Yapısı
- 💻 Kullanılan Teknolojiler
- ⚙️ Kurulum
- 🚀 Kullanım
- 📝 Kod Örneği
- 👨‍💻 Geliştirici

## 🎯 Genel Bakış
Bu projede, **polimorfizm** ile farklı geometrik şekillerin alan hesaplamaları gerçekleştirilmiştir. 
`BaseGeometrikSekil` sınıfı, ortak özellik ve metotları içerirken, alt sınıflar (Kare, Dikdörtgen ve Üçgen) kendi `AlanHesapla()` metotlarını **override** etmiştir.

## 📂 Proje Yapısı
- **BaseGeometrikSekil**: Genişlik ve yükseklik değerleri ile temel şekil sınıfı.
- **Kare**: Tek kenar uzunluğuna göre alan hesaplar.
- **Dikdörtgen**: Genişlik ve yükseklik parametrelerine göre alan hesaplar.
- **Üçgen**: Genişlik ve yüksekliğin çarpımının yarısı ile alan hesaplar.
- **Program.cs**: Konsolda şekillerin alanlarını hesaplar ve ekrana yazdırır.

## 💻 Kullanılan Teknolojiler
- **Dil**: C#
- **Platform**: .NET Core veya .NET Framework

## 🚀 Kullanım
Projeyi çalıştırdığınızda aşağıdaki gibi bir çıktı alacaksınız:
```bash
Karenin alanı: 25
Dikdörtgenin alanı: 24
Üçgenin alanı: 16 
```
## 📝 Kod Örneği
Aşağıda Üçgen sınıfından bir alan hesaplama metodunun örneği verilmiştir:
```csharp
public class Ucgen : BaseGeometrikSekil
{
    public Ucgen(double genislik, double yukseklik) : base(genislik, yukseklik) { }

    public override double AlanHesapla()
    {
        return (Width * Height) / 2;
    }
}
```


