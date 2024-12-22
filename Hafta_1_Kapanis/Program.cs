//1.Konsola "Merhaba Dünya" yazdıran bir program yazın.
Console.WriteLine("Cevap 1:");

Console.WriteLine("Merhaba Dünya");

//2.Kullanıcıdan iki tam sayı alın ve bu sayıların toplamını konsola yazdırın.
Console.WriteLine("\nCevap 2:");

Console.Write("1. Sayıyı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Sayıyı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int toplam = sayi1 + sayi2;
Console.WriteLine("Sayıların toplamı = " + toplam);

//3.Kullanıcıdan yaşını isteyin. Eğer yaş 18 veya daha büyükse "Yetişkinsiniz" yazdırın, aksi takdirde "Çocuksunuz" yazdırın.
Console.WriteLine("\nCevap 3:");

Console.Write("Yaşınız: ");
int yas = Convert.ToInt32(Console.ReadLine());

if (yas >= 18)
    Console.WriteLine("Yetişkinsiniz");
else
    Console.WriteLine("Çocuksunuz");

//4.Kullanıcıdan bir tam sayı alın. Eğer sayı çift ise "Çift sayıdır" yazdırın, tek ise "Tek sayıdır" yazdırın.
Console.WriteLine("\nCevap 4:");

Console.Write("Sayı giriniz: ");
int sayi3 = Convert.ToInt32(Console.ReadLine());

if (sayi3 % 2 == 0)
    Console.WriteLine("Girdiğiniz sayı çift.");
else
    Console.WriteLine("Girdiğiniz sayı tek.");

//5.Kullanıcıdan bir sıcaklık değeri alın (Celsius cinsinden). Eğer sıcaklık 0'dan küçükse "Donuyor", 0 ile 30 arasında ise "Normal", 30'dan büyükse "Sıcak" yazdırın.
Console.WriteLine("\nCevap 5:");

Console.Write("Hava kaç derece?: ");
int derece = Convert.ToInt32(Console.ReadLine());

if (derece < 0)
    Console.WriteLine("Donuyor");
else if (derece > 30)
    Console.WriteLine("Sıcak");
else
    Console.WriteLine("Normal");

//6.Kullanıcıdan 1 ile 7 arasında bir sayı alın. Bu sayı günlerden birini temsil ediyor. Sayıya göre "Pazartesi", "Salı", vb. gün adlarını yazdırın. Geçersiz bir sayı girildiğinde "Geçersiz gün" yazdırın.
Console.WriteLine("\nCevap 6");

Console.Write("1-7 arası bir gün giriniz: ");
int gun = Convert.ToInt32(Console.ReadLine());

if (gun >= 1 && gun <= 7)
{
    switch (gun)
    {
        case 1:
            Console.WriteLine("Pazartesi");
            break;
        case 2:
            Console.WriteLine("Salı");
            break;
        case 3:
            Console.WriteLine("Çarşamba");
            break;
        case 4:
            Console.WriteLine("Perşembe");
            break;
        case 5:
            Console.WriteLine("Cuma");
            break;
        case 6:
            Console.WriteLine("Cumartesi");
            break;
        case 7:
            Console.WriteLine("Pazar");
            break;
    }
}
else
    Console.WriteLine("Geçersiz gün");

//7.Kullanıcıdan bir not(0-100 arasında) alın.Notun aralığına göre "Başarılı", "Orta", "Başarısız" yazdırın. (0-60 başarısız, 61-80 orta, 81-100 başarılı)
Console.WriteLine("\nCevap 7:");

Console.Write("0-100 arası bir not giriniz: ");
int not = Convert.ToInt32(Console.ReadLine());

if (not > 80 && not <= 100)
{
    Console.WriteLine("Başarılı");
}
else if (not > 60 && not <= 80)
{
    Console.WriteLine("Orta");
}
else if (not >= 0 && not <= 60)
{
    Console.WriteLine("Başarısız");
}
else
{
    Console.WriteLine("Geçersiz not girdiniz."); 
}

//8.Kullanıcıdan bir ay numarası (1-12) alın ve bu ayın kaç gün olduğunu yazdırın. Şubat ayı için 28 gün, diğer aylar için gün sayısını kontrol edin.
Console.WriteLine("\nCevap 8:");

Console.Write("1-12 arasında bir ay giriniz: ");
int ay = Convert.ToInt32(Console.ReadLine());

switch (ay)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine(ay + ". ay 31 gündür.");
        break;    

    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine(ay + ". ay 30 gündür.");
        break;   

    case 2:
        Console.WriteLine(ay + ". ay 28 gündür.");
        break;

    default:
        Console.WriteLine("geçersiz sayı girdiniz.");
        break;

}

//9.Kullanıcıdan bir şifre isteyin. Eğer şifre "12345" ise "Giriş Başarılı" yazdırın, değilse "Giriş Başarısız" yazdırın.
Console.WriteLine("\nCevap 9:");

Console.Write("5 haneli şifrenizi giriniz: ");
string sifre = Console.ReadLine();

if (sifre == "12345")
    Console.WriteLine("Giriş Başarılı");
else
    Console.WriteLine("Giriş Başarısız");

//10.Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alın. Seçilen işleme göre sonucu hesaplayın ve yazdırın. Eğer geçersiz bir işlem girilirse "Geçersiz işlem" yazdırın.
Console.WriteLine("\nCevap 10: ");

Console.Write("1. sayıyı giriniz: ");
int sayi4 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. sayıyı giriniz: ");
int sayi5 = Convert.ToInt32(Console.ReadLine());

Console.Write("Bir işlem giriniz (+,-,*,/): ");
string islem = Console.ReadLine();

switch (islem)
{
    case "+":
        int toplama = sayi4 + sayi5;
        Console.WriteLine($"Sonuç: {sayi4} + {sayi5} = {toplama}");
        break;

    case "-":
        int cikarma = sayi4 - sayi5;
        Console.WriteLine($"Sonuç: {sayi4} - {sayi5} = {cikarma}");
        break;

     case "*":
        int carpma = sayi4 * sayi5;
        Console.WriteLine($"Sonuç: {sayi4} * {sayi5} = {carpma}");
        break;

     case "/":
        int bolme = sayi4 / sayi5;
        Console.WriteLine($"Sonuç: {sayi4} / {sayi5} = {bolme}");
        break ;

    default:
        Console.WriteLine("Geçersiz işlem");
        break ;
}