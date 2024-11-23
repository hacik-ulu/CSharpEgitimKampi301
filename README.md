# 👨‍💻 C# EĞİTİM KAMPI İSTATİSTİK FORMU PROJESİ

Bu uygulama, Entity Framework (EF) kullanarak geliştirilmiş ve Database First yaklaşımıyla yapılandırılmıştır. Database First yaklaşımında, veritabanı önceden oluşturulmuş ve Entity Framework bu veritabanına dayanarak model sınıflarını otomatik olarak oluşturmuştur. 
Bu sayede veritabanı yapısıyla doğrudan etkileşim sağlanır ve uygulama geliştirme süreci hızlandırılır.Uygulama, veritabanındaki TblLocation ve TblGuide tablolarından veriler alarak çeşitli istatistiksel analizler yapar. 
Bu veriler, LINQ (Language Integrated Query) kullanılarak sorgulanır. LINQ, C# diline entegre edilmiş bir sorgulama dilidir ve veritabanı sorgularını daha okunabilir ve bakımı kolay hale getirir. Uygulama, kullanıcıya çeşitli turistik bilgiler sunmak için aşağıdaki işlemleri gerçekleştirir:

### 📍En Son Eklenen Ülke: Veritabanındaki en yüksek LocationId değerine sahip olan lokasyonun ülke adı.
### 📍Roma Rehberi: Roma şehrindeki rehberin adı.
### 📍En Yüksek Kapasiteli Tur: Kapasite bakımından en yüksek değere sahip lokasyon.
### 📍En Pahalı Tur: Fiyat açısından en yüksek değeri taşıyan tur.
### 📍Rehberin Katıldığı Tur Sayısı: Belirli bir rehberin katıldığı tur sayısı.

Veriler, LINQ metodları ile veritabanından çekilir ve sonuçlar, form üzerindeki etiketlerde kullanıcıya görsel olarak sunulur. LINQ, koleksiyonlar üzerinde filtreleme, sıralama, gruplama gibi işlemleri basit ve etkili bir şekilde yapmamızı sağlar. Bu uygulamada kullanılan başlıca metodlar şunlardır:

### 🚀Max(): Bir koleksiyonun veya tablonun maksimum değerini döndürür.
### 🚀Where(): Belirli bir koşula dayalı filtreleme yapar.
### 🚀Select(): Veritabanından sadece istenilen sütunları seçer.
### 🚀FirstOrDefault(): Filtrelenmiş koleksiyonun ilk öğesini döndürür. Eğer koleksiyon boşsa, varsayılan değeri döner.
### 🚀Average(): Bir koleksiyonun veya tablonun ortalamasını hesaplar.
### 🚀Bu yaklaşım, veritabanı ile uygulama arasında güçlü bir bağ kurar ve verilerin hızlı ve doğru bir şekilde işlenmesini sağlar. Entity Framework ve LINQ, geliştiricilerin veritabanı işlemlerini daha verimli ve sürdürülebilir bir şekilde yönetmelerine olanak tanır.




# Uygulamanın Son Hali / Ekran Görüntüsü

![FrmStatistics_SS](https://github.com/user-attachments/assets/58cb9feb-c561-4f90-b77f-81fdd1d50abe)
