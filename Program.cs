namespace bilgiyarismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title= "bilgiyarismasi Yarışması";
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("(: ...Bilgi Yarışmasına Hoşgeldiniz... :)");
            string ad, soyad;
            Console.Write("Lütfen Adınızı Girin:");
            ad = Console.ReadLine();
            Console.Write("Lütfen Soyadınızı Girin:");
            soyad = Console.ReadLine();
            Console.WriteLine("Başlıyoruz....  >>>>>>  İlerlemek için Enter tuşuna basınız..");
            Console.WriteLine("Her Yanıttan Sonra Enter Tuşuna Basmayı Unutmayınız (Enter Tuşu Burada İlerlemek Anlamına Geliyor Sizin İçin)");
            Console.ReadLine();

            int d, y, para;
             d = 0;
             y = 0;
            para = 0;

            //SORU 1
            Console.WriteLine("1- Cumhuriyet Kaç Yılındı İlan Edildi ?");
            string c1;           
            Console.Write("A) 1920\nB) 1921\nC) 1923\nD) 1929\nCevabınız: ");
            c1 = Console.ReadLine();
            if (c1 == "C" || c1 == "c")
            {
                d = d + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevabı Verdiniz. >Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            else
            {
                y = y + 1;
                Console.WriteLine("Üzgünüm Yanlış Cevabı Verdiniz.>Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            

            
            string c2;
            //soru 2
            Console.WriteLine("Türkiyenin Başkenti Neresidir ?");
            Console.Write("A) Bursa\nB) Denizli\nC) Isparta\nD) Ankara\nCevabınız: ");
            c2 = Console.ReadLine();
            if (c2 == "D" || c2== "d")
            {
                d = d + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevabı Verdiniz. >Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            else
            {
                y = y + 1;
                Console.WriteLine("Üzgünüm Yanlış Cevabı Verdiniz.>Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            
            string c3;
            //soru 3
            Console.WriteLine("Maki Hangi Bölgenin Bitki Örtüsüdür ?");
            Console.Write("A) Akdeniz\nB) Ege\nC) Marmara\nD) Karadeniz\nCevabınız: ");
            c3 = Console.ReadLine();
            if (c3 == "A" || c3 == "a")
            {
                d = d + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevabı Verdiniz. >Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            else
            {
                y = y + 1;
                Console.WriteLine("Üzgünüm Yanlış Cevabı Verdiniz.>Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }

            string c4;
            //soru 4
            Console.WriteLine("Hangisi İstanbulda Bulunan Bir Semt Değildir ?");
            Console.Write("A) Üsküdar\nB) Urla\nC) Sarıyer\nD) Kartal\nCevabınız: ");
            c4 = Console.ReadLine();
            if (c4 == "B" || c4 == "b")
            {
                d = d + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevabı Verdiniz. >Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            else
            {
                y = y + 1;
                Console.WriteLine("Üzgünüm Yanlış Cevabı Verdiniz.>Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }

            string c5;
            //soru 5
            Console.WriteLine("Hangisi Programlamanın Temel Renklerinden Değildir ?");
            Console.Write("A) Mavi\nB) Yeşil\nC) Kırmızı\nD) Sarı\nCevabınız: ");
            c5 = Console.ReadLine();
            if (c5 == "D" || c5 == "d")
            {
                d = d + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevabı Verdiniz. >Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            else
            {
                y = y + 1;
                Console.WriteLine("Üzgünüm Yanlış Cevabı Verdiniz.>Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }

            string c6;
            //soru 6
            Console.WriteLine("Avrupanın Kullandığı Ortak Para Birimi Aşağıdakilerden Hangisidir ?");
            Console.Write("A) Dolar\nB) Euro\nC) Zloty\nD) Türk lirası\nCevabınız: ");
            c6 = Console.ReadLine();
            if (c6 == "B" || c6 == "b")
            {
                d = d + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevabı Verdiniz. >Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            else
            {
                y = y + 1;
                Console.WriteLine("Üzgünüm Yanlış Cevabı Verdiniz.>Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }

            string c7;
            //soru 7
            Console.WriteLine("Hangi İlimiz Ege Bölgemizde Değildir ?");
            Console.Write("A) İzmir\nB) Muğla\nC) Edirne\nD) Aydın\nCevabınız: ");
            c7 = Console.ReadLine();
            if (c7 == "C" || c7 == "c")
            {
                d = d + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevabı Verdiniz. >Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            else
            {
                y = y + 1;
                Console.WriteLine("Üzgünüm Yanlış Cevabı Verdiniz.>Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }

            string c8;
            //soru 8
            Console.WriteLine("Sefiller Kitabının Yazarı Kimdir ?");
            Console.Write("A) Jules Verne\nB) Gogol\nC) Tolstoy\nD) Victor Hugo\nCevabınız: ");
            c8 = Console.ReadLine();
            if (c8 == "D" || c8 == "d")
            {
                d = d + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevabı Verdiniz. >Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            else
            {
                y = y + 1;
                Console.WriteLine("Üzgünüm Yanlış Cevabı Verdiniz.>Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }

            string c9;
            //soru 9
            Console.WriteLine("Mustafa Kemal Atatürk'ün Nüfusa Kayıtlı Olduğu İl Aşağıdakilerden Hangisidir ?");
            Console.Write("A) İstanbul\nB) İzmir\nC) Ankara\nD) Gaziantep\nCevabınız: ");
            c9 = Console.ReadLine();
            if (c9 == "D" || c9 == "d")
            {
                d = d + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevabı Verdiniz. >Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            else
            {
                y = y + 1;
                Console.WriteLine("Üzgünüm Yanlış Cevabı Verdiniz.>Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }

            string c10;
            //soru 10
            Console.WriteLine("İstiklal Marşı Şairimiz Kimdir ?");
            Console.Write("A) Ziya Gökalp\nB) Mehmet Akif Ersoy\nC) Orhan Veli\nD) Reşat Nuri Güntekin\nCevabınız: ");
            c10 = Console.ReadLine();
            if (c10 == "B" || c10 == "b")
            {
                d = d + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevabı Verdiniz. >Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            else
            {
                y = y + 1;
                Console.WriteLine("Üzgünüm Yanlış Cevabı Verdiniz.>Enter Tuşu İle İlerleyiniz<");
                Console.ReadLine();
            }
            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("Doğru Sayısı: " + d);
            Console.WriteLine("Yanlış Sayısı: " + y);
            Console.WriteLine("Kazandığınız Para: " + para);
            Console.WriteLine("Oyun Bitti Teşekkür Ederim Katıldığınız İçin... <3");
            Console.ReadLine();
        }
    }
}