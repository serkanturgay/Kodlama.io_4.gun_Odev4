using System;
using System.Collections.Generic;

namespace Kodlama.io_4.gun_Odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary < int,string> Kitap = new Dictionary <int, string> ();
            Kitap.Add(01, "Leylan");
            Kitap.Add(02, "Devran");
            Kitap.Add(03, "Seher");
            Kitap.Add(04, "Ruhun Gökkuşağı");
            Kitap.Add(05, "Bir Dil Yaratmak");
            Kitap.Add(06, "Nar Çiçekleri");
            Kitap.Add(07, "Zincirlenmiş Zamanlar Zincirlenmiş Sözcükler");
            Kitap.Add(08, "Dicle'nin Sesi I");
            Kitap.Add(09, "Küllerinden Doğan Dil ve Roman");
            Kitap.Add(10, "kürk mantolu madonna");

            Console.WriteLine("Kitap No Giriniz;");
            int No = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(Kitap[No] + "   Kitap Bulundu.");
            }
            catch (Exception)
            {
                Console.WriteLine("Kitap Bulunamadı.");
                
            }

        }
    }
}
