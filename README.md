# CsharpEgitimKampi301
C# EĞİTİM KAMPI 
Bu repo, ne kadar ilerlediğimi görmek için oluşturduğum C# eğitim kampı video sırasına bağlı bir repo'dur. Murat Yücedağ'ın hocalığında gerçekleştirilen C# eğitim kampı süresince tamamladığım projeleri içermektedir. Günden güne üstüne ekleme yapmaya çalışacağım.




Proje 1: Hello World:
Bu projede, konsola yazı yazdırmayı öğrendim. Console.WriteLine() komutu ile temel yazdırma işlemlerini keşfettim.

Proje 2: Değişkenler:
Bu projede int, string, double gibi farklı veri türlerinde değişkenler tanımlamayı ve kullanmayı öğrendim. 

Proje 3: Diziler (Arrays):
Bu projede, diziler ile çalışmayı öğrendim. Birden fazla değeri bir dizi içinde nasıl depolayabileceğimi ve döngülerle bu değerleri nasıl işleyebileceğimi öğrendim. 

Proje 4: Karar Yapıları (If-Else):
Bu proje ile if, else if ve else yapıları kullanarak karar yapıları oluşturdum. 

Proje 5: Döngüler (Loops):
Bu projede for, while döngüleri ile tanıştım. Döngülerle tekrarlayan işlemleri otomatikleştirme ve büyük veri gruplarını işlemeyi öğrendim. 

Proje 6: Metotlar (Methods):
Kodlarımı daha düzenli ve tekrar kullanılabilir hale getirmek için metotlar oluşturmayı öğrendim. Parametre alarak işlem yapan ve sonuç döndüren metotlar yazmayı denedim. 

Proje 7: Foreach Döngüsü ve Örnek Sınav Sistemi:
Bu projede, foreach döngüsünü daha yakından inceleyip bir sınav sistemi simülasyonu oluşturdum. Öğrencilerin sınav notlarını alarak ortalamalarını hesapladım ve geçme/kalma durumlarını belirledim. 

Proje 8: Geriye Değer Döndüren Fonksiyonlar:
Son projede, geri değer döndüren metotlar ile çalıştım. Kullanıcıdan aldığım verileri işleyip sonuçları döndüren fonksiyonlar oluşturdum.

Proje 9: Veritabanı Tabanlı Ürün-Kategori Bilgi Sistemi:
Bu projede veritabanı bağlantısı kurmayı ve veritabanından veri çekmeyi öğrendim. Kullanıcıdan tablo seçimini alarak, ilgili bilgileri ekran üzerinde listeleyen bir uygulama geliştirdim. SqlConnection ve SqlCommand sınıflarıyla veritabanına bağlanıp, sorgular çalıştırmayı deneyimledim.

Proje 10: Veritabanı Üzerinde Listeleme, Ekleme, Güncelleme ve Silme İşlemleri:
Bu projede, Kullanıcıdan tablo seçimini alarak hangi tablodan hangi verileri C# üzerinden listelemeyi, güncellemeyi, eklemeyi ve silmeyi öğrendim. 

Proje 11: N Katmanlı Mimari Entity Layer:
Bu projede, eğitim kampının 301 modülü olan Entity Layer ve genel katman yapısını öğrendim. Bir concrete klasörü altında SQL tablo yapısınında ki Product,Order,Customer,Category tablolarının class'ları oluşturdum.

Proje 12: Data Access Katmanı ve Context Sınıfı:
Bu projede, Data Access katmanı ve diğer katmanların birbirleriyle olan referanslarını ekledim. Context isimli bir class oluşturdum ve EntityFramework Paketlerini kurmayı ve App.config yapısına ConnectionString eklemeyi öğrendim.

Proje 13: Migration İşlemleri ve Abstract İnterface:
Bu projede, öncelikle package manager console ne işe yaradığını ve nasıl açıldığını öğrendim. Migration ne demek olduğunu ne işimize yaradığını abstract class ve interface mantığını anladım.

Proje 14: ORM Yapısı Database First ve Code First Farklılıkları:
Bu projede, genel ORM yapısı hakkında bilgi edindim. Database first yaklaşımı ile code first arasındaki farkları öğrendim ve EntityFramework DB First ile SQL üzerinden oluşturduğumuz tablo ve diyagramları Visual Studio'ya aktarmayı öğrendim.

Proje 15: Entity Framework Metotları ile Proje Uygulaması:
Bu projede, Entity Framework metotları ile tur rehber projesinin girişini yaptım. Normalde Database'de yapabileceğimiz işlemleri Entity Framework aracılığıyla c# form yapısında yapmayı öğrendim. Bunun sayesinde query yazmayı bilmeden bile database üzerinde 'crud' işlemleri yapabileceğimizi öğrendim.

Proje 16: Entity Framework ile Tur Projesi Location Uygulaması:
Bu projede, tur rehber projesinin location kısmını yaptım. Location tablosuna bilgi ekleme, silme, güncelleme ve listeleme işlemleri yapmayı ekledim ve location kısmının textbox label ve datagridview ile temel seviyede form tasarımını yaptım.

Proje 17: Entity Framework Metotları ve Linq Sorgular:
Bu projede, tur rehber projesinin veritabanından istediğimiz spesifik sorguları form ekranında gösterdim. Veritabanıyla bağlantılı şekilde çalışıp güncellenen ve bize en yüksek fiyat, ortalama kapasite, eklenen son ülke vs. gibi sorguları yaptım. 
![Ekran Alıntısı](https://github.com/user-attachments/assets/4630ffb8-7d42-4264-b3fd-6081c03c1f47)

Proje 18: EntityState Komutları ve Generic Repository Sınıfı:
Bu projede, EntityState komutlarını (modified, deleted,added,detached,unchanged vs.) öğrendim. Generic repository oluşturdum ve generic repository'den miras alan EntityFramework Class'ları ekledim.

Proje 19: Business Layer ve Logic Kurallar:
Bu projede, Business katmanına abstract klasörü oluşturup burda Category-Customer-Generic-Order-Product interface'leri oluşturdum. Concrete klasörü oluşturup bu klasörün altına ise Category-Customer-Order-Product class'ları oluşturdum. Amacımız burda verilerin DataAccess katmanından alınıp Business katmanında gösterilmesidir.

Proje 20: Dependency Injection:
Bu projede, Dependency Injection kavramını ve nerelerde kullanıldığını öğrendim. Ayrıca Business Layer'da Concrete'te bulunan Category-Customer-Order-ProductManager'da kalan işlemlerimi tamamladım. (GetById,Delete,Update,Insert,Constructor oluşturmak vs.)

Proje 21: Entity'e Özgü Metotlar:
Bu projede, Data Access Layer'da EntityFramework diye yeni bir klasör oluşturdum. Hepsi (EfAdminDal,EfCategoryDal,EfProductDal,EfCustomerDal,EfOrderDal) Generic Repositories'den miras alan yeni public class'lar. Product için yeni bir form oluşturdum ve SQL'e yeni veri girişleri yaptım. 
