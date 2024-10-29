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
    Console.ResetColor();
}
