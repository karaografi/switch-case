﻿internal class Program
{
    private static void Main(string[] args)
    {
        int month = DateTime.Now.Month;


        //Expression Kontrol Edilecek alan
        switch (month)
        {
            case 1:
                Console.WriteLine("Ocak Ayındayız");
                break;
            case 2:
                Console.WriteLine("Şubat Ayındayız");
                break;
            case 3:
                Console.WriteLine("Mart Ayındayız");
                break;
            case 4:
                Console.WriteLine("Nisan Ayındayız");
                break;
            case 5:
                Console.WriteLine("Mayıs Ayındayız");
                break;
            default:
                Console.WriteLine("Yanlış Veri Girişi");
                break;
        }

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış ayındayız");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahar Ayındayız");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz Ayındayız");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar Ayındayız");
                break;
            default:
            break;
        }
    }
}