# Kahve İsimleri Uygulaması

Bu proje, C# dilinde kullanıcıdan kahve isimlerini alarak bir liste oluşturmayı ve ardından bu listeyi ekrana yazdırmayı amaçlamaktadır.

## İçindekiler

1. [Proje Hakkında](#proje-hakkında)
2. [Kurulum](#kurulum)
3. [Kullanım](#kullanım)
4. [Kod Açıklamaları](#kod-açıklamaları)

## Proje Hakkında

Bu uygulama, kullanıcıdan toplamda 5 kahve ismi alır, bu isimleri bir liste içinde saklar ve ardından bu isimleri ekrana yazdırır. Kullanıcı deneyimini artırmak için konsol renkleri kullanılmıştır.

## Kurulum

1. C# geliştirme ortamını (Visual Studio veya .NET SDK) kurun.
2. Yeni bir C# konsol projesi oluşturun.
3. Aşağıdaki kodu `Program.cs` dosyasına yapıştırın.
4. Projeyi çalıştırmak için `F5` tuşuna basın veya `dotnet run` komutunu kullanın.

## Kullanım

1. Uygulama çalıştığında, kullanıcıdan sırasıyla 5 kahve ismi girmesi istenir.
2. Girilen kahve isimleri bir diziye kaydedilir.
3. Tüm kahve isimleri konsola yazdırılır.

## Kod Açıklamaları

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Kullanıcıdan kahve ismi girişi almayı amaçlayan bir mesaj yazdırıyoruz.
        Console.WriteLine("Lütfen Kahve Adı Giriniz."); 

        // string elemanlardan oluşan kahveler listesini tanımlıyoruz.
        List<string> kahveler = new List<string>(); 

        // Kullanıcıdan toplamda 5 kahve ismi alacağız.
        for (int i = 1; i <= 5; i++)
        {
            // Konsoldaki yazı rengini kırmızıya ayarlıyoruz.
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.Write($"Kahve {i}: "); // Kullanıcıdan 1'den 5'e kadar olan kahve isimlerini girmesi için bir prompt gösteriyoruz.

            // Konsoldaki yazı rengini koyu yeşile ayarlıyoruz.
            Console.ForegroundColor = ConsoleColor.DarkGreen; 
            // Kullanıcının girdiği kahve ismini okuyoruz ve bir string değişkene kaydediyoruz.
            string kahve = Console.ReadLine(); 

            // Kullanıcının girdiği kahve ismini kahveler listesine ekliyoruz.
            kahveler.Add(kahve); 
        }

        // Kullanıcının girdiği kahve isimlerini ekrana yazdırmak için bir döngü başlatıyoruz.
        foreach (string item in kahveler)
        {
            Console.WriteLine(item); // Liste içindeki her bir kahve ismini konsola yazdırıyoruz.
            Console.ResetColor(); // Konsol renklerini varsayılan duruma döndürüyoruz.
        }
    }
}
```

### Açıklamalar

- **Kullanıcıdan Kahve İsimleri Alma:** `Console.WriteLine` ile kullanıcıdan kahve isimleri girmesi istenir.
- **Liste Tanımlama:** `List<string>` kullanarak kahve isimlerini saklayacak bir liste oluşturulur.
- **Döngü ile İsim Alma:** `for` döngüsü ile kullanıcıdan 5 kahve ismi alınır.
- **Renk Ayarları:** Konsolun yazı rengini değiştirmek, kullanıcı deneyimini iyileştirir.
- **Listeyi Yazdırma:** `foreach` döngüsü ile kahve isimleri ekrana yazdırılır. 
