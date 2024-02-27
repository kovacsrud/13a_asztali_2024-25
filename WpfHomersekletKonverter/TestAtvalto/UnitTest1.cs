using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework.Interfaces;
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
        private const string WPFProgramPath = @"D:\rud\kodtarak\11a_asztali_2022-23\WpfHomersekletKonverter\WpfHomersekletKonverter\bin\Debug\net7.0-windows\";

        protected static WindowsDriver<WindowsElement> driver;

        protected static ExtentReports extReport;
        protected static ExtentTest extTest;

        [OneTimeSetUp]
        public static void ReportSetup()
        {
            extReport = new ExtentReports();
            extReport.AddSystemInfo("Hõméséklet átváltás teszt","Automatizált teszt");
            extReport.AddSystemInfo("Tesztelõ", "XY");
            ExtentSparkReporter reporter = new ExtentSparkReporter(WPFProgramPath+"\\result.html");
            extReport.AttachReporter(reporter);
            reporter.Config.DocumentTitle = "Hõmérséklet konvertálás teszt riport";
            reporter.Config.ReportName = "Hõmérséklet konvertálás";
            reporter.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Standard;
        }


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
        [TestCase(33, -0.55555555)]
        [TestCase(31,-0.55555555)]
        [TestCase(55,12.77777777)]
        [TestCase(82, 27.77777777)]
        public void CelsiusTest(double fahrenheit,double elvart)
        {
            extTest = extReport.CreateTest("Fahrenheit átváltása celsiusra");
            var homerseklet = driver.FindElementByAccessibilityId("homersekletErtek");
            homerseklet.Clear();
            driver.FindElementByAccessibilityId("celsiusKivalaszt").Click();
            homerseklet.SendKeys(fahrenheit.ToString());
            driver.FindElementByAccessibilityId("buttonKonvertalas").Click();
            var eredmeny=driver.FindElementByAccessibilityId("konvertaltHomerseklet");


            Assert.AreEqual(elvart,Convert.ToDouble(eredmeny.Text),0.0005);
            extTest.Log(Status.Pass, "Fahrenheit átváltása celsiusra OK");
        }

        [Test]
        [TestCase(33, 87.8)]
        [TestCase(31,87.8)]
        [TestCase(22, 71.6)]
        public void FahrenheitTest(double celsius,double elvart)
        {
            extTest = extReport.CreateTest("Celsius átváltása fahrenheitre");
            var homerseklet = driver.FindElementByAccessibilityId("homersekletErtek");
            homerseklet.Clear();
            driver.FindElementByAccessibilityId("fahrenheitKivalaszt").Click();
            homerseklet.SendKeys(celsius.ToString());
            driver.FindElementByAccessibilityId("buttonKonvertalas").Click();
            var eredmeny = driver.FindElementByAccessibilityId("konvertaltHomerseklet");


            Assert.AreEqual(elvart, Convert.ToDouble(eredmeny.Text), 0.0005);
            extTest.Log(Status.Pass, "Celsius átváltása Fahrenheitre OK");
        }

        [TearDown]
        public static void CloseReport()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = TestContext.CurrentContext.Result.StackTrace;
            var errormsg = TestContext.CurrentContext.Result.Message;

            if (status==TestStatus.Failed)
            {
                ITakesScreenshot shot = (ITakesScreenshot)driver;

                var be = TestContext.CurrentContext.Test.Arguments[0];
                var elvart= TestContext.CurrentContext.Test.Arguments[1];
                var filename = $"result_{be}_{elvart}.png";

                Screenshot screenshot = shot.GetScreenshot();
                screenshot.SaveAsFile(WPFProgramPath + filename, ScreenshotImageFormat.Png);

                extTest.Log(Status.Fail, stacktrace + " " + errormsg);
                extTest.Log(Status.Fail, "Képernyõ");
                extTest.AddScreenCaptureFromPath(filename);
            }

            extReport.Flush();
        }


        [OneTimeTearDown]
        public void Endtest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}