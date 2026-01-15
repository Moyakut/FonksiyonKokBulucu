using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

public class FonksiyonKokBulucu
{
    static float number;
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //Δ, ² gibi terimlerin konsolda görünmesi için encoder'ı değişiyoruz.
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Fonksiyon Kök Bulucu'ya Hoşgeldiniz!");
        Thread.Sleep(780);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("---------------------------------------");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("'ax² + bx + c' cinsindeki fonksiyonun :");
        Console.ForegroundColor = ConsoleColor.Yellow; 
        Console.WriteLine("---------------------------------------");

        Thread.Sleep(900);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("a değerini giriniz.");
        CheckNumber();
        float a = number;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"a değeri {a} olarak belirlendi!");  
        Console.ForegroundColor = ConsoleColor.Yellow;      
        Console.WriteLine("---------------------------------------");
        
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("b değerini giriniz.");
        CheckNumber();
        float b = number;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"b değeri {b} olarak belirlendi!");
        Console.ForegroundColor = ConsoleColor.Yellow;      
        Console.WriteLine("---------------------------------------");
        
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("c değerini giriniz.");
        CheckNumber();
        float c = number;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"c değeri {c} olarak belirlendi!");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("---------------------------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Fonksion hesaplanıyor...");
        Thread.Sleep(1000); //bir süre delay (Görsel amaçlıdır.)
        
        string func = BuildFunction(a, b, c);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Fonksiyon '{func}' olarak tanımlandı!");

        Thread.Sleep(1000);
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Δ(Diskriminant) = b² - 4ac Hesaplanıyor...");
        float delta = (b * b) - (4 * a * c); //Diskriminant formülünün uygulaması
        
        Thread.Sleep(1000);
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Δ = {delta} olarak hesaplandı!");
        
        Thread.Sleep(1000);
        
        if (delta > 0)
        {
            Console.WriteLine("Fonksiyonun iki reel kökü var! (Δ > 0)");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Fonksiyonun kökleri hesaplanıyor!");
            Thread.Sleep(1000);
            float root1 = CalculateRoots(delta, a, b, false);
            string root1Str = root1.ToString("0.00");
            float root2 = CalculateRoots(delta, a, b, true);
            string root2Str = root2.ToString("0.00");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Fomksioynun kökleri yaklaşık {root1Str} | {root2Str} olarak hesaplandı!");
        }
        else if (delta < 0)
        {
           Console.WriteLine("Fonksiyonun reel kökü yok! (Δ < 0)"); 
        }
        else if (delta == 0)
        {
            Console.WriteLine("Fonksiyonun bir tane çift kat kökü var! (Δ = 0)");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Fonksiyonun kökü hesaplanıyor!");
            Thread.Sleep(1000);
            float root = CalculateRoots(delta, a, b, false);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Fomksioynun çift katlı kökü {root} olarak hesaplandı!");
        }

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("");
        Console.WriteLine("Uygulama sonlandı kapatmak için herhangi bir tuşa basınız....");
        Console.Read();
    }

    private static float CalculateRoots(float discriminant, float a, float b, bool minus)
    {
        float root = 0;
        if (minus)
        {
            root = (-b - (float)Math.Sqrt(discriminant)) / 2*a; //kök formülünün eksili hali
        }
        else
        {
            root = (-b + (float)Math.Sqrt(discriminant)) / 2*a; //kök formülünün artılı hali
        }
        return root;
    }

    private static string BuildFunction(float a, float b, float c)
    {
        string func;

        string virtualA = ""; //a değişkeninin görüntüsü
        string virtualB = ""; //b değişkeninin görüntüsü
        string virtualC = ""; //c değişkeninin görüntüsü

        string isaretB = ""; //b'nin işareti
        string isaretC = ""; //c'nin işareti

        //gerekli atamalar
        if (a == 0)
        {
            virtualA = "";
        }
        else if (a == 1)
        {
            virtualA = "x² ";
        }
        else
        {
            virtualA = $"{a}x² ";
        }


        if (b == 0)
        {
            virtualB = "";
        }
        else if (b == 1)
        {
            virtualB = " x ";
        }
        else
        {
            virtualB = $" {Math.Abs(b)}x ";
        }


        if (c == 0)
        {
            virtualC = "";
        }
        else
        {
            virtualC = $" {Math.Abs(c)}";
        }

        if (b > 0)
        {
            isaretB = "+";
        }
        else if (b < 0)
        {
            isaretB = "-";
        }

        if (c > 0)
        {
            isaretC = "+";
        }
        else if (c < 0)
        {
            isaretC = "-";
        }

        func = virtualA + isaretB + virtualB + isaretC + virtualC;

        return func;
    }

    //Bu fonksiyonda girilen input'un bir sayı olup olmadığını kontrol ediyoruz.
    private static void CheckNumber()
    {
        string? input;//Konsoldaki girdinin alınması.

        do
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                if (isNumber(input))
                {
                    number = float.Parse(input); //number değişkenini girilen sayıya eşitliyoruz.
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("HATA! lütfen bir sayı giriniz!", ConsoleColor.Red); //Eğer sayı girilmezse bu yazılacak.
                }
            }
        }
        while (string.IsNullOrEmpty(input) || !isNumber(input));
    }

    //Bu fonksiyon konsola girilen input'un sayı olup olmadığını kontrol eder.
    public static bool isNumber(string str)
    {
        if (string.IsNullOrEmpty(str)) {return false;} //str değişkeni null veya boş ise direkt false değeri döndürür.
        
        bool isNum = int.TryParse(str, out int i); //str değişkeninin int değerine dönüştürülüp dönüştürülmeyeceği kontrol edilir.
        
        return isNum; //Final return işlemi.
    }
}