using System;
using Gauge.CSharp.Lib.Attribute;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Pages;

public class VehicleManangement{
        IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
        private static IWebDriver _driver;
        private static WebDriverWait _wait;

        private AddVehiclePage addVehiclePage;

    [Step("Browser acilir")]
                public void BrowserAcilir()
                {
                        _driver = new ChromeDriver();
                        _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                        _driver.Manage().Window.Maximize();
                }

                [Step("Kullanici ilgili uygulamaya giris yapar")]
                public void KullaniciIlgiliUygulamayaGirisYapar()
                {
                        _driver.Navigate().GoToUrl(Configuration.BaseUrl);
                }

                [Step("Kullanici dogru giris bilgileri ile textbox'lari doldurur")]
                public void KullaniciDogruGirisBilgileriIleTextboxlariDoldurur()
                {
                        addVehiclePage.EnterName(Configuration.TestName);
                        addVehiclePage.EnterPassword(Configuration.TestPassword);
                }

                [Step("Kullanici login ekraninda guvenlik dogrulamasi yapar")]
                public void KullaniciLoginEkranindaGuvenlikDogrulamasiYapar()
                {
                        //I don't know how to adding this step
                        throw new NotImplementedException();
                }

                [Step("Kullanici siteye login oldugunu dogrular")]
                public void KullaniciSiteyeLoginOldugunuDogrular()
                {
                        _driver.FindElement(By.Id("loginButton")).Click();
                        Assert.IsTrue(_driver.Url.Contains(Configuration.AuthorityUrl), "User failed to login.");

                }

                [Step("Kullanici ana sayfada yer alan musteri portfoyunden yetki secimi yapar")]
                public void KullaniciAnaSayfadaYerAlanMusteriPortfoyundenYetkiSecimiYapar()
                {
                        var dropdown = _driver.FindElement(By.Id("authorityDropdown"));
                        dropdown.Click();
                        _driver.FindElement(By.XPath("//option[text()='Yetki 1']")).Click();
                }

                [Step("Kullanici musteri ana sayfasinin acildigini dogrular")]
                public void KullaniciMusteriAnaSayfasininAcildiginiDogrular()
                {
                        _driver.Navigate().GoToUrl(Configuration.DashboardUrl);
                        Assert.IsTrue(_driver.Title.Contains("Ana Sayfa"));
                }

                [Step("Kullanici sidebardan <Araclar> basligini goruuntuler ve tiklar")]
                public void KullaniciSidebardanBasliginiGoruuntulerVeTiklar(string title)
                {
                        var aracBasligi = _driver.FindElement(By.XPath($"//a[contains(text(), '{title}')]"));
                        Assert.IsTrue(aracBasligi.Displayed);
                        aracBasligi.Click();
                }

                [Step("Ilgili ekranin sol ust kosesindeki <Tek Arac Ekle> butonunu goruuntuler ve tiklanabilir oldugunu dogrular")]
                public void IlgiliEkraninSolUstKosesindekiButonunuGoruuntulerVeTiklanabilirOldugunuDogrular(string button)
                {
                        var tekAracEkleButonu = _driver.FindElement(By.XPath($"//button[contains(text(), '{button}')]"));
                        Assert.IsTrue(tekAracEkleButonu.Displayed);
                        Assert.IsTrue(tekAracEkleButonu.Enabled);
                }

                [Step("Kullanici ilgili sayfaya gecis yaptigini dogrular")]
                public void KullaniciIlgiliSayfayaGecisYaptiginiDogrular()
                {
                        Assert.IsTrue(_driver.Url.Contains(Configuration.CarsUrl));
                }

                [Step("Kullanici Plaka No textbox'ini goruuntuler ve tiklanabilir oldugunu dogrular")]
                public void KullaniciPlakaNoTextboxiniGoruuntulerVeTiklanabilirOldugunuDogrular()
                {
                        var plakaTextbox = _driver.FindElement(By.Id("plakaNo"));
                        Assert.IsTrue(plakaTextbox.Displayed);
                        Assert.IsTrue(plakaTextbox.Enabled);
                }

                [Step("Kullanici Plaka No textbox'ina gecerli plaka bilgisini girer")]
                public void KullaniciPlakaNoTextboxinaGecerliPlakaBilgisiniGirer()
                {
                        var plakaTextbox = _driver.FindElement(By.Id("plakaNo"));
                        plakaTextbox.SendKeys("34ABC123");
                }

                [Step("Kullanici Motor No textbox'ini goruuntuler ve tiklanabilir oldugunu dogrular")]
                public void KullaniciMotorNoTextboxiniGoruuntulerVeTiklanabilirOldugunuDogrular()
                {
                        var motorNoTextbox = _driver.FindElement(By.Id("motorNo"));
                        Assert.IsTrue(motorNoTextbox.Displayed);
                        Assert.IsTrue(motorNoTextbox.Enabled);
                }

                [Step("Kullanici Motor No textbox'ina gecerli motor bilgisini girer")]
                public void KullaniciMotorNoTextboxinaGecerliMotorBilgisiniGirer()
                {
                        var motorNoTextbox = _driver.FindElement(By.Id("motorNo"));
                        motorNoTextbox.SendKeys("1234567890");
                }

                [Step("Kullanici Sasi No textbox'ini goruuntuler ve tiklanabilir oldugunu dogrular")]
                public void KullaniciSasiNoTextboxiniGoruuntulerVeTiklanabilirOldugunuDogrular()
                {
                        var sasiNoTextbox = _driver.FindElement(By.Id("sasiNo"));
                        Assert.IsTrue(sasiNoTextbox.Displayed);
                        Assert.IsTrue(sasiNoTextbox.Enabled);
                }

                [Step("Kullanici Sasi No textbox'ina gecerli sasi bilgisini girer")]
                public void KullaniciSasiNoTextboxinaGecerliSasiBilgisiniGirer()
                {
                        var sasiNoTextbox = _driver.FindElement(By.Id("sasiNo"));
                        sasiNoTextbox.SendKeys("JH4DA9450KS007792");
                }

                [Step("Kullanici Marka dropdown menusunu goruuntuler ve tiklanabilir oldugunu dogrular")]
                public void KullaniciMarkaDropdownMenusunuGoruuntulerVeTiklanabilirOldugunuDogrular()
                {
                        var markaDropdown = _driver.FindElement(By.Id("marka"));
                        Assert.IsTrue(markaDropdown.Displayed);
                        Assert.IsTrue(markaDropdown.Enabled);
                }

                [Step("Kullanici Marka dropdown menusunun acildigini dogrular")]
                public void KullaniciMarkaDropdownMenusununAcildiginiDogrular()
                {
                        var markaDropdown = new SelectElement(_driver.FindElement(By.Id("marka")));
                        markaDropdown.SelectByIndex(0);
                        Assert.IsTrue(markaDropdown.Options.Count > 1);
                }

                [Step("Kullanici ilgili marka secimini yapar")]
                public void KullaniciIlgiliMarkaSeciminiYapar()
                {
                        var markaDropdown = new SelectElement(_driver.FindElement(By.Id("marka")));
                        markaDropdown.SelectByText("Toyota");
                }

                [Step("Kullanici Model textbox'ini goruuntuler ve tiklanabilir oldugunu dogrular")]
                public void KullaniciModelTextboxiniGoruuntulerVeTiklanabilirOldugunuDogrular()
                {
                        var modelDropdown = _driver.FindElement(By.Id("model"));
                        Assert.IsTrue(modelDropdown.Displayed);
                        Assert.IsTrue(modelDropdown.Enabled);
                }

                [Step("Kullanici Model dropdown menusunun acildigini dogrular")]
                public void KullaniciModelDropdownMenusununAcildiginiDogrular()
                {
                        var modelDropdown = new SelectElement(_driver.FindElement(By.Id("model")));
                        modelDropdown.SelectByIndex(0);
                        Assert.IsTrue(modelDropdown.Options.Count > 1);
                }

                [Step("Kullanici ilgili model secimini yapar")]
                public void KullaniciIlgiliModelSeciminiYapar()
                {
                        var modelDropdown = new SelectElement(_driver.FindElement(By.Id("model")));
                        modelDropdown.SelectByText("Corolla");
                }

                [Step("Kullanici Yil dropdown menusunu goruuntuler ve tiklanabilir oldugunu dogrular")]
                public void KullaniciYilDropdownMenusunuGoruuntulerVeTiklanabilirOldugunuDogrular()
                {
                        var yilDropdown = _driver.FindElement(By.Id("yil"));
                        Assert.IsTrue(yilDropdown.Displayed);
                        Assert.IsTrue(yilDropdown.Enabled);
                }

                [Step("Kullanici Yil dropdown menusunun acildigini dogrular")]
                public void KullaniciYilDropdownMenusununAcildiginiDogrular()
                {
                        var yilDropdown = new SelectElement(_driver.FindElement(By.Id("yil")));
                        yilDropdown.SelectByIndex(0);
                        Assert.IsTrue(yilDropdown.Options.Count > 1);
                }

                [Step("Kullanici ilgili yil secimini yapar")]
                public void KullaniciIlgiliYilSeciminiYapar()
                {
                        var yilDropdown = new SelectElement(_driver.FindElement(By.Id("yil")));
                        yilDropdown.SelectByText("2020");
                }

                [Step("Kullanici Servis Tipi dropdown menusunu goruuntuler ve tiklanabilir oldugunu dogrular")]
                public void KullaniciServisTipiDropdownMenusunuGoruuntulerVeTiklanabilirOldugunuDogrular()
                {
                        var servisTipiDropdown = _driver.FindElement(By.Id("servisTipi"));
                        Assert.IsTrue(servisTipiDropdown.Displayed);
                        Assert.IsTrue(servisTipiDropdown.Enabled);
                }

                [Step("Kullanici Servis Tipi dropdown menusunun acildigini dogrular")]
                public void KullaniciServisTipiDropdownMenusununAcildiginiDogrular()
                {
                        var servisTipiDropdown = new SelectElement(_driver.FindElement(By.Id("servisTipi")));
                        servisTipiDropdown.SelectByIndex(0);
                        Assert.IsTrue(servisTipiDropdown.Options.Count > 1);
                }

                [Step("Kullanici ilgili Servis Tipi secimini yapar")]
                public void KullaniciIlgiliServisTipiSeciminiYapar()
                {
                        var servisTipiDropdown = new SelectElement(_driver.FindElement(By.Id("servisTipi")));
                        servisTipiDropdown.SelectByText("Bakım");
                }

                [Step("Kullanici zorunlu alanlarin girildigini dogrular")]
                public void KullaniciZorunluAlanlarinGirildiginiDogrular()
                {
                        Assert.IsTrue(_driver.FindElement(By.Id("plakaNo")).GetAttribute("value").Length > 0);
                        Assert.IsTrue(_driver.FindElement(By.Id("motorNo")).GetAttribute("value").Length > 0);
                        Assert.IsTrue(_driver.FindElement(By.Id("sasiNo")).GetAttribute("value").Length > 0);
                }

                [Step("Kullanici sag alt kosede bulunan kaydet butonunu goruuntuler ve tiklar")]
                public void KullaniciSagAltKosedeBulunanKaydetButonunuGoruuntulerVeTiklar()
                {
                        var kaydetButonu = _driver.FindElement(By.Id("kaydetButon"));
                        Assert.IsTrue(kaydetButonu.Displayed);
                        Assert.IsTrue(kaydetButonu.Enabled);
                        kaydetButonu.Click();
                }

                [Step("Kullanici basariyla arac eklendigi mesajini goruuntuler")]
                public void KullaniciBasariylaAracEklendigiMesajiniGoruuntuler()
                {
                        var mesaj = _driver.FindElement(By.ClassName("success-message"));
                        Assert.IsTrue(mesaj.Displayed);
                        Assert.AreEqual("Araç başariyla eklendi!", mesaj.Text);
                }

                [Step("Kullanici Plaka No textbox'ina daha onceden eklenen plaka bilgisini girer <<existingPlakaNo>>")]
                public void KullaniciPlakaNoTextboxinaDahaOncedenEklenenPlakaBilgisiniGirer()
                {
                        var existingPlakaNo = _driver.FindElement(By.Id("plakaNo"));
                        existingPlakaNo.SendKeys("34ABC123");
                }

                [Step("Kullanici <Bu plaka numarasi zaten kayitli> hata mesajini goruuntuler")]
                public void KullaniciHataMesajiniGoruuntuler()
                {
                        var mesaj = _driver.FindElement(By.ClassName("unsucces-message"));
                        Assert.IsTrue(mesaj.Displayed);
                        Assert.AreEqual("Bu Plaka No'su zaten kayitli!", mesaj.Text);
                }

                [Step("Kullanici header alaninda yer alan profile tiklar ve cikis yapar")]
                public void KullaniciHeaderAlanindaYerAlanProfileTiklarVeCikisYapar()
                {
                        var profilButonu = _driver.FindElement(By.Id("profil"));
                        profilButonu.Click();
                        
                        var cikisButonu = _driver.FindElement(By.Id("cikis"));
                        cikisButonu.Click();
                }

                [Step("Kullanici browser'i kapatir")]
                public void KullaniciBrowseriKapatir()
                {
                        _driver.Quit();
                }


}