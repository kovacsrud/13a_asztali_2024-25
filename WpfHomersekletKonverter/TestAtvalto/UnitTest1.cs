using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace TestAtvalto
{
    public class Tests
    {
        protected const string WinAppDriverUrl = "http://127.0.0.1:4723";
        private const string WPFProgramId = @"D:\rud\kodtarak\11a_asztali_2022-23\WpfHomersekletKonverter\WpfHomersekletKonverter\bin\Debug\net7.0-windows\WpfHomersekletKonverter.exe";
        private const string WPFProgramPath = @"D:\rud\kodtarak\11a_asztali_2022-23\WpfHomersekletKonverter\WpfHomersekletKonverter\bin\Debug\net7.0-windows";

        protected static WindowsDriver<WindowsElement> driver;

        [OneTimeSetUp]
        public static void Setup()
        {
            if (driver == null)
            {
                var appiumOptions=new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", WPFProgramId);
                appiumOptions.AddAdditionalCapability("devicename", "WindowsPC");
                driver = new WindowsDriver<WindowsElement>(new Uri(WinAppDriverUrl),appiumOptions);
            }
        }

        [Test]
        [TestCase(31,-0.55555555)]
        [TestCase(55,12.77777777)]
        [TestCase(82, 27.77777777)]
        public void CelsiusTest(double fahrenheit,double elvart)
        {
            var homerseklet = driver.FindElementByAccessibilityId("homersekletErtek");
            homerseklet.Clear();
            driver.FindElementByAccessibilityId("celsiusKivalaszt").Click();
            homerseklet.SendKeys(fahrenheit.ToString());
            driver.FindElementByAccessibilityId("buttonKonvertalas").Click();
            var eredmeny=driver.FindElementByAccessibilityId("konvertaltHomerseklet");


            Assert.AreEqual(elvart,Convert.ToDouble(eredmeny.Text),0.0005);
        }

        [Test]
        [TestCase(31,87.8)]
        [TestCase(22, 71.6)]
        public void FahrenheitTest(double celsius,double elvart)
        {
            var homerseklet = driver.FindElementByAccessibilityId("homersekletErtek");
            homerseklet.Clear();
            driver.FindElementByAccessibilityId("fahrenheitKivalaszt").Click();
            homerseklet.SendKeys(celsius.ToString());
            driver.FindElementByAccessibilityId("buttonKonvertalas").Click();
            var eredmeny = driver.FindElementByAccessibilityId("konvertaltHomerseklet");


            Assert.AreEqual(elvart, Convert.ToDouble(eredmeny.Text), 0.0005);
        }



        [OneTimeTearDown]
        public void Endtest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}