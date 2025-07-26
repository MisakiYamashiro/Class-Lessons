--Tablolara Veri Ekleme.
insert into Fakulte (Isim,Dekan) VALUES('İktisadi ve İdari Bilimler Fakültesi', 'Alp Sarıkışla')

insert into Fakulte (Dekan, Isim) values('Dilara Nur Şavran','Diş Hekimliği Fakültesi')                   

insert into Fakulte (Isim,Dekan) values('Turizm Fakültesi','Yağızcan Akgün')

insert into Fakulte (Isim,Dekan) values('İnsan ve Toplum Bilimleri Fakültesi','Efe Palaz')

insert into Fakulte (Isim,Dekan) values('İlahiyat Fakültesi','Yusuf Ekrem İkiz')

insert into Fakulte (Isim,Dekan) values('Tıp Fakültesi','Muhammet Emre Tutuk')

insert into Fakulte (Isim,Dekan) values('Sanat ve Tasarım Fakültesi', 'Ali Kerem Kelebek')

insert into Bolum(Isim,Fakulte_ID) values('İktisat Bölümü',1)
insert into Bolum(Isim,Fakulte_ID) values('İşletme Bölümü',1)
insert into Bolum(Isim,Fakulte_ID) values('Maliye Bölümü',1)
insert into Bolum(Isim,Fakulte_ID) values('Siyaset Bilimi ve Kamu Yönetimi Bölümü',1)


insert into Bolum(Isim,Fakulte_ID) values('Gastronomi Bölümü',4)
insert into Bolum(Isim,Fakulte_ID) values('Turizm İşletmeciliği Bölümü',4)

--10 Adet Öğrenci Ekleyin
insert into Ogrenci(OkulNo, Isim,Soyisim,BabaAd,Bolum_ID)  values(546,'Efe','Palaz','Rıdvan',4)
insert into Ogrenci(OkulNo, Isim,Soyisim,BabaAd,Bolum_ID)  values(547,'Ali','Bıçakyürek','Ali',4)
insert into Ogrenci(OkulNo, Isim,Soyisim,BabaAd,Bolum_ID)  values(548,'Mert','Yılmaz','Muhammet',2)
insert into Ogrenci(OkulNo, Isim,Soyisim,BabaAd,Bolum_ID)  values(549,'Cemre','Demir','Rıdvan',1)
insert into Ogrenci(OkulNo, Isim,Soyisim,BabaAd,Bolum_ID)  values(550,'Yusuf','Sarı','Ferhat',3)
insert into Ogrenci(OkulNo, Isim,Soyisim,BabaAd,Bolum_ID)  values(551,'Yunus','Kış','Yılmaz',4)
insert into Ogrenci(OkulNo, Isim,Soyisim,BabaAd,Bolum_ID)  values(552,'Sema','Alibey','Cevani',5)
insert into Ogrenci(OkulNo, Isim,Soyisim,BabaAd,Bolum_ID)  values(553,'İlayda','Ortaçocuğu','Çavani',6)
insert into Ogrenci(OkulNo, Isim,Soyisim,BabaAd,Bolum_ID)  values(554,'Elanur','Feleessi','Olle',1)
insert into Ogrenci(OkulNo, Isim,Soyisim,BabaAd,Bolum_ID)  values(555,'Damla','Antonio','Ortac',3)
insert into Ogrenci(OkulNo, Isim,Soyisim,BabaAd,Bolum_ID)  values(556,'Hakan','Yalama','Loelo',6)
select * from Bolum