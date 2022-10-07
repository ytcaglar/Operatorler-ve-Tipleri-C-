using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Atama ve işlemli atama ****");

            // Atama ve işlemli atama
            int x = 3;
            int y = 2;

            y = y+2; // y sayısına 2 ekle demek
            Console.WriteLine(y); // 4 olur

            y += 2;  // y sayısına 2 ekle demek
            Console.WriteLine(y); // 6 olur

            y/=1; // y = y/x anlamına gelir.            
            Console.WriteLine(y); // y = y/1 = 6
            
            x*=2; // x sayısını 2 ile çarp demek. x = x*2 
            Console.WriteLine(x); 

            // Mantıksal operatörler
            // (|| (veya) , && (ve))

            // Yukarıda belirtilen değerler aslında normalde koşul sonrası 
            // doğru ya da yanlış cevabı bize geri döndürür.
            // 1- ör. üç integer sayı tanımlayalım 

            int a = 8;
            int b = 2;
            int c = 4;

            // İki koşul ifadesi yazalım ve bu koşul ifadelerini birer bool değer tanımlayarak ona atayalım.

            bool deger1 = (a/b == 4) ; // Bu ifade aslında bir soru ifadesidir. 
                                    // Çünkü "==" çift eşitttir işaretinin anlamı, 
                                    // "çift eşittirin iki tarafında ki değer birbirine eşit mi?" diye sorar.
                                    // Bu ifadede a = 8 ve b = 2 olduğundan a/b = 8/2 = 4 değerini verir.
                                    // İfadenin verdiği 4 == 4 olmuş olur. Yani 4 değeri 4 değerine eşit mi ? diye sorar.
                                    // Bu ifade eşit yani doğru olmasından dolayı bu koşul ifadesi bize true değer verir.
                                    // Yani mantıken bool deger = true; olmuş oldu.     

            
            bool deger2 = (a/c == 4) ; // Bu ifadeyi de kısaca özetlersek a/c = 8/4 = 2 olur.
                                     // Bu sefer 2 == 4 yani 2 değeri 4 değerine sayısal olarak eşit mi ?
                                     // Cevap hayır olduğundan bize bu ifade false değer döndürür.
                                     // Yani mantıken bool deger2 = false; olmuş oldu.


            Console.WriteLine("**** Mantıksal İfadeler ****");
            // Şimdi mantıksal ifadelere gelirsek,

            // && = ve , || = veya anlamına gelir. 
            
            // && "Ve" "And" Mantıksal Operatörüne Bakacak Olursak:
            //
            // ("kosul1" ve "koşul2") olsun. Burada "ve" operatörü demek ne kadar koşul 
            // varsa hepsinin sağladığı takdirde olumlu yani True değer verir.
            // Buraya bakacak olursak iki koşul var. (Bunlar koşul1 ve koşul2)
            // Eğer biz burada "ve" operatörü kullanacak olursak buradaki iki koşulunda sağlıyor 
            // ise "ve" mantıksal operatörü bize true değer verir.
            // Yani iki koşulda true ise mantıksal operatörünün koşulunu sağlıyor anlamına gelir.
            // Yani koşul1 true ve koşul 2 true ise, "ve" mantıksal operatörü true değer verecektir.
            // Aksi takdirde iki koşuldan biri false olursa koşullar sağlanmaz ve 
            // "ve" mantıksal operatörü false değer verir.
            // Yukarıdaki ("kosul1" ve "koşul2")  ifadesi => ("kosul1" && "koşul2") şeklinde gösterilir.
            // "ve" ingilizce adı "and" olarak kullanılır.

            // && (ve) Operatörünü Daha iyi anlamak için örnek verecek olursak,
            // 
            // 1- koşul1=true, koşul2=true      =>  ("kosul1" && "koşul2") => (true && true)    => true değer verir.
            // 2- koşul1=false, koşul2=true     =>  ("kosul1" && "koşul2") => (false && true)   => false değer verir.
            // 3- koşul1=true, koşul2=false     =>  ("kosul1" && "koşul2") => (true && false)   => false değer verir.
            // 4- koşul1=false, koşul2=false    =>  ("kosul1" && "koşul2") => (false && false)  => false değer verir.

            // Buradan şunu diyebiliriz "ve" mantıksal operatörü false değer sever. 
            // Eğer 1 tane false değer varsa "ve" mantıksal operatörü false değer döndürür yani false verir.

            // || "Veya" "Or" Mantıksal Operatörüne Bakacak Olursak:
            //
            // ("kosul1" veya "koşul2") olsun. Burada "veya" operatörü demek iki koşuldan biri
            // doğru yani iki koşuldan biri true ise "veya" mantıksal operatörü true değeri verir.
            // Yani ikiden fazla koşul dahi olsa biri sağlanıyorsa, "veya" mantıksal operatörü true değer verir.
            // Fakat hiçbir koşul true yani hiçbir koşul sağlanmıyorsa, "veya" mantıksal operatörü false değer verir.
            // Yukarıdaki ("kosul1" veya "koşul2")  ifadesi => ("kosul1" || "koşul2") şeklinde gösterilir.
            // "veya" ingilizce adı "or" olarak kullanılır.

            
            // || (veya) Operatörünü Daha iyi anlamak için örnek verecek olursak,
            // 
            // 1- koşul1=true, koşul2=true      =>  ("kosul1" || "koşul2") => (true || true)    => true değer verir.
            // 2- koşul1=false, koşul2=true     =>  ("kosul1" || "koşul2") => (false || true)   => true değer verir.
            // 3- koşul1=true, koşul2=false     =>  ("kosul1" || "koşul2") => (true || false)   => true değer verir.
            // 4- koşul1=false, koşul2=false    =>  ("kosul1" || "koşul2") => (false || false)  => false değer verir.

            // Buradan şunu diyebiliriz "veya" mantıksal operatörü true değer sever. 
            // Eğer 1 tane true değer varsa "veya" mantıksal operatörü true değer döndürür yani true değer verir.

            // if değerleri için koşul verilir. Eğer koşul sağlarsa true sağlamazsa false verir.

            // Yukarıda belirtilen deger1 ve deger2 koşul ifadesini kullanara,k 
            // "ve" ve "veya" mantıksal operatörlerini kullanacak olursak,

            // deger1 = true ve deger2 = false olarak yukarıda belirlemiştik.

            bool veKosulu = deger1 && deger2; // true && false => false
            Console.WriteLine(veKosulu);

            bool veyaKosulu = deger1 || deger2; // true || false => true
            Console.WriteLine(veyaKosulu);
            
            Console.WriteLine("**** Eğer Operatörü ****");


            // If Operatörü - Eğer Operatörü

            // Eğer koşulu sağlıyorsa içindeki kodu çalıştır demektir. 
            // if(kosul){içindeki kod} yani buraya bakacak olursak, 
            // eğer koşul true ise içindeki kodu çalıştır anlamına gelir. 
            // Kısacası KOŞUL sağlanırsa içindeki kodu çalıştır demek.

            bool isSuccess = true; // Bool değerdir. Bu pozitif bir değer olarak düşünebilirsiniz.
            bool isCompleted = false; // Bool değerdir. Bu negatif bir değer düşünün... Detaylı Bahsedicem.

            if(isSuccess) // Burada koşul true olduğundan dolayı alttaki kod çalışır.
            {
               Console.WriteLine(" isSuccess True değerdir."); // Çalışır.
            }
            
            if(isCompleted) // Burada koşul false olduğundan dolayı alttaki kod çalışmaz.
            {
               Console.WriteLine("isCompleted True değerdir."); // Çalışmaz.
            }

            if(isCompleted && isSuccess) // isCompleted && isSuccess = false && true => false olur.
            {
               Console.WriteLine("isCompleted && isSuccess True değerdir."); // Çalışmaz.
            }

            if(isCompleted || isSuccess) // isCompleted || isSuccess = false || true => true olur.
            {
               Console.WriteLine("isCompleted || isSuccess True değerdir."); // Çalışır.
            }

            bool isGreaterThan = 5<10; // True verir.


            Console.WriteLine("**** İlişkisel Operatörler (==,!=, <, >, >=,<=) ****");
            
            //İlişkisel Operatörler (==,!=, <, >, >=,<=)

            // Bu ilişkisel operatörlerde yukarıda anlattığım 
            // eşit mi ? (==), eşit değil mi ? (!=) ,büyük mü ? (>), büyük veya eşit mi ? (>=),
            // küçük mü? (<), küçük veya eşit mi ? (<=) diye iki elemanı 
            // karşılaştırır ve true yada false değer döndürür

            int t = 8;
            int k = 2;
            int z = 2;

            bool kosul1 = t<k;   // t<k = 8<2 yanlış olduğundan false değer verir.
            Console.WriteLine("Kosul1 : "+kosul1);

            bool kosul2 = t<=k;  // t<=k = 8<=2 yanlış olduğundan false değer verir.
            Console.WriteLine("Kosul2 : "+kosul2);

            bool kosul3 = t>k;   // t>k = 8>2 doğru olduğundan true değer verir.
            Console.WriteLine("Kosul3 : "+kosul3);

            bool kosul4 = t>=k;  // t>=k = 8>=2 doğru olduğundan true değer verir.
            Console.WriteLine("Kosul4 : "+kosul4);

            bool kosul5 = z!=k;   // z!=k = z!=k eşit olduğundan yanlış olur ve false değer verir.
            Console.WriteLine("Kosul5 : "+kosul5);

            bool kosul6 = z==k;  // z==k = z==k eşit ve doğru olduğundan true değer verir.
            Console.WriteLine("Kosul6 : "+kosul6);


            Console.WriteLine("**** Aritmatik Operatörler (+, -, /, *, %) ****");

            // **** Aritmatik Operatörler (+, -, /, *, %) ****
            // + toplama - çıkarma / bölme * çarpma % mod almadır.
            // Mod aslında bir sayının bir sayıya bölümünden kalan sayı modun sonucudur.
            // ör. 8%5 bu aslında 8/5 yaparsak 1 tam 3 kalanı olur.
            Console.WriteLine(8%5); // kalan 3 oldu aslında mod demek 
                                    // bölüm sonrası kalanı bulmak anlamına gelir.

            int sayi1 = 4;
            int sayi2 = 2;
            int sonuc;
            
            Console.WriteLine("sayi1 = " + sayi1 + " sayi2 = " + sayi2); // Değerlerini göstermek için yazdırdım.

            sonuc = sayi1 + sayi2;
            Console.WriteLine("sayi1 + sayi2 = " + sonuc); // Toplama sonucu

            sonuc = sayi1 - sayi2;
            Console.WriteLine("sayi1 - sayi2 = " + sonuc); // Çıkarma sonucu

            sonuc = sayi1 * sayi2;
            Console.WriteLine("sayi1 * sayi2 = " + sonuc); // Çarpma sonucu

            sonuc = sayi1 / sayi2;
            Console.WriteLine("sayi1 / sayi2 = " + sonuc); // Bölme sonucu




            

            Console.ReadLine();
        }
    }
}
