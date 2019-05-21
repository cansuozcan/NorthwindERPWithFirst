-- 1) Bug�n�n tarihini kolon isimleri Y�l, Ay ve G�n olacak �ekilde listeleyiniz.
SELECT YEAR(GETDATE()) AS YIL,MONTH(GETDATE()) AS AY,DAY(GETDATE()) AS GUN
-- 2) Kendi ya��n�z� ��kartan sorguyu yaz�n�z.
SELECT DATEDIFF(YEAR,'1994.12.14',GETDATE())
-- 3) �r�nler tablosundaki ilk 10 kayd� listeleyin
SELECT TOP 10 * FROM Products
-- 4) Birebir firma sahibi ile temas kurulan tedarik�ileri listeleyin
SELECT*FROM Suppliers WHERE ContactTitle ='Owner'
-- 5) Stokta mevcut olan ve fiyati en buyuk olan 3 urunu listeleyin
SELECT TOP 3 * FROM Products WHERE UnitsInStock>0 ORDER BY UnitPrice DESC
-- 6) Hangi calisanlarim Almanca biliyor?
SELECT*FROM Employees WHERE Notes LIKE '%German%'
-- 7) Stokta 40 tan fazla olan urunlerimin adlari ve categoriIdleri?
SELECT ProductName , CategoryID FROM Products WHERE UnitsInStock>40 
-- 8) �smi 'chai' olanlarin ya da kategorisi 3 olan ve 29 dan fazla stogu olan urunleri listeleyin
SELECT* FROM Products WHERE (ProductName = 'Chai ') OR (CategoryID=3 AND UnitsInStock>29)
-- 9) Stogu 42 ile 100 arasinda olan urunleri listeleyin
SELECT * FROM Products WHERE UnitsInStock BETWEEN 42 AND 100
-- 10) Do�um tarihleri 1961-01-01 ve 2010-10-10 tarihleri aras�nda ve kad�n �al��anlar�m� listeleyin
SELECT *FROM Employees  WHERE (BirthDate  BETWEEN '1961-01-01' AND '2010-10-10' ) AND (TitleOfCourtesy='Ms.' OR TitleOfCourtesy='Mrs.')
-- 11) Ya�ad��� �ehir London ve Seattle olmayan �al��anlar�m�z kimlerdir?
SELECT *FROM Employees  WHERE City!='Seattle' AND City!='London' 
-- 12) Ad�nda ve soyad�nda 'e' harfi ge�meyen �al��anlar�m�z kimlerdir?
SELECT FirstName+' '+LastName AS AdSoyad FROM Employees WHERE FirstName NOT LIKE '%e%'
-- 13) Tum musterilerim olan sirketlerin isimlerini ve isimlerinin ilk ve son karakterlerini aralarında 1 bosluk olacak �ekilde listeleyin.
SELECT CompanyName FROM Customers
-- 14) Stok miktari kritik seviyeye veya altina dusmesine ragmen hala siparisini vermedigim urunler hangileridir?

-- 15) �i�ede sattigimm urunler nelerdir?
SELECT ProductName FROM Products WHERE QuantityPerUnit LIKE'%bottle%'
-- 16) 30 dolardan fazla ucretli urunlerimi getir..
SELECT ProductName FROM Products WHERE UnitPrice >'30.0000'
-- 17) Londra'da yasayan personellerimn adini soyadini gosteriniz...
SELECT FirstName+' '+LastName AS AdSoyad FROM Employees WHERE City='London'
-- 18) CategoryID'si 5 olmayan urunleri listeleyiniz..
SELECT*FROM Products WHERE CategoryID NOT LIKE '5'
-- 19) 01.01.1993'ten sonra ise giren personelleri listeleyiniz...
SELECT*FROM Employees WHERE HireDate >'01.01.1993'
-- 20) Mart ayinda alinmis olan siparislerin SiparisID'sini ve SiparisTarihini gosteriniz..
SELECT OrderId,OrderDate FROM Orders WHERE MONTH(OrderDate)=3
-- 21) Fiyat� k�s�ratl� �r�nleri bulun.
SELECT*FROM Products WHERE UnitPrice NOT LIKE'%.00'
SELECT*FROM Products WHERE UnitPrice - CAST(UnitPrice AS int)>0
-- 22) Hepsini satt���mda en cok ciro yapacagim aktif urunlerden ilk 5 tanesi hangisidir?

-- 23) Artik satista olmayan en pahali urunum hangisidir?

-- 24) Stogu olmasina ragmen artik satisini yapmadigim urunler hangisidir?

-- 25) Ismi birden fazla kelimeden olusan urunler hangileridir?
SELECT* FROM Products WHERE ProductName LIKE ('% %')
-- 26) Fax �ekemeyece�im tedarik�ilerim hangileridir?
SELECT* FROM Suppliers WHERE Fax IS NOT NULL
-- 27) Tedarik�ilerim hangi �lkelerden?
SELECT  DISTINCT Country From Suppliers
-- 28) Bolge bilgisi olmayan sirketlerin listesini raporlayiniz...

-- 29) Region bilgisi olan personellerimi gosteriniz...
SELECT* FROM Employees WHERE Region IS NOT NULL
-- 30) CategoryID'si 5 olan, urun bedeli 20'den buyuk 300'den kucuk olan, stok durumu null olmayan urunlerimin adlarini ve id'lerini gosteriniz...

-- 31) 'Dumon' ya da 'Alfki' idlerine sahip olan musterilerden alinmis, 1 nolu personelin onayladigi, 3 nolu kargo firmasi tarafindan gonderilmis ve ShipRegion'u null olan siparisleri gosteriniz...

-- 32) Teslimati Amerika'ya gec kalan siparisler hangileridir?

-- 33) En ya�l� �al��an�m�n ad� ve iletisim bilgileri nelerdir?

-- YILDIZLI SORU (Ilk yapana kahve. Not: bundan onceki tum sorulari bitirmis olmak gerekmektedir:))
-- 34) Dogum tarihi bu yil icin henuz gecmemis calisanlarimdan dogum tarihi en yakin olan calisanimi bulun
SELECT*FROM Employees WHERE MONTH(BirthDate)>=MONTH(GETDATE())AND DAY(BirthDate)> DAY(GETDATE()) ORDER BY MONTH(BirthDate),DAY(BirthDate) ASC
-- 35) Londra'da yasayan erkek calisanlarin sirketteki pozisyonlari nelerdir?

-- 36) Sirketin sahibi kimdir?

-- 37) Patron disinda hangi calisanlar Fransizca biliyor?

-- 38) Teslimati Almanya'ya gec kalan siparisler hangileridir?

-- 39) Henuz teslimati gerceklesmemis siparisler hangileridir?

-- 40) Son teslim edilen 10 siparisi gosteriniz...

-- 41) 1 dolarin altinda kargo ucreti olan siparisler hangileridir?

-- 42) Kargo ucreti ucuz diye hala teslim etmedigim siparisler hangileridir? (1 dolarin altindaki kargo ucreti)

-- 43) En pahali sekilde kargolanan siparis hangisidir?
SELECT TOP*1 FROM Orders ORDER BY Freight DESC
-- 44) Son gununde teslim edilen siparisler hangileridir?

-- 45) 01.11.1997 - 06.06.1998 tarihleri arasindaki siparisleri gosteriniz...

-- 46) Bas harfi A olan, stoklarda bulunan, 10-250 dolar arasi ucreti olan urunleri alfabetik olarak siralayiniz..
SELECT*FROM ProductS WHERE ProductName LIKE 'a%' AND UnitsInStock >0 AND (UnitPrice BETWEEN 10 AND 250) ORDER BY ProductName ASC
SELECT*FROM ProductS WHERE ProductName LIKE 'a%' AND UnitsInStock >0 AND (UnitPrice>=10 AND UnitPrice<=250 ) ORDER BY ProductName ASC
-- 47) Carsamba gunu alinan, kargo ucreti 20-75$ arasi olan, shipdate'i null olmayan siparislerin ID'lerini buyukten kucuge siralayiniz...
SELECT*FROM Orders WHERE DATENAME(WEEKDAY,OrderDate)= 'Wednesday' AND (Freight BETWEEN 20 AND 75) AND ShippedDate IS NOT NULL ORDER BY OrderID DESC
-- 48) Stogumda hic bulunmayİp tedarikcilerime siparis verdigim urunler hangileridir?
SELECT*FROM Products WHERE UnitsInStock = 0  and UnitsOnOrder >0
-- 49) Haftanin son gunu teslim ettigim siparisler hangileridir? 

-- 50) Yuksek lisans yapan calisanlarim hangileridir?

-- 51) Termin tarihi 2 hafta olan siparislerim hangileridir?