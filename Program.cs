
//using System.Collections;
//using System.Globalization;
//using System.Net.Sockets;
//using System.Security.Cryptography.X509Certificates;
//using System.Threading.Channels;

//namespace c_tümkodlarım2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}
// See https://aka.ms/new-console-template for more information
//{
//    string isim = "ahmet";
//            Console.WriteLine("Alabaluk Hamisisu Sayın Laz Uşai"+ isim);

//        Console.ReadKey();

//        }

//int a, b;
//a = 40;
//b = 30;
////aritmetik operatörler

//Console.WriteLine(a+b);
//Console.WriteLine(a-b);
//Console.WriteLine(a/b);
//Console.WriteLine(a*b);
//Console.WriteLine(a%b);

//ilişkisel operatörler
//Console.WriteLine(a<b);
//Console.WriteLine(a>b);
//Console.WriteLine(a>=b);
//Console.WriteLine(a<=b);
//Console.WriteLine(a!=b);

//mantıksal operatörler
//Console.WriteLine(a > b && a>=b);
//Console.WriteLine(a < b && b>=a);
//Console.ReadKey();



//using System.Globalization;

//tek - çift

//Console.WriteLine("bir sayı giriniz:");


//int sayi = Convert.ToInt32(Console.ReadLine());

//if (sayi % 2 == 0)
//{
//    Console.WriteLine($"{sayi}çift bir sayıdır.");
//}




//else
//{
//    Console.WriteLine($"{sayi}tek bir sayıdır.");
//}


//Console.ReadKey();

//var k = (char)Console.Read();
//        if (char.IsDigit(k))
//        {
//            Console.WriteLine("Rakamdır!");
//        }
//        else if (char.IsLower(k))
//        {
//            Console.WriteLine("Kucuk karakter.");
//        }
//         else if (char.IsUpper(k))
//        { Console.WriteLine("BUYUK KARAKTER.");

//        }
//        else
//        { Console.WriteLine("Bilinmeyen karakter"); 

//        }

//        Console.WriteLine(k);
//        Console.ReadKey();


//ekrandan kullanıcı girdisini alma


//int sayi;
//Console.WriteLine("lütfen bir sayı girin!");
//string  girdi = Console.ReadLine();
//sayi =Convert.ToInt32(girdi);
//Console.WriteLine(sayi +2);
//Console.ReadLine();


//kullanıcıdan alınan sayının karesini hesaplayan uygulama

//int sayi;
//Console.WriteLine("lütfen bir sayı giriniz");
//string girilen =Console.ReadLine();
//sayi= Convert.ToInt32(girilen);
//int kare = sayi * sayi;
//Console.WriteLine("sayının karesi:" + kare);
//Console.ReadLine();


//toplama uygulaması

//int s1, s2;
//Console.WriteLine("lütfen birinci sayıyı giriniz:");
//string giris1 = Console.ReadLine();
//Console.WriteLine("lütfen ikinci sayıyı giriniz:");
//string giris2 = Console.ReadLine();

//int toplam = Convert.ToInt32(giris1); +Convert.ToInt32(giris2);
//Console.WriteLine("toplam:" +toplam);
//Console.ReadLine ();

//int s1, s2;
//Console.WriteLine("lütfen birinci sayıyı giriniz:");
//string giris1 = Console.ReadLine();
//Console.WriteLine("lütfen ikinci sayıyı giriniz:");
//string giris2 = Console.ReadLine();

//int toplam = Convert.ToInt32(giris1) +Convert.ToInt32(giris2);
//Console.WriteLine("toplam:" + toplam);
//Console.ReadLine();


//tasarruf hesaplayıcısı
//kaç ampul? kaç saat?
//normal ampul saatte 2tl 
//tasarruflu ise %20 hesaplı
//çıktı olarak:Normal ampul faturası,tasarruflu tutar

//int ampulsayisi, saat;
//float fiyat = 2;
//Console.WriteLine("tasarruf hesaplama uygulamasına hoşgeldiniz! \n Lütfen kaç ampul kullandığınızı yazınız");
//ampulsayisi = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("kaç saat kullanıyorsunuz?");
//saat = Convert.ToInt32(Console.ReadLine());

//float faturatutarı = ampulsayisi * saat * fiyat;
//float tasarruflututar = faturatutarı * 80 / 100;
//Console.WriteLine("tasarrufsuz fatura tutarı:" + faturatutarı);
//Console.WriteLine("tasarruflu fatura tutarı:" + tasarruflututar);
//Console.ReadLine();

//if else

//Console.WriteLine("lütfen bir sayı girin");

//int sayi =Convert.ToInt32(Console.ReadLine());

//if (sayi > 10)  Console.WriteLine("sayı ondan büyüktür");
//else if (sayi == 5) Console.WriteLine("SAYI 5'e eşittir");
//else Console.WriteLine("sayı ondan küçük veya eşittir");

//Console.ReadLine();


//SWİTCH-CASE
//Console.WriteLine("lütfen sayı girin");
//int sayi = Convert.ToInt32(Console.ReadLine);

//switch (sayi)

//{    case 1:
//        Console.WriteLine("sayı 1 dir");
//        break;

//    case 2:
//        Console.WriteLine("sayi 2 dir");
//        goto case 4;
//        break;

//    case 4:
//        Console.WriteLine("sayı 4 e eşit");
//        break;

//}
//Console.ReadKey();
//Console.ReadLine();



//tek çift bulan programı yazınız

//Console.WriteLine("lütfen bir sayı girin");
//int sayı =Convert.ToInt32(Console.ReadLine());
//bool ciftmi;

//if (sayı % 2 == 0) 

//{
//    ciftmi = true;
//}
//else 
//{
//   ciftmi= false;
//}
//if  (ciftmi==true)

//{
//    Console.WriteLine("sayı çifttir");
//}
//else 
//{
//    Console.WriteLine("sayı tektir");
//}
//Console.ReadLine();



//ile göre gezi rehber programı yapın
//lütfen bir il seçiniz: a-Ankara b-İstanbul c-Erzurum d-Trabzon e-Kastamonu

//Console.WriteLine("merhaba!Lütfen bir il seçiniz \na-Ankara b-İstanbul c-Erzurum d-Trabzon e-Kastamonu");
//string secim =Console.ReadLine();
//if (secim == "a")
//{
//    Console.WriteLine("anıtkabiri gezmeyi unutma");
//}
//else if (secim == "b")
//{
//    Console.WriteLine("vapurda dolaş");
//}
//else if (secim == "c")
//{
//    Console.WriteLine("çağ kebabı ye");
//}
//else if (secim == "d")
//{
//    Console.WriteLine("sümela manastırına git");
//}
//else if (secim == "e")
//{
//    Console.WriteLine("şehir merkezinde dolaş");
//}
//else
//{
//    Console.WriteLine("lütfen düzgün giriş yapınız");
//}
//Console.ReadLine();


//girilen sayıların en küçüğünü söyleyen program

//int sayi1, sayi2, sayi3;
//Console.WriteLine("sayı 1:");
//sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("sayı 2:");
//sayi2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("sayı 3:");
//sayi3 = Convert.ToInt32(Console.ReadLine());

//if (sayi1 <= sayi2 && sayi1 <= sayi3)
//{
//    Console.WriteLine("sayı 1 en küçüktür");
//}
//else if (sayi2 <= sayi3 && sayi2 <= sayi1)
//{
//    Console.WriteLine("Sayı 2 en küçüktür");
//}
//else if (sayi3 <= sayi1 && sayi3 <= sayi2)
//{
//    Console.WriteLine("sayı 3 en küçüktür");
//}
//Console.ReadLine();    


//üçgen çizilebilir mi çizilemez mi programı

//int a, b, c;
//Console.WriteLine("a kenarını giriniz:");
//a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("b kenarını giriniz:");
//b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("c kenarını giriniz:");
//c = Convert.ToInt32(Console.ReadLine());

//int toplam = b + c, mutlakfark;

//if (b-c <0)
//{
//    mutlakfark = (b - c) * -1;
//}
//else
//{
//    mutlakfark = b - c;
//}
//if (mutlakfark < a && a < toplam)
//{
//    Console.WriteLine("Üçgen çizilebilir");
//}
//else
//{
//    Console.WriteLine("Üçgen çizilemez");
//}
//Console.ReadLine();


//10 dan küçük olan sayıların tek çift olduğunu söyleyen,olmayanların ise karesini söyleyen uygulama

//Console.WriteLine("lütfen bir sayı giriniz");
//int sayi=Convert.ToInt32(Console.ReadLine());

//if (sayi <10)

//{
//    if(sayi %2 == 0)
//   {
//        Console.WriteLine("sayı 10 dan küçük ve çifttir.");
//   }

//    else
//    {
//        Console.WriteLine("sayı 10 dan küçüktür ve tektir.");
//    }

//}
//else
//{
//    Console.WriteLine("sayının karesi:"+ sayi *sayi);
//}
//Console.ReadLine();


//YAZILAN GÜNÜN SICAAKLIĞINI SÖYLEYEN PROGRAM
//Console.WriteLine("lütfen bir gün giriniz");
//string gun=Console.ReadLine();

//switch (gun)

//{
//    case "pazartresi":
//        Console.WriteLine("hava 0 derece dir");
//        break;
//    case "salı":
//        Console.WriteLine("hava 1 derece dir");
//        break;
//    case "çarşamba":
//        Console.WriteLine("hava 2 derecedir");
//        break;
//    case "perşembe":
//        Console.WriteLine("hava 3 derecedir");
//        break;
//    case "cuma":
//        Console.WriteLine("hava 4 derecedir");
//        break;

//        default : 
//        Console.WriteLine("bu güne ait bir tahmin bulunmamakatadır.");
//         break;
//}
//Console.ReadLine();


//switch-case yapısıyla bir hesap makinesi yap

//int sayı1, sayı2;
//Console.WriteLine("lütfen sayı 1'i giriniz");
//sayı1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("lütfen sayı 2'yi giriniz");
//sayı2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("lütfen yapmak istediğiniz işlemi giriniz + - * /");
//string islem = Console.ReadLine();

//switch (islem)
//{
//    case "+":
//        Console.WriteLine(sayı1 + sayı2);
//        break;
//    case "-":
//        Console.WriteLine(sayı1 - sayı2);
//        break;
//    case "*":
//        Console.WriteLine(sayı1 * sayı2);
//        break;
//     case "/":
//        Console.WriteLine(sayı1 / sayı2);
//        break;
//    default:
//        Console.WriteLine("Lütfen doğru işlem giriniz!!");
//        break;
//}
//Console.ReadLine();


//for dögüsü
//Console.WriteLine("lütfen bir sayı giriniz!");
//int sayı =Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= sayı; i++)
//{
//    Console.WriteLine(i);
//}
//Console.ReadLine();


// 1 ile 1000 arasında 5 e bölünen 11.sayı
//int sayaç = 0;

//for (int i = 1; i < 1000; i++)

//    if (i % 5 == 0)
//    {sayaç++;
//        if (sayaç == 11)
//        {
//            Console.WriteLine(i);
//            break;
//        }
//    }


//Console.ReadLine();

// 3'e bölünen 1 le 1000 arasındaki sayılar

//for (int i = 1; i <= 1000; i++)

//if (i % 3 == 0)
//{
//    Console.WriteLine(i);
//}
//Console.ReadLine();


//1000 ile 1 arasındaki sayıları yazdırın

//for (int i = 1000;i >= 1; i--)
//{
//    Console.WriteLine(i);
//}




//BAYADIR UDEMY C# DERSİNİ GÖRÜYORUM BTK SARMADI BURASI İYİ GİBİ YUKARDAKİ DERSLER UDEMYDEN


//DO WHİLE

//int sayı = 9;
//while (sayı >5)
//{
//    Console.WriteLine("sayı 5 den büyüktür");
//    sayı--;
//}

//soru1 :1-X arasındaki sayıları ekrana yazdırın.
//Console.WriteLine("bir sayı giriniz");
//int sayı =Convert.ToInt32(Console.ReadLine());
//int sayaç = 1;
//while (sayaç <= sayı) 
//{
//    Console.WriteLine(sayaç);
//    sayaç++;
//}
//Console.ReadLine();

//1000-X arasındaki sayıları yazdırın.
//Console.WriteLine("bir sayı giriniz");
//int sayı=Convert.ToInt32(Console.ReadLine());
//int sayaç = 10000;
//while (sayaç > sayı)
//{
//    Console.WriteLine(sayaç);
//    sayaç--;
//}
//Console.ReadLine();

//1 den 1000 e kadar olan tek sayıların karelerini yazdırınız
//int sayaç = 1;
//while (sayaç < 1000)

//{
//    if (sayaç % 2 == 1) 
//    {
//        Console.WriteLine(sayaç * sayaç);
//    }
//    sayaç++;
//}
//Console.ReadLine();

//int x, y;
//Console.WriteLine("ilk sayıyı girin");
//x=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("ikinci sayıyı giriniz");
//y=Convert.ToInt32(Console.ReadLine());
//int toplam = 0;
//for (int i = x; i <= y; i++)

//{
//    if (i % 2 == 0)

//    {
//        toplam += i;
//    }

//}
//Console.WriteLine("toplam:" + toplam);
//Console.ReadLine();


//soru:üst hesaplayan program


//int taban, üst;
//Console.WriteLine("tabanı girin");
//taban =Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("üssü giriniz");
//üst = Convert.ToInt32(Console.ReadLine());

//int sonuç = 1;
//for (int i = 0; i < üst; i++)

//     {
//    sonuç *= taban;
//     }
//Console.WriteLine("sonuç:"+sonuç);

//Console.ReadLine();


// soru:faktöriyel hesaplayan program
//Console.WriteLine("faktöriyel hesaplanacak sayıyı yazınız");
//int sayı =Convert.ToInt32(Console.ReadLine());
//int sonuç = 1;
//for (int i = 2; i<= sayı; i++)

//{
//    sonuç *= i;
//}
//Console.WriteLine(sonuç);
//Console.ReadLine();



//soru:tuttuğum sayıyı tahmin etmeye çalışan ve 3 hak veren program

//Random rnd = new Random();
//int tutulansayı=rnd.Next(1,10);
//int tahmin;
//bool Doğrubildi = false;

//for (int i = 0; i<3 ; i++)
//{
//    Console.WriteLine("tahmin giriniz:");
//    tahmin =Convert.ToInt32(Console.ReadLine());
//    if (tahmin ==tutulansayı)
//    {
//        Doğrubildi=true;
//        break;
//    }
//}
//if (Doğrubildi)
//{
//    Console.WriteLine("tebrikler doğru bidiniz");
//}
//else
//{
//    Console.WriteLine("bilemediniz! tuttuğum sayı:"+ tutulansayı);
//}
//Console.ReadLine();



//int[] dizi = { 5, 6, 7, 8, 78, 45, 0, 30 };
//int toplam = 0;
//for (int i = 0; i < dizi.Length; ++i)
//    toplam += dizi[i];
//Console.WriteLine(toplam);


////2 SAYIYI KUllANICIDAN ALIP TOPLAYAN FONKSİYONU YAZINIZ.

//int sayı1, sayı2;
//int toplam;
//Console.WriteLine("sayı 1'i giriniz");
//sayı1 =Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("sayı 2'yi giriniz");
//sayı2 =Convert.ToInt32(Console.ReadLine());

//toplam = topla(sayı1, sayı2);
//Console.WriteLine(toplam);
//Console.ReadLine()
//static int topla(int sayı1,int sayı2)
//    {
//   return sayı1 + sayı2;
//    }

//verilen ölçülerdeki karenin alanını hesaplayan fonksiyonu yazın

//Console.WriteLine("karenin kenarını giriniz");

//int kenar = Convert.ToInt32(Console.ReadLine());
//int alan = karealanıhesapla(kenar);
//Console.WriteLine("karenin alanı:" + alan);
//Console.ReadLine();
//static int karealanıhesapla(int akenarı)
//{
//    return akenarı * akenarı;
//}

//kare,üçken daire seçilecek bunun alanı hesaplanacak uygulama
//a*a
//h * taban / 2
//pi *r*r

//static void main()
//{
//    Console.WriteLine("lütfen alan hesabı yapmak istediğiniz şekli seçin 1-kare 2-üçgen 3-daire");
//    int secim = Convert.ToInt32(Console.ReadLine());
//    switch (secim)


//    {
//        case 1:
//            Console.WriteLine("lütfen a kenarını giriniz");
//            int a = Convert.ToInt32(Console.ReadLine());
//            int alan = karealanıhesapla(a);
//            Console.WriteLine("karenin alanı {0} dır" + alan);
//            break;
//        case 2:
//            Console.WriteLine("lütfen tabanı giriniz");
//            int taban = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("yüksekliği giriniz");
//            int yükseklik = Convert.ToInt32(Console.ReadLine());
//            int alanucgen = üçgenalanıhesapla(taban, yükseklik);
//            Console.WriteLine("üçgenin alanı:{0}" + alanucgen)
//            break;
//        case 3:
//            Console.WriteLine("lütfen r değerini giriniz:");
//            int r = Convert.ToInt32(Console.ReadLine());
//            double alandaire = dairealanıhesapla(r)
//            Console.WriteLine("daire alanı {0}" + alandaire);
//            break;
//        default:
//            Console.WriteLine("yanlış seçim yaptınız.");
//            break;
//    }
//    Console.ReadLine();
//}
//static double dairealanıhesapla(double yarıçap)
//{
//    return yarıçap * yarıçap * Math.PI;
//}
//static int üçgenalanıhesapla(int taban, int yükseklik)
//{
//    return taban * yükseklik / 2;
//}
//static int karealanıhesapla(int akenar)
//{
//    return akenar * akenar;
//}


//params(sayıların hepsini kısa yoldan toplama)
//int toplam2 = topla(3, 3, 2, 23, 1);
//Console.WriteLine(toplam2);
//Console.ReadLine();

//static int topla(int sayı1, int sayı2)
//{
//    return sayı2 + sayı1;
//}
//static int topla(params int[] sayı)
//{
//    int toplam = 0;
//    for (int i = 0; i< sayı.Length; i++)
//    {
//        toplam += sayı[i]
//    }

//    return toplam;
//}
//static int topla(params int[] sayı)
//{
//    int toplam = 0;
//    for(int i = 0; i< sayı.Length; i++)

//    { 
//    toplam += sayı[i]
//    }
//    return toplam;
//}
// private static int kelimesayısıbul(string metin)
//{
//    int sayac = 1;
//    //boşlukları say her boşlukta sayacı arttır.
//    foreach (char karakter in metin)
//    {
//        if (karakter == ' ') 

//        { 
//        sayac++
//        { 
//                sayac++
//    }
//}



//bir  aracın gittiği yol ve gidiş süresinden ortalama hızı bulan metod(fonksiyon)
//static void hiz ( double yol,double süre)
//{
//    double ortalamahiz = yol / süre;
//    Console.Write("aracın ortalama hızı {0} km/s ",ortalamahiz);
//}
//static void Main(string[] args)
//{
//    double alınanyol, zaman;
//    Console.WriteLine("gidilen yolu giriniz (km)");
//    alınanyol =Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("toplam süreyi giriniz ()saat");
//    zaman = Convert.ToDouble(Console.ReadLine());
//    hiz(alınanyol, zaman);
//    Console.ReadKey();
//}


//{
//    int n = 5;
//    for (int i = 0; i < n; i++)

//    {
//        for (int j = 0; j <= i; j++)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//    Console.ReadKey();
//}

//Console.WriteLine("lütfen a yı gir");
//int a=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("lütfen b yi gir");
//int b =Convert.ToInt32(Console.ReadLine());
//if(a==b)
//{
//    Console.WriteLine("a ve b birbirine eşittir çiğerim");
//}
//if (a!=b)
//{
//    Console.WriteLine("a eşit değildir b ye");
//}
//if (a<b)
//{
//    Console.WriteLine("a küçüktür b den");
//}
//if (b<a)
//{
//    Console.WriteLine("a büyüktür b den");
//}

//Console.ReadKey();


//diziler btk


//tanımlama & başlatma & atama 
//int[] numaralar = new int[3] { 3,5,10};

//numaralar[0] = 3;
//numaralar[1] = 5;    atama
//numaralar[2] = 10;


//    for (int i = 0; i < numaralar.Length; i++)
//    {
//        Console.WriteLine(numaralar[i]);
//    }

//    Console.ReadKey();

//ctrl+k+c yorum satırına dönüştürme kısayol

//Console.WriteLine("dizi boyutunu giriniz:");
//int boyut = Convert.ToInt32(Console.ReadLine());
//int[] sayilar = new int[boyut];

//var r = new Random();

//for (int i = 0; i < sayilar.Length; i++)
//    sayilar[i] = r.Next(1, 10);
//döngülerde tek satırlık kod varsa paranteze almamıza gerek yok, hemen altındaki satıra yazarsak bu dediğim geçerlidir

//foreach (int s in sayilar)
//  Console.WriteLine($"{s,5} {s*s,5}");

//Console.ReadKey();

//double[,] matris = new double[,]

//    {
//      {1,2,3,4 },
//      {2,3,4,5 },
//      {3,4,5,6 }
//    };

//double toplam = 0;

//for (int i = 0; i < matris.GetLength(0); i++)
//{
//    for (int j = 0; j < matris.GetLength(1); j++)
//    {
//        if (j == i)
//            matris[i, j] = -1;

//        if (matris[i, j] % 2 == 0)
//            matris[i, j] = 0;

//        toplam += matris[i, j];

//        Console.Write($"{matris[i,j],5}");
//     }
//    Console.WriteLine();
//}
//Console.WriteLine($"toplam: {toplam}");

//Console.ReadKey();

//LİSTELER


//TANIMLAMA
//var sayılar = new List<int>() { 10, 15, 30 };

//int x = 55;
////int[] seri = new int[] { 70, 80, 90 };
////ekleme
//sayılar.Add(1);
//sayılar.Add(5);
//sayılar.Add(9);
//sayılar.Add(x);
//sayılar.AddRange(new int[] { 40, 50, 60 });

////araya ekleme,çıkarma
//sayılar.Insert(3,0);
//sayılar.InsertRange(4, new int[] { 15, 30 });

////çıkarma
//sayılar.RemoveAt(3);
//sayılar.RemoveAt(sayılar.IndexOf(55));
////dolaşma
//foreach (var s in sayılar)
//{
//    Console.Write($"{s,-5}"); 
//}
//Console.ReadKey();


//METODLAR(FONKSİYONLAR) 

//static void Main(string[] args)
//{
//    int buyuk = karsilastir(3, 5);
//    Console.WriteLine(buyuk);
//    Console.ReadKey();
//}





//static int karsilastir(int x, int y)
//{ 
//    if (x > y)
//    {
//        return x;
//    }
//    else
//    {
//        return y; 
//    }
//}
//Console.ReadKey(); 
//static void Main(string[] args)
//{
//    double tolam = seritoplami(5.12, 4.13, 12.91);
//    Console.WriteLine("{0,5:0.##)", tolam);
//    /*0##'ı fazla küsürat koymasın diye yazdık*/
//    Console.ReadKey();
//}

//static double seritoplami(params double[] seri)
//   {
//   double toplam = 0;
//    foreach (double s in seri)
//        toplam = +s;
//    return toplam;
//   }


//ÜCRETE KDV EKLEME

//yazılıma burdan devam et



//Console.WriteLine("YAŞINIZI GİRİN:");
//int yaş=Convert.ToInt32(Console.ReadLine());

//if (yaş < 18)
//{
//    Console.WriteLine("çocuksunuz,yetişkin değilsiniz!");
//}
// if (yaş >= 18 && yaş<65)
//{
//    Console.WriteLine("yetişkin bir bireysiniz!");
//}
//else if (yaş >= 65)
//{
//    Console.WriteLine("hem yetişkin hem yaşlı bir bireysiniz!");
//}
//Console.ReadKey();



//class Program
//{
//    //static void Main(string[] args)
//    //{
//    //    Yontem("ali ");
//    //    Yontem("mehmet zahid ");
//    //    Yontem("zahide ");
//    //}


//    static void Main(string[] args)
//    {
//        yasveisim("battal", 25);
//        yasveisim("zahide", 46);
//        yasveisim("mehmet zahid", 18);
//    }




//    public static void yasveisim(string isim,int yaş);
//    {
//      Console.WriteLine(yaş);
//    }

//    //static void Yontem(string isim)
//    //{
//    //  Console.WriteLine(isim + "BÜYÜKZENGİN");
//    //}
//}


//yasveisim("btl", 25);
//yasveisim("derviş", 46);
//yasveisim("mehmet zahid", 18);

//kareal(5);
//kareal(6);
//kareal(7);
//kareal(8);




//static void yasveisim(string isim, int yaş)
//{
//    Console.WriteLine(yaş + " " + isim + " Büyükzengin");
//}

//static void kareal(int sayı1)
//{
//    Console.WriteLine(sayı1*sayı1);
//}



//class Program
//{
//static void Main(string[] args)
//{
//struct kullanma
//Ogrenci ogr = new Ogrenci();
//ogr.Numara = 265;
//ogr.Adi = "MEHMET ZAHİD";
//ogr.Soyadi = "BÜYÜKZENGİN";
//ogr.Cinsiyet = true;   //erkek tru olarak düşündük şimdilik

//ALTERNATİF KULLANIMI 
//var ogr2 = new Ogrenci()
//{
//    Numara = 10,
//    Adi = "bb",
//    Soyadi = "büyükzenign",
//    Cinsiyet = false
//};
//2.ALTERNATİF KULLANIMI

//var ogrenciListesi = new List<Ogrenci>()
//{
//    new Ogrenci(30, "mehmet", "avşar",true),
//    new Ogrenci(10,"bt","BÜYÜKZENGİN",false),
//    new Ogrenci(265,"mehmet zahid","BÜYÜKZENGİN",true),
//    new Ogrenci(1,"Ahmet","kzkb", true),
//};

//ogrenciListesi.ForEach(o => Console.WriteLine(o));

//Console.WriteLine($"{ogr2.Numara} " +
//   $"{ogr2.Adi} " + $"{ogr2.Soyadi} " +
//   $"{ogr2.Cinsiyet} ");

//Console.WriteLine($"{ogr.Numara} " +
//    $"{ogr.Adi} " + $"{ogr.Soyadi} " +
//    $"{ogr.Cinsiyet} ");

//Console.WriteLine($"{ogr3.Numara} " +
//   $"{ogr3.Adi} " + $"{ogr3.Soyadi} " +
//   $"{ogr3.Cinsiyet} ");

//Console.ReadKey();
//}

//class program
//{
//    static void Main(string[] args)
//    {
////VERİ YAPILARINA GİRİŞ
////array/ dizi /tanımlama
//int[] sayilar = new int[] { 5, 3, 8, 10, 2, 18, 23, 44, 55, 6, 34, 19 };
//var numbers = Array.CreateInstance(typeof(int),sayilar.Length);
//var arr = new ArrayList(sayilar);

////numbers.SetValue(-5, 0);
////numbers.SetValue(3, 1);
////numbers.SetValue(8, 2);
////numbers.SetValue(10, 3);
////numbers.SetValue(-2, 4);

////yukardakiler yerin Copyto kullanıyoruz
//sayilar.CopyTo(numbers, 0);

////sıralıyoruz sayıları sort ile
//Array.Sort(numbers);
//Array.Sort(sayilar);

////sayilar dizisinden 0. diziden itibaren 3 toplamda 3 dizi temizledik virgülün solu kaçıncı diziden başlayacağımızı sağdaki kaç tane sileceğimizi yazıyoruz
//Array.Clear(sayilar, 2, 2);
//// indexof ile dizide herhangi bir sayıyı yazıp kaçıncı dizi olduğunu bulabiliyoruz(eğer olmayan bir değer girersek -1 değeri verir)
//Console.WriteLine(Array.IndexOf(sayilar, 44));
//arr.Sort();
////dolaşma
//for (int i = 0; i < sayilar.Length; i++)

//{
//    Console.WriteLine($"sayilar[{i}] = " +
//        $"{sayilar[i],3} - " +
//        $"numbers[{i}] = " +
//        $"{numbers.GetValue(i),3}" +
//        $"  arr[{i}]= " +
//        $"  {arr[i],3}");
//}
//Console.ReadKey();


//HASHTABLE - HASHTABLE - HASHTABLE - HASHTABLE

//tanımlama
//var sehirler =new Hashtable();

//    //EKLEME
//    sehirler.Add(6, "Ankara");
//    sehirler.Add(34, "İstanbul");
//    sehirler.Add(55, "Samsun");
//    sehirler.Add(23, "Elazığ");

////dolaşma 
//foreach (DictionaryEntry item in sehirler)
//    {
//        Console.WriteLine($"{item.Key,-5} "+
//            $"-{item.Value,-20}");
//    }
//    //anahtarları alma
//    Console.WriteLine("\nAnahtarlar (keys)");
//    var anahtarlar = sehirler.Keys;

//    foreach (var item in anahtarlar)
//    {
//        Console.WriteLine(item);
//    }
//    //değerler
//    Console.WriteLine("\ndeğerler (values)");
//    ICollection degerler = sehirler.Values;
//    foreach (var item in degerler)
//    {
//        Console.WriteLine(item);
//    }

//    //elemana erişme 
//    Console.WriteLine("\nElemana erişme");
//    Console.WriteLine(sehirler[34]);

//    //Eleman silme
//    Console.WriteLine("\neleman silme");
//    sehirler.Remove(23);

//    //dolaşma (silinen elemanı görebilmemiz için birdaha dolaşmayani yukardaki forechi yazdık)
//    foreach (DictionaryEntry item in sehirler)
//    {
//        Console.WriteLine($"{item.Key,-5} " +
//            $"-{item.Value,-20}");
//    }

//    Console.ReadKey();
//}

//}

//class program
//{
//    static void Main(string[] args)
//    {
//        //HASHTABLE UYGULAMASI

//        //başlığı okuma
//        Console.WriteLine("başlık giriniz: ");
//        string baslik =Console.ReadLine();

//        //kucultme
//        baslik = baslik.ToLower();

//        //hashtable
//        //tanımlama yaptık mesela ç yazarsak otomatik c çevirecek
//        var karakterseti = new Hashtable()

//        {
//            {'ç','c'},
//            {'ı','i'},
//            {'ö','o'},
//            {'ü','u'},
//            {' ','-'},
//            {'\'','-'},
//            {'ğ','g'},
//            {'.','-'},
//            {'?','-'},
//            {'ş','s'},
//        };

//        foreach (DictionaryEntry item in karakterseti)
//        {
//            baslik =baslik.Replace((char)item.Key, (char)item.Value);
//        }
//        Console.WriteLine(baslik);

//        Console.ReadKey();

//    }

//}

// public class program
//{
//    static void Main(string[] args)
//    {
//        //SORTED LİST TEMELLERİ     SORTED LSİT       SORTED LİST
//        //TANIMLAMA 
//        var list = new SortedList()
//        {
//            {1,"bir"},
//            {2,"iki"},
//            {3,"üç"},
//            {8,"dört"},
//            {5,"beş"},
//            {6,"altı"},
//        };

//        list.Add(4, "dört");

//        //Dolaşma
//       foreach (DictionaryEntry item in list)
//        {
//            Console.WriteLine($"{item.Key}-{item.Value}");
//        }

//        Console.WriteLine("listedeki eleman sayısı    : {0}",list.Count);
//        Console.WriteLine("listenin kapasitesi    : {0}",list.Capacity);
//        list.TrimToSize();
//        Console.WriteLine("listenin kapasitesi    : {0}",list.Capacity);

//        //ERİŞME
//        //key
//        Console.WriteLine(list[3]);
//        //Index
//        Console.WriteLine(list.GetByIndex(0));
//        //get  -> key
//        Console.WriteLine(list.GetKey(0));
//        //liste sonundaki elemanın değeri
//        Console.WriteLine(list.GetByIndex(list.Count-1));


//        var anahtarlar = list.Keys;
//        Console.WriteLine("\n ANAHTARLAR");
//        foreach(var item in anahtarlar)
//        {
//            Console.WriteLine(item);
//        }

//        var degerler = list.Values;
//        Console.WriteLine("\nDEGERLER");
//        foreach (var item in degerler)
//        {
//            Console.WriteLine(item);
//        }


//        Console.WriteLine("\nGÜNCELLEME");
//        if (list.ContainsKey(1))
//        {
//            list[1] = "one";
//        }

//        //DOLAŞMA
//        foreach (DictionaryEntry item in list)
//        {
//            Console.WriteLine($"{item.Key} - {item.Value}");
//        }

//        Console.ReadKey();

//    }


//}

//public class program
//{
//    static void Main(string[] args)
//    {
//        //SORTED LİST UYGULAMA (kitap içerikleri yazan kısım)
//        var kitapİcerigi = new SortedList();
//        kitapİcerigi.Add(1, "Önsöz");
//        kitapİcerigi.Add(50, "değişkenler");
//        kitapİcerigi.Add(40, "Operatörler");
//        kitapİcerigi.Add(60, "döngüler");
//        kitapİcerigi.Add(45, "ilişkisel Operatörler");

//        Console.WriteLine("içindekiler");
//        Console.WriteLine(new string('-', 125));

//        Console.WriteLine($"{"konular",-33} {"sayfalar",-0}");
//        foreach(DictionaryEntry item in kitapİcerigi)
//        {
//            Console.WriteLine($"{item.Value,-33} {item.Key,5}");
//        }       
//        Console.ReadKey();
//    }
//}

//LİST<T>     //LİST<T>    //LİST<T>      //LİST<T>

//NOTLAR:
//-System Collections Generic sınıfı altında yer alır

//Array -->ArrayList (object)-->List<T> -->Type(Tip)

//Tip güvenliği generic liste ile sağlanır.

//Add()       Count
//addRange()    Capacity
//Remove()
//RemoveRange()

//INTERFACE(ARAYÜZ)-->kontratları devralır (kalıtım-inheritence)

//c#--> class(inheritence)
//.... --> interface inheritence


//public class Sehir : IComparable<Sehir>
//{
//    public int PlakaNo { get; set; }
//    public string SehirAdi { get; set; }
//    public Sehir(int plakaNo,string sehiradı)
//    {
//        PlakaNo = plakaNo;
//        SehirAdi = sehiradı;
//    }
//    public override string ToString()
//    {
//        return $"{PlakaNo,-5} {SehirAdi,-15}";
//    }

//    public int CompareTo(Sehir other)
//    {
//        if(this.PlakaNo<other.PlakaNo)
//        {
//            return -1;
//        }

//        else if (this.PlakaNo==other.PlakaNo)
//        {
//            return 0;
//        }

//        else
//        {
//            return 1;
//        }     
//    }
//}

//public class Program
//{
//    static void Main(string [] args)
//    {
//     //list
//        var sayilar = new List<int>() { 53, 40, 14, 2, 3, 12, 15 };
//     //yukarıdaki sayıları sort ile sıraladık
//        sayilar.Sort();
//        sayilar.ForEach(s => Console.WriteLine(s));

//     //sehir listesi
//     var sehirler =new List<Sehir>()
//        {
//            new Sehir(6, "Ankara"),
//            new Sehir(34, "İstanbul"),
//            new Sehir(55, "Samsun"),
//            new Sehir(23, "Elazığ"),
//            new Sehir(44, "Malatya"),
//        };
//        //ekleme
//        sehirler.Add(new Sehir(1, "Adana"));
//        //sıralama
//        sehirler.Sort();
//        sehirler.ForEach(s => Console.WriteLine(s));



//        Console.ReadKey();
//    }   
//}



//using System;
//using System.Collections.Generic;//genericsiz kütüphaneyi eklersek objelerle iş yapmış oluruz(kutulama kutudan çıkarma gerekir)ama generic yaparsak işimiz daha kolaylaşır kutulama gibi şeylere gerek kalmaz)
//using System.Threading.Tasks.Sources;

//class program1

////{
//    //STACK<T> STACK<T>             STACK<T>

//    //System.Collections.Generic sınıfı altında yer alır
//    //generic--> boxing/unboxin gerekmez
//    //T -->Type(tip)--> stack<int>, stack(string)
//    //Last-in First-out , liFo ----->SON GELEN İLK ÇIKAR

//    //push()   ---->YIĞINA EKLEME YAPMA
//    //pop()   ----->YIĞINDAN ÇIKARMA
//    //peek()  ---->İŞLEM GÖRECEK ELEMANI SEÇME(EN ÜSTTEKİ ELEMANI ALMA)
//    //clear()   ---->YIĞINI TEMİZLEMEK İÇİN KULLANILIR
//    //count()   -----> eleman sayısını alma
//    //ToArray    ----->YIĞINI BİR DİZİYE ÇEVİRMEK


//    //FONKSİYON ÇAĞRILARINDA KULLANILIR VE ÖZYİNELEMELİ(REKÜRSİT(DALLARI TOPLAMA))
//    //EN SON KULLANILAN UYGULAMALARIN LİSTESİNİ TUTMA
//    //SÖZ DİZİLİM HATALARINI YAKALAMADA
//    //GERİ İZLEME İŞLEMLERİNDE
//    //PARSİNG(AYRIŞTIRMA İŞLEMLERİ)
//    //TERST ÇEVİRME
//    //HAFIZA YÖNETİMİ
//    //TARYAICI SEKMELERİNDE KULLANILABİLİR


//    //ONDALIK BÜYÜKLÜĞÜ BULMA UYGULAMAASI STACK
//    static void Main(string[] args)
//    {
//        Console.WriteLine("üs alma programına hoşgeldin \nlütfen taban giriniz ");

//        double taban = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("lütfen üs giriniz ");
//        double üs = Convert.ToDouble(Console.ReadLine());
//        double sonuc=Math.Pow(taban,üs);
//        Console.WriteLine("İşleminizin sonucu= "+ sonuc);
//    }


//    private static void ONDALIKHESAPLAMA()
//    {
//        Console.WriteLine("Lütfen bir sayı giriniz");
//        int sayi = Convert.ToInt32(Console.ReadLine());

//        var sayiYigini = new Stack<int>();

//        while (sayi > 0)
//        {
//            int k = sayi % 10;
//            sayiYigini.Push(k);
//            sayi = sayi / 10;
//        }
//        int i = 0;
//        int n = sayiYigini.Count - 1;
//        foreach (var s in sayiYigini)
//        {
//            //MATH.POW İLE ÜS ALDIK (ÜSSÜ ALINACAK,ÜS) MESELA 5ÜZERİ 3 Ü(MATH.POW(5,3))ŞEKLİNDE YAZABİLİRİZ
//            Console.WriteLine($"\t {s,7} x " +
//             $"{Math.Pow(10, n - 1),7}\t = " +
//             $"{s * Math.Pow(10, n - i),7}");
//            i++;

//        }

//        Console.ReadKey();
//    }
//    private static void karakterYiginiOrnegi()
//    {
//        var karkterYigini = new Stack<char>();
//        for (int i = 65; i <= 90; i++)
//        {
//            karkterYigini.Push((char)i);
//            Console.WriteLine($"{karkterYigini.Peek()} yığına eklendi");
//            Console.WriteLine($"yığındaki eleman sayısı : {karkterYigini.Count}");
//        }
//        //ek bilgi
//        var dizi = karkterYigini.ToArray();
//        Console.WriteLine("yığından çıkarma işlemi için bir tuşa basınız.");
//        Console.ReadKey();

//        while (karkterYigini.Count > 0)
//        {
//            Console.WriteLine($"{karkterYigini.Pop()} yığından çıkarıldı.");
//            Console.WriteLine($"yığındaki eleman sayısı : {karkterYigini.Count}");

//        }
//        Console.ReadKey();
//    }
//    private static void YiginOrnegi()
//    {
//        //STACK TANIMLAMA 
//        var karakterYigini = new Stack<char>();

//        //EKLEME
//        karakterYigini.Push('A');
//        Console.WriteLine(karakterYigini.Peek());
//        karakterYigini.Push('B');
//        Console.WriteLine(karakterYigini.Peek());
//        karakterYigini.Push('C');
//        Console.WriteLine(karakterYigini.Peek());

//        //ÇIKARMA   
//        Console.WriteLine(karakterYigini.Pop() + "yığından çıkarıldı");
//        Console.WriteLine(karakterYigini.Pop() + "yığından çıkarıldı");
//        Console.WriteLine(karakterYigini.Pop() + "yığından çıkarıldı");


//        Console.ReadKey();
//    }


//}



//QUEUE<T> QUEUE<T> QUEUE<T> QUEUE<T> QUEUE<T>

//system collections generic sınıfı altında yer alır

//generic--(boxin ve unboxing e gerek kalmaz generic olduğu için)

//T -> Type ->Tıp

//first-ın first-out(FıFo) --->ilk gelen ilk çıkar sıra mantığı


// enqueu() --->eleman ekle
//dequeue() ---->çıkarma
//pekk() --->işlem görecek elemanı seçme
//count --->eleman sayısını verir
//clear()  --->temizleme


//*OS işletim sistemlerinde çalışma önceliğinin belirtilmesinde kullanılır.
//*ağ yazıcıları
//*mesaj kuyrukları(mesajların sıralı gitmesi)
//*Buffer(tampon) önbellek uygulamaları


////queue uygulaması 

//public class Program
//{
//    static void Main(string[] args)
//    {
//       var sesliHarfler =new List<char>()
//        {
//            'a','e','ı','i','u','ü','o','ö'
//        };
//        ConsoleKeyInfo secim;
//        var kuyruk =new Queue<char>();

//        foreach(char k in sesliHarfler)
//        {
//            Console.WriteLine();
//            Console.Write($"{k,5} kuyruğa eklensin mi? [E/H]");
//            secim =Console.ReadKey();
//            Console.WriteLine();
//            if(secim.Key == ConsoleKey.E)
//            {
//                kuyruk.Enqueue(k);
//                Console.WriteLine($"\n{k,-5} kuyruğa eklendi");
//                Console.WriteLine($"kuyruktaki eleman sayısı: {kuyruk.Count}");
//                Console.WriteLine();

//            }


//        }
//        Console.WriteLine();
//        Console.WriteLine("kuyruktaki elemanların kaldırılması için esc tuşuna basınız.");
//        secim = Console.ReadKey();
//        Console.WriteLine();

//        if(secim.Key== ConsoleKey.Escape)
//        {
//            Console.WriteLine();
//            while (kuyruk.Count > 0)
//            {

//                Console.WriteLine();
//                Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkartılıyor");
//                Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkartıldı.");
//                Console.WriteLine($"Kuyruktaki eleman sayısı : {kuyruk.Count}");
//            }
//            Console.WriteLine("\n kuyruktan çıkarma işlemi tamamlandı.");
//        }
//        Console.WriteLine("Program bitti.");
//        Console.ReadKey();


//    }

//    private static void kuyruktemelleriornegi()
//    {
//        //queue tanımlama 
//        var karakterkuyruğu = new Queue<char>();

//        //ekleme
//        karakterkuyruğu.Enqueue('a');
//        karakterkuyruğu.Enqueue('b');
//        Console.WriteLine($"Eleman sayısı: {karakterkuyruğu.Count}");

//        //diziye atama
//        var dizi = karakterkuyruğu.ToArray();

//        //çıkarma
//        Console.WriteLine($"Kuyruğun başındaki eleman: {karakterkuyruğu.Peek()}");
//        Console.WriteLine($"{karakterkuyruğu.Dequeue()} kuyruktan çıkartıldı.");
//        Console.WriteLine($"Eleman sayısı: {karakterkuyruğu.Count}");
//        Console.WriteLine($"Kuyruğun başındaki eleman: {karakterkuyruğu.Peek()}");
//    }
//}



//LinkedList<T>  LinkedList<T>  LinkedList<T>  LinkedList<T>    

// *system colllections generic sınıfına aittir

//generic --> boxing/unboxing yok ---->type safe var

//doğrusal veri yapısıdır

//public class Program
//{
//    static void Main(string[] args)
//    {
//        //LinkedList<T> temelleri
//        //tanımlama 
//        var sehirler =new LinkedList<string>();
//        sehirler.AddFirst("Ordu");
//        sehirler.AddFirst("Trabzon");
//        sehirler.AddLast("İstanbul");

//        sehirler.AddBefore(sehirler.Find("Ordu"),"Samsun");
//        sehirler.AddBefore(sehirler.First.Next.Next,"Giresun");
//        sehirler.AddAfter(sehirler.Last.Previous, "Sinop");
//        sehirler.AddAfter(sehirler.Find("Sinop"),"Zonguldak");

//        Console.WriteLine();
//        Console.WriteLine("Gidiş Güzergahı");
//        Console.WriteLine();
//        var eleman = sehirler.First;
//        while(eleman != null)
//        {
//            Console.WriteLine(eleman.Value);
//            eleman = eleman.Next;
//        }
//        Console.WriteLine();
//        Console.WriteLine("Dönüş Güzergahı");
//        Console.WriteLine();

//        var gecici = sehirler.Last;
//        while(gecici != null)
//        {
//            Console.WriteLine(gecici.Value);
//              gecici =gecici.Previous;
//        }
//        Console.ReadKey();
//    }
//}




//Dictionary  Dictionary  Dictionary  Dictionary<TKey,TValue>

//*sytem collections genric sınıfı altında yer alır.

//*generic --> boxing/unboxing yok --->type-safe

//*Tkey-tvalue pains
//*anahtar değer ait

//*tkey -> benzersiz olmak zorunda
//*tvalue ->istediğiniz değeri saklar

//*hastable ile kıyaslandığında daha performanslı çalışır.


//DİCTİONARY  DİCTİONARY  DİCTİONARY TEMELLERİ

//using System.Globalization;

//public class program
//{
//    static void Main(string[] args)
//    {
//        //DİCTİONARY
//        var telefonKodlari = new Dictionary<int, string>()
//        {
//            { 332, "Konya" },
//            { 424, "Elazığ" },
//            { 466, "Art" }
//        };

//        //ekleme (hem dictionary tanımlamada hemde ayrı olarak ekleme yapabiliriz)
//        telefonKodlari.Add(322, "Adana");
//        telefonKodlari.Add(212, "Elazığ");
//        telefonKodlari.Add(216, "İstanbul");

//        //erişme
//        //key'i vererek art yi artvin olarak değiştirdik
//        telefonKodlari[466] = "Artvin";

//        //ContainsKey (key ile yeni string ekledik)
//        if (!telefonKodlari.ContainsKey(312))
//        {
//            //\a ile uyarı sesi verdik, ! ile false yaptık
//            Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil!");
//            telefonKodlari.Add(312, "Ankara");
//            Console.WriteLine("yeni kod eklendi.");
//        }

//        // ContainsValue (string üzerinden kod ekledik)
//        if (!telefonKodlari.ContainsValue("Malatya"))
//        {
//            Console.WriteLine("\aMalatya'nın kod bilgisi tanımlı değildir");
//            telefonKodlari.Add(422, "Malatya");
//            Console.WriteLine("Yeni kod eklendi");
//        }

//        //kaldırma (adanayı kaldırdık keyini girerek)
//        telefonKodlari.Remove(322);


//        foreach (var s in telefonKodlari)
//        {
//            Console.WriteLine(s);
//        }

//       Console.ReadKey();
//    }

//}


//dictionary uygulaması


//public class Program
//{
//    static void Main(string[] args)
//    {
//        var personellistesi =new Dictionary<int,Personel>()
//        {
//            //BU ŞEKİLDE DE TANIMLAMA YAPABİLİRİZ VEYA ALTTAKİ GİBİ ADD YAZARAK DA EKLEME YAPABİLİRİZ
//            { 110, new Personel("Mehmet", "sonsoz", 7500) },
//            { 120, new Personel("Ahmet", "Kızkaban", 9000) }

//        };

//        personellistesi.Add(100, new Personel("Btl", "Büyükzengin", 5000));
//        foreach (var p in personellistesi)
//        {
//            Console.WriteLine(p);
//        }
//        Console.ReadKey();
//    }
//}


//SORTED DİCTİONARY <TKey,TValue>   SORTED DİCTİONARY <TKey,TValue>

//*System.Collections.Generic sınıfı altında tanımlıdır

//*Dictionary sınıfında kullanılan metotların tamamı bu koleksiton için de kullanılabilir

//*Tkey -Tvalue pairs----GÖRE
//ANAHTAR -DEĞER ÇİFTİ----ÇALIŞIR

//*EKLEME ADIMINDA SIRALAMA İŞLEMİ DE YAPILDIĞINDA BİR BİKTAR PERFORMANS KAYBI GÖZLEMLENBİLİR

//*SIRALAMA İŞLEMİ TKEY İFADESİNE GÖRE YAPILIR.


//SORTED DİCTİONARY UYGULAMASI
//adobe pdf deki gibi arama yerine bir kelime yazdığımızda o kelimenin hangi sayfada olduğunu söyleyen uygulama


//using System.Threading.Channels;

//public class Program
//{
//    static void Main(string[] args)
//    {
//        //TANIMLAMA
//        var kitapIndeks =
//            new SortedDictionary<string, List<int>>()
//        {
//            //EKLEME
//            { "HTML",new List<int>() {8,10,12} },
//            { "CSS",new List<int>() {70,80,90} },
//            { "JQUERY",new List<int>() {3,5,15} },
//            { "SQL",new List<int>() {70,80} },
//            { "FTP",new List<int>() {3,5,7} },
//            { "ASP.NET",new List<int>() {50,60} },
//        };
//        foreach (var kavram in kitapIndeks)
//        {
//            Console.WriteLine(kavram.Key);
//            //2. YAZDIRMA YOLU
//            //kavram.Value.ForEach(s => Console.WriteLine($"\t > "+s));
//            foreach (int say in kavram.Value)
//            {
//                Console.WriteLine($"\t > {say,-5} pp");
//            }
//        }
//      Console.ReadKey();

//    }
//}


//SORTEDSET <T>  SORTEDSET <T>  SORTEDSET <T>   

//*System.Collections.generic sınıfı altında yer alır.

//*generic -> t ->tip-> boxing-unboxing yok->type-safe

//elemanları benzersiz olmalı

//sıralı->sıralama ekleme sırasında yapılır

//  Add()-> ekleme ->bool
//  Remove ->silme
//Remove Where(Predicate(koşul-> lambda)) ->koşulla kaldırma


//dinamik

//kesişim,birleşim,ayrışım,altterimler...

//a kümesi elemanları ->3,4,1,2
//b kümesi elemanları ->1,2,5,6

//                   çıktı
//A.UnionWith(B)->{1,2,3,4,5,6}
//A.IntersectWith(B)->{1,2}
//A.exceptWith(B)->{3,4}
//A.synetricExceptWith(B)->{3,4,5,6}


//SortedSet tanımlama

//public class Program
//{
//    static void Main(string[] args)
//    {
//        //SortedSet
//        var sayilar = new List<int>();
//        var r = new Random();

//        Console.WriteLine();
//        for (int i = 0; i < 100; i++)
//        {
//            sayilar.Add(r.Next(0, 10));
//            Console.Write($"{sayilar[i],-3}");
//        }

//        Console.WriteLine();

//        //listedeki benzersiz elemanları bulma
//        var benzersizSayiListesi = 
//            new SortedSet<int>(sayilar);

//        Console.WriteLine();
//        Console.WriteLine("\nBenzersiz sayilar listesi \n");
//        foreach (int sayi in benzersizSayiListesi)
//        {
//            Console.Write($"{sayi,-3}");
//        }
//        Console.WriteLine("Benzersiz {0} sayı var: ",benzersizSayiListesi.Count);

//        Console.ReadKey();

//    }

//    private static void SortedSetUygulaması()
//    {

//        //SortedSet
//        //tanımlama
//        var list = new SortedSet<string>();

//        //ekleme
//        if (list.Add("Messi"))
//        {
//            Console.WriteLine("Messi eklendi");
//        }
//        else
//        {
//            Console.WriteLine("Ekleme başarısız");
//        }

//        Console.WriteLine("{0}",
//            list.Add("Ronaldo") == true ?
//            "Ronaldo eklendi." : "ekleme başarısız."
//          );

//        list.Add("Romario");
//        list.Add("Rummenigge");
//        list.Add("Musiala");
//        list.Add("Zico");
//        //kaldırma için remove

//        list.Remove("");
//        //İçinde büyük f harfi geçen isimleri siliyor

//        list.RemoveWhere(deger => deger.StartsWith("F"));

//        Console.WriteLine("\nEn iyi futbolcular \n");
//        foreach (string i in list)
//        {
//            Console.WriteLine(i);
//        }

//        Console.WriteLine("Eleman sayısı   :{0,3}", list.Count);


//        Console.ReadKey();
//    }
//}


//public class Program
//{
//    static void Main(string[] args)
//    {

//        // sortedSet küme işlemleri

//         var A = new SortedSet<int>() { 1, 2, 3, 4 };
//       //unionda kullandık var A =new SortedSet<int>(rastgelesayıüret(100));
//         var B = new SortedSet<int>() { 1, 2, 5, 6 };
//        //unionda kullandık var B = new SortedSet<int>(rastgelesayıüret(100));
//        #region Yazdırma
//        Console.WriteLine();
//        Console.WriteLine("A kümesi");
//        foreach (int s in A)
//        {
//            Console.Write($"{s,5}");
//        }
//        Console.WriteLine();


//        Console.WriteLine();
//        Console.WriteLine("B kümesi");
//        foreach (int s in B)
//        {
//            Console.Write($"{s,5}");
//        }
//        Console.WriteLine();
//        #endregion


//        //Union (birlerşim)

//        A.UnionWith(B);
//        Console.WriteLine();
//        Console.WriteLine("\n\nA ve B kümesinin Birleşimi");
//        foreach (int s in A)
//        {
//            Console.Write($"{s,5}");
//        }
//        Console.WriteLine();
//        Console.WriteLine("\n toplam sayisi : {0}", A.Count);



//        Console.WriteLine();
//        Console.ReadKey();

//        //IntersectWith(kesişim)
//        //A.Exceptwith(B) diyerek sadece sonucu A nın elemanları yapabilriiz(A da olup b de olmayanların sayısı)
//        //A.SymmetricExceptWith(B) ile kesişim dışındaki elemanları yazdırır
//        //A.IsSubsetOf(B) diyerek A B'nin alt kümesimi sorusu sorulabilir
//        A.IntersectWith(B);
//        Console.WriteLine();
//        Console.WriteLine("\n\nA ve B kümesinin Kesişimi");
//        foreach (int s in A)
//        {
//            Console.Write($"{s,5}");
//        }

//        Console.WriteLine();
//        Console.WriteLine("\n toplam sayisi : {0}", A.Count);



//        Console.WriteLine();
//        Console.ReadKey();






//    }
//    static List<int> rastgelesayıüret(int n)
//    {
//        var list = new List<int>();
//        var r = new Random();
//        for (int i = 0; i < n; i++)
//            list.Add(r.Next(0, 1000));
//        return list;



//    }


//}

using System.Collections;

public class Program
{
    //HashSet<T>
    //HashSet<T>
    //HashSet<T> 

    //*system.Collecitons.Generic sınıfı altında yer alır
    //*generictir => boxing unboxing herek yoktur =>type-safe 
    //*eleman benzersizdir
    //***sıralama yok*** sorted setten farkı
    //küme işlemlerine izin verir
static void Main(string[] args)
    {
        //HASHSET
        //tanımlama
        var sesliharf =new HashSet<char>()
        {
            'e','ı','i','u','ü','o','ö','b',          
        };

        KoleksiyonYazdir(sesliharf);
        //ekleme 
        sesliharf.Add('a');
        KoleksiyonYazdir(sesliharf);

        //listeden çıkaarma
        sesliharf.Remove('b');
       
        KoleksiyonYazdir(sesliharf);
        var alfabe = new List<char>();
        
        //97 den 123  yazmamızım nedeni ascıı diye bir yerden 97 123 arası a dan z ye olduğunu öğrenip yazdık
        for (int i = 97; i < 123; i++)
            alfabe.Add((char)i);
        KoleksiyonYazdir(alfabe);
      
        //türkçede kullanılan sesli harfler
        //  sesliharf.ExceptWith(alfabe);
       // sesliharf.UnionWith(alfabe);
       //sesliharf.IntersectWith(alfabe);
       sesliharf.SymmetricExceptWith(alfabe);
        KoleksiyonYazdir(sesliharf);
        Console.ReadKey();
    }
    static void KoleksiyonYazdir(IEnumerable koleksiyon)
    {
        
        Console.WriteLine();
        int i = 0;
        foreach (char k in koleksiyon)
        {
            Console.Write($"{k,5}");
            i++;
        }
        Console.WriteLine();
        Console.WriteLine("eleman sayısı : {0}",i);

        Console.WriteLine();
        //Console.WriteLine("eleman sayisi : {0}", koleksiyon.Count);

    }


}























