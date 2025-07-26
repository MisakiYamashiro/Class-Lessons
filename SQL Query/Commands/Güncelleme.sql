--Veri Güncelleme
update Ogrenci set Bolum_ID = 1, Isim='Murtaza'
--Eğer  Update işlemlerinde where ile kısıtlama konmaz ise tüm tablo verileri update edilir.
update Ogrenci set Isim='Gucci', Soyisim='Prradaa' WHERE OkulNo=556

select * from Ogrenci