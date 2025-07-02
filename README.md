📌 Proje Raporu
Bu proje, Mars yüzeyinde hareket eden iki gezginin (Rover) verilen komutlara göre nasıl ilerlediğini simüle eden bir C# console uygulamasıdır. Uygulama, kullanıcıdan yüzey boyutlarını, gezginlerin başlangıç konumlarını ve hareket komutlarını alarak her gezginin son konumunu hesaplar ve ekrana yazdırır.
Uygulama, nesne yönelimli programlama (OOP) ilkelerine uygun olarak tasarlanmıştır.



🔧 Kullanılan Teknolojiler
.NET 8  
C#	Programlama dili (OOP desteği ile)
Console App 
OOP (Object-Oriented Programming)	 


⚙️ Kullanılan OOP Prensipleri
Encapsulation (Kapsülleme): Rover ve Plateau sınıfları kendi alanlarını dışarıya kapatır, işlemleri metodlarla yönetir.
Single Responsibility: Her sınıf sadece kendi göreviyle ilgilenir.
Readability & Reusability: Kod okunabilir, modüler ve başka ortamlarda kolayca kullanılabilir.

 
📥 Girdi Formatı
5 5              // Yüzey boyutu (MaxX MaxY)
1 2 N            // 1. gezgin başlangıç konumu
LMLMLMLMM        // 1. gezgin komutları
3 3 E            // 2. gezgin başlangıç konumu
MMRMMRMRRM       // 2. gezgin komutları


📤 Örnek Çıktı
1 3 N
5 1 E
