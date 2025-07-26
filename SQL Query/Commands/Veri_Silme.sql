--Veri Silme
delete from Ogrenci 

select * from Ogrenci

delete from Bolum where ID=1

select * from Bolum

--Eğer silinmek istenen verinin primary key'i foreign key olarak kullanımda ise
--Silme işlemine izin vermez