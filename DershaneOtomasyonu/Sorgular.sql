use [130720074]
go



Drop proc if exists DerslerListele
go
Create proc DerslerListele
as
Select * from Dersler
go 

Drop proc if exists DerslerEkle
go
Create proc DerslerEkle(@DersAdi nvarchar(50))
as
Insert into Dersler(DersAdi) values (@DersAdi) select @@IDENTITY
go

Drop proc if exists DerslerGuncelle
go
Create proc DerslerGuncelle(@DersAdi nvarchar(50),@ID int)
as
Update Dersler set DersAdi=@DersAdi where ID=@ID
go

Drop proc if exists DerslerSil 
go
create proc DerslerSil (@ID int)
as
Delete Dersler where ID = @ID
go

Drop proc if exists DerslerID
go
Create proc DerslerID (@ID int)
as
Select * from Dersler where ID = @ID
go

Drop proc if exists KullanicilarListele 
go
Create proc KullanicilarListele
as
Select *from Kullanicilar
go

Drop proc if exists KullanicilarEkle
go
Create proc KullanicilarEkle(@K_adi nvarchar(50),@Sifre nvarchar(50),@Gorev nvarchar(50), @Adi nvarchar(50), @Soyadi nvarchar(50), @TCKN decimal(11,0),@Telefon nvarchar(50), @Mail nvarchar(50),@Adres nvarchar (50))
as
Insert into Kullanicilar (K_adi,Sifre,Gorev,Adi,Soyadi,TCKN,Telefon,Mail,Adres) values (@K_adi,@Sifre,@Gorev,@Adi,@Soyadi,@TCKN,@Telefon,@Mail,@Adres) select @@IDENTITY
go

Drop proc if exists KullanicilarGuncelle
go
Create proc KullanicilarGuncelle(@K_adi nvarchar (50), @Sifre nvarchar(50),@Gorev nvarchar(50), @Adi nvarchar(50), @Soyadi nvarchar(50), @TCKN decimal(11,0),@Telefon nvarchar(50), @Mail nvarchar(50),@Adres nvarchar (50), @ID int)
as
Update Kullanicilar set K_adi=@K_adi, Sifre=@Sifre, Gorev=@Gorev,Adi=@Adi, Soyadi=@Soyadi,TCKN=@TCKN,Telefon=@Telefon,Mail=@Mail,Adres=@Adres where ID=@ID
go

Drop proc if exists KullanicilarSil
go 
Create proc KullanicilarSil (@ID int)
as
Delete Kullanicilar where  ID=@ID
go

Drop proc if exists KullanicilarID
go
Create proc KullanicilarID (@ID int)
as
Select *from Kullanicilar where ID =@ID
go 

drop procedure if exists KullaniciTCKontrol
go
create procedure KullaniciTCKontrol(@TCKN decimal(11,0))
as
select * from Kullanicilar where TCKN = @TCKN 
go

drop procedure if exists KullanicilarKontrol
go
create procedure KullanicilarKontrol(@K_Adi nvarchar(50), @Sifre nvarchar(50))
as
select * from Kullanicilar where K_Adi = @K_Adi and Sifre = @Sifre  
go

drop procedure if exists KullaniciAdiKontrol
go
create procedure KullaniciAdiKontrol(@K_Adi nvarchar(50))
as
select * from Kullanicilar where K_Adi = @K_Adi 
go

Drop proc if exists NotlarListele
go
Create proc NotlarListele
as
Select * from Notlar
go

Drop proc if exists NotlarEkle
go
Create proc NotlarEkle(@OgrenciID int, @SinavTarihi date,  @Notu decimal(6,3),@SinavAdi nvarchar(50))
as
Insert into Notlar (OgrenciID,SinavTarihi,Notu,SinavAdi) values (@OgrenciID,@SinavTarihi,@Notu,@SinavAdi) select @@IDENTITY
go

Drop proc if exists NotlarGuncelle 
go
Create proc NotlarGuncelle (@SinavTarihi date , @OgrenciID int, @Notu decimal(6,3),@SinavAdi nvarchar(50), @ID int)
as
Update Notlar set SinavTarihi=@SinavTarihi, Notu=@Notu, OgrenciID=@OgrenciID, SinavAdi=@SinavAdi where ID=@ID
go

Drop proc if exists NotlarSil
go 
Create proc NotlarSil (@ID int)
as
Delete Notlar where ID=@ID
go

Drop proc if exists NotlarID 
go 
Create proc NotlarID (@ID int) 
as 
Select * from Notlar where ID=@ID 
go

Drop proc if exists OgrenciListele
go
Create proc OgrenciListele 
as
Select * from Ogrenci
go

Drop proc if exists OgrenciEkle
go 
Create proc OgrenciEkle (@Adi nvarchar(50), @Soyadi nvarchar(50), @TCKN decimal(11,0),@Telefon nvarchar(50), @Mail nvarchar(50),@Adres nvarchar (50), @VeliAdi nvarchar(50), @VeliTelefonu nvarchar(50),@SinifID int)
as
Insert into Ogrenci (Adi,Soyadi,TCKN,Telefon,Mail,Adres,VeliAdi,VeliTelefonu,SinifID) values (@Adi, @Soyadi, @TCKN, @Telefon, @Mail, @Adres, @VeliAdi, @VeliTelefonu,@SinifID) select @@IDENTITY
go

Drop proc if exists OgrenciGuncelle
go
Create proc OgrenciGuncelle (@Adi nvarchar (50),@Soyadi nvarchar (50),@TCKN decimal(11,0) ,@Telefon nvarchar (50),@Mail nvarchar (50),@Adres nvarchar (50),@VeliAdi nvarchar (50),@VeliTelefonu nvarchar (50),@SinifID int, @ID int)
as
Update Ogrenci set Adi=@Adi, Soyadi=@Soyadi,TCKN=@TCKN, Telefon=@Telefon, Mail=@Mail, Adres=@Adres , VeliAdi=@VeliAdi, VeliTelefonu=@VeliTelefonu, SinifID=@SinifID where ID=@ID
go

Drop proc if exists OgrenciSil 
go
Create proc OgrenciSil (@ID int)
as
Delete Ogrenci where ID=@ID 
go

Drop proc if exists OgrenciID
go
Create proc OgrenciID (@ID int) 
as
Select* from Ogrenci where ID=@ID 
go

drop procedure if exists OgrenciTCKontrol
go
create procedure OgrenciTCKontrol(@TCKN decimal(11,0))
as
select * from Ogrenci where TCKN = @TCKN 
go

Drop proc if exists OgrenciDerslerListele
go
Create proc OgrenciDerslerListele 
as
Select * from OgrenciDersler
go

Drop proc if exists OgrenciDerslerEkle 
go
Create proc OgrenciDerslerEkle (@OgrenciID int, @DersID int)
as
Insert into OgrenciDersler(OgrenciID,DersID) values (@OgrenciID,@DersID) select @@IDENTITY
go

Drop proc if exists OgrenciDerslerGuncelle 
go
Create proc OgrenciDerslerGuncelle (@OgrenciID int, @DersID int , @ID int) 
as
Update OgrenciDersler set OgrenciID=@OgrenciID,DersID=@DersID where ID=@ID
go

Drop proc if exists OgrenciDerslerSil 
go 
Create proc OgrenciDerslerSil (@ID int)
as
Delete OgrenciDersler where ID=@ID 
go


Drop proc if exists OgrenciDerslerID
go
Create proc OgrenciDerslerID (@ID int)
as
Delete OgrenciDersler where ID=@ID 
go

Drop proc if exists OgretmenListele
go
Create proc OgretmenListele
as
Select*from Ogretmen
go

Drop proc if exists OgretmenEkle
go 
Create proc OgretmenEkle  (@Brans nvarchar(50),@KullanicilarID int)
as
Insert into Ogretmen (Brans,KullnicilarID) values (@Brans,@KullanicilarID)select @@IDENTITY
go

Drop proc if exists OgretmenGuncelle
go 
Create proc OgretmenGuncelle  (@Brans nvarchar(50), @KullanicilarID int, @ID int)
as
Update Ogretmen set  Brans=@Brans,KullnicilarID=@KullanicilarID where ID=@ID 
go

Drop proc if exists OgretmenSil
go
Create proc OgretmenSil (@ID int)
as
Delete Ogrenci where ID=@ID 
go

Drop proc if exists OgretmenID 
go
Create proc OgretmenID (@ID int )
as 
Select * from Ogretmen where ID=@ID
go

Drop proc if exists SinifListele
go 
Create proc SinifListele 
as
Select * from Sinif
go

Drop proc if exists SinifEkle 
go 
Create proc SinifEkle (@SinifDurumu nvarchar(50), @SubeAdi nvarchar(50), @BolumAdi nvarchar(50))
as
Insert into Sinif (SinifDurumu,SubeAdi,BolumAdi) values (@SinifDurumu, @SubeAdi , @BolumAdi ) select @@IDENTITY
go

Drop proc if exists SinifGuncelle 
go
Create proc SinifGuncelle (@SinifDurumu nvarchar (50), @SubeAdi nvarchar(50), @BolumAdi nvarchar(50),@ID int )
as
Update Sinif set SinifDurumu=@SinifDurumu,SubeAdi=@SubeAdi,BolumAdi=@BolumAdi where ID=@ID 
go

Drop proc if exists SinifSil 
go
Create proc SinifSil (@ID int)
as
Delete Sinif where ID=@ID 
go

Drop proc if exists SinifID 
go
Create proc SinifID (@ID int)
as 
Select *from Sinif where ID=@ID 
go

drop procedure if exists SinifKontrol
go
create procedure SinifKontrol(@SinifDurumu nvarchar(50),@BolumAdi nvarchar(50),@SubeAdi nvarchar (50))
as
select * from Sinif where SinifDurumu = @SinifDurumu and BolumAdi=@BolumAdi and SubeAdi=@SubeAdi
go