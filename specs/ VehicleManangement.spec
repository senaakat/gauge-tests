# Vehicle Management Workflow

## User logs into the application

* Browser acilir
* Kullanici ilgili uygulamaya giris yapar
* Kullanici dogru giris bilgileri "<username>" "<password>" ile textbox'lari doldurur
* Kullanici login ekraninda guvenlik dogrulamasi yapar
* Kullanici siteye login oldugunu dogrular

## User navigates to Customer Portfolio

* Kullanici ana sayfada yer alan musteri portfoyunden yetki secimi yapar "<authorityDropdown>"
* Kullanici musteri ana sayfasinin acildigini dogrular

## User adds a new vehicle (TestCase1)

* Kullanici sidebardan "Araclar" basligini goruuntuler ve tiklar
* Ilgili ekranin sol ust kosesindeki "Tek Arac Ekle" butonunu goruuntuler ve tiklanabilir oldugunu dogrular
* Kullanici ilgili sayfaya gecis yaptigini dogrular
* Kullanici Plaka No textbox'ini goruuntuler ve tiklanabilir oldugunu dogrular 
* Kullanici Plaka No textbox'ina gecerli plaka bilgisini girer "<plakaNo>"
* Kullanici Motor No textbox'ini goruuntuler ve tiklanabilir oldugunu dogrular
* Kullanici Motor No textbox'ina gecerli motor bilgisini girer "<motorNo>"
* Kullanici Sasi No textbox'ini goruuntuler ve tiklanabilir oldugunu dogrular
* Kullanici Sasi No textbox'ina gecerli sasi bilgisini girer "<sasiNo>"
* Kullanici Marka dropdown menusunu goruuntuler ve tiklanabilir oldugunu dogrular
* Kullanici Marka dropdown menusunun acildigini dogrular 
* Kullanici ilgili marka secimini yapar "<marka>"
* Kullanici Model textbox'ini goruuntuler ve tiklanabilir oldugunu dogrular
* Kullanici Model dropdown menusunun acildigini dogrular
* Kullanici ilgili model secimini yapar "<model>"
* Kullanici Yil dropdown menusunu goruuntuler ve tiklanabilir oldugunu dogrular
* Kullanici Yil dropdown menusunun acildigini dogrular
* Kullanici ilgili yil secimini yapar "<yil>"
* Kullanici Servis Tipi dropdown menusunu goruuntuler ve tiklanabilir oldugunu dogrular
* Kullanici Servis Tipi dropdown menusunun acildigini dogrular
* Kullanici ilgili Servis Tipi secimini yapar "<servisTipi>"
* Kullanici zorunlu alanlarin girildigini dogrular
* Kullanici sag alt kosede bulunan kaydet butonunu goruuntuler ve tiklar
* Kullanici basariyla arac eklendigi mesajini goruuntuler

## User attempts to add a vehicle with an existing plate number (TestCase2)

*Kullanici sidebardan "Araclar" basligini goruuntuler ve tiklar
*Ilgili ekranin sol ust kosesindeki "Tek Arac Ekle" butonunu goruuntuler ve tiklanabilir oldugunu dogrular
*Kullanici ilgili sayfaya gecis yaptigini dogrular
*Kullanici Plaka No textbox'ini goruuntuler ve tiklanabilir oldugunu dogrular
*Kullanici Plaka No textbox'ina daha onceden eklenen plaka bilgisini girer "<existingPlakaNo>"
*Kullanici Motor No textbox'ini goruuntuler ve tiklanabilir oldugunu dogrular
*Kullanici Motor No textbox'ina gecerli motor bilgisini girer "<motorNo>"
*Kullanici Sasi No textbox'ini goruuntuler ve tiklanabilir oldugunu dogrular
*Kullanici Sasi No textbox'ina gecerli sasi bilgisini girer "<sasiNo>"
*Kullanici Marka dropdown menusunu goruuntuler ve tiklanabilir oldugunu dogrular
*Kullanici Marka dropdown menusunun acildigini dogrular
*Kullanici ilgili marka secimini yapar "<marka>"
*Kullanici Model textbox'ini goruuntuler ve tiklanabilir oldugunu dogrular
*Kullanici Model dropdown menusunun acildigini dogrular
*Kullanici ilgili model secimini yapar "<model>"
*Kullanici Yil dropdown menusunu goruuntuler ve tiklanabilir oldugunu dogrular
*Kullanici Yil dropdown menusunun acildigini dogrular
*Kullanici ilgili yil secimini yapar "<yil>"
*Kullanici Servis Tipi dropdown menusunu goruuntuler ve tiklanabilir oldugunu dogrular
*Kullanici Servis Tipi dropdown menusunun acildigini dogrular
*Kullanici ilgili Servis Tipi secimini yapar "<servisTipi>"
*Kullanici zorunlu alanlarin girildigini dogrular
*Kullanici sag alt kosede bulunan kaydet butonunu goruuntuler ve tiklar
*Kullanici "Bu plaka numarasi zaten kayitli" hata mesajini goruuntuler

## User logs out and closes the browser

* Kullanici header alaninda yer alan profile tiklar ve cikis yapar
* Kullanici browser'i kapatir
