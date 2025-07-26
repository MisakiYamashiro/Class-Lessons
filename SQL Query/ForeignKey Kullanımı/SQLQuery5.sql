--İlişkisel Veritabanı Kullanımı
--Foreign Key Kullanımı.
--Foreign Key kullanmadan veritabanı yapalım

--create database IliskisellVeriTabani
--go
use IliskisellVeriTabani
go
--tablo isimlerinin çoğul olması zorunlu değil ancak best-practice bir kullanımdır.
create table Siniflar 
(
ID int primary key identity(1,1), --Primary key yapılan kolonlar otomatik olarak NOT NULL olurlar.
Isim nvarchar(30) not null,
Kapasite int,
Klimali bit
)
go
create table Ogrenciler 
(
ID int primary key identity(1,1),
Isim nvarchar(75) not null, -- not null hücrenin boş bırakılmasını engeller.
Soyisim nvarchar(75) not null,
KimlikNo nvarchar(11),
TelefonNo nvarchar(16),
OkulNo int,
Boy decimal(18,2),
Kilo decimal(18,2),
Sinif_ID int --Foreign Key kolonların türü veriyi alacakları tablo kolonunun türü ile aynı olmak ZORUNDADIR
constraint fk_SinifOgrenci foreign key (Sinif_ID) -- Sinif_ID isimli kolonu Foreign Key yap, anahtar adı fk_SinifOgrenci Olsun.
references Siniflar(ID)
)


