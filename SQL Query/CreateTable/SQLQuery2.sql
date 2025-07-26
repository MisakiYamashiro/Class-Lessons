create database MyDatabaseWithTable
GO --Önce bu satıra kadar olan tüm işlemleri tamamla, sonra devam et.
use MyDatabaseWithTable
--İsmi yazılan veritabanını available databases 
--kısmına taşır ve queryler bu veritabanı
--için geçerli olur.
go
create table Ogrenciler
(
ID int primary key identity(1,1), --identity(seed,increment)
--Bir tablonun sadece 1 PRIMARY KEY 'i olur.
Isim nvarchar(50),
Soyisim nvarchar(50),
Telefon nvarchar(20),
OkulNo nvarchar(10),
DogumYili int,
AktifMi bit,
)
drop table Ogrenciler
--use master
--drop table Ogrenciler