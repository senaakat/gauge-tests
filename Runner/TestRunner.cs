// Runner/TestRunner.cs
using System;
using NUnit.Framework;

namespace Runner
{
    [TestFixture]
    public class TestRunner
    {
        [SetUp]
        public void Setup()
        {
            // Test setup işlemleri (WebDriver başlatma, konfigürasyon okuma, vb.)
        }

        [Test]
        public void RunGaugeSpecs()
        {
            // Gauge testlerini çalıştırma komutu
            string[] args = { "run", "specs" }; // "specs" dosya yolu veya pattern
            TestRunner.Main(args);
        }

        private static void Main(string[] args)
        {
            throw new NotImplementedException();
        }

        [TearDown]
        public void TearDown()
        {
            // Test teardown işlemleri (WebDriver kapatma, raporlama işlemleri, vb.)
        }
    }
}
