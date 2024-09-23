

# Library Management System

## Proje Özeti
Bu proje, kullanıcıların kitap girişi , yazar girişi ve login ,signup yapabileceği bir kütüphane yönetim sistemidir. Kullanıcılar, kitap bilgilerini girerek yeni kitaplar, yeni yazarlar ekleyebilir, güncelleyebilir  ve bu bilgileri görüntüleyebilir. Proje, kullanıcı dostu bir arayüze sahip olup, kitaplarla ilgili temel bilgileri (başlık, yazar, tür, yayın tarihi, özet, ISBN, kopya sayısı ve resim) ve yazar ile igili temel verileri (yazar adı, soyadı, doğum tarihi, kitapları ) yönetmektedir.

## Kullanılan Teknolojiler
- **ASP.NET Core**: Web uygulamasının geliştirilmesinde kullanıldı.
- **Entity Framework Core**: Veri erişimi için kullanıldı.
- **HTML/CSS**: Kullanıcı arayüzü tasarımı için kullanıldı.
- **JavaScript**: Form etkileşimleri ve dinamik içerik için kullanıldı.
- **Bootstrap**: Responsive tasarım için kullanıldı.

## Projeyi Çalıştırmak İçin Gerekenler
1. **Gereksinimler**:
   - .NET Core SDK (en az 3.1 veya üstü)
   - Ben static list kullandım.
   - Bir veritabanı yönetim sistemi (SQL Server, SQLite, vb. tercih edilebilir)

2. **Projenin Kurulumu**:
   - Projeyi klonlayın veya ZIP dosyası olarak indirin.
   - Terminal veya komut istemcisinde proje dizinine gidin.
   - Gerekli paketleri yüklemek için şu komutu çalıştırın:
     ```bash
     dotnet restore
     ```
 ef database update
     ```

4. **Uygulamayı Başlatma**:
   - Uygulamayı başlatmak için şu komutu çalıştırın:
     ```bash
     dotnet run
     ```
   - Tarayıcınızda `http://localhost:5000` adresine giderek uygulamanızı görüntüleyin.

## Kullanım
**Login Olmadan Önce**:

Login olmadan yapılan girişlerde kısıtlı işlemler yapabilirsiniz.

![Anasayfa](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/beforesignup1.png)
![Kitap Listesi](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/beforesignup2.png)
![Yazar Listesi](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/beforesignup3.png)

**Login Sonrası**:
![Anasayfa](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/login1.png)
![Kitap Listesi](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/login2.png)
![Kitap Giris](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/kitapgirisi.png)
![Kitap Güncelleme](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/editbook.png)
![Kitap Detay](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/detaylar.png)
![Yazar Giriş](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/yazargirisi.png)
![Yazar Güncelleme](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/yazargüncelleme.png)
![Yazar Detay](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/yazardetay.png)
![Hakkında](https://github.com/Melike10/LibraryManagementSystem/blob/0956d6774be6c4a10048423d964da66b756e9e72/about.png)






## Katkıda Bulunanlar
- Melike

