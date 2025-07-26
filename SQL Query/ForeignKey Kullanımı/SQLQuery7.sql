create database UniversitarioDB
go
use UniversitarioDB
go
create table Fakulte 
(
ID int primary key identity(1,1),
Isim nvarchar(75) NOT NULL,
Dekan nvarchar(75)
)
go
create table Bolum
(
ID int primary key identity(1,1),
Isim nvarchar(75) NOT NULL,
Fakulte_ID int
constraint fk_FakulteBolum foreign key (Fakulte_ID)
references Fakulte(ID)
)
go
create table Ders 
(
Kod int primary key identity(1,1),
Isim nvarchar(75) not null,
Kredi tinyint,
Saat tinyint,
Bolum_ID int NOT NULL
constraint fk_BolumDers foreign key (Bolum_ID)
references Bolum(ID)
)
go
create table Ogrenci 
(
OkulNo nvarchar(11) primary key,
Isim nvarchar(75)not null,
Soyisim nvarchar(75) not null,
BabaAd nvarchar(75),
Bolum_ID int
constraint fk_OgrenciBolum foreign key (Bolum_ID)
references Bolum(ID)
)
go

create table AlinanDersler
(
OgrenciNo nvarchar(11),
DersKodu int,
constraint pk_AlinanDers primary key(OgrenciNo, DersKodu),
constraint fk_AlinanDersOgrenci foreign key(OgrenciNo) references Ogrenci(OkulNo),
constraint fk_AlinanDersDers foreign key(DersKodu) references Ders(Kod)
)