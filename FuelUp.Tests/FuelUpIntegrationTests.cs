using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FuelUp.Tests
{
    [TestFixture]
    class FuelUpIntegrationTests
    {
        private String baseurl = "http://fuelup.us-west-2.elasticbeanstalk.com/";
        private RemoteWebDriver driver;

        [TestCase]
        [Category("Integration")]
        public void OpenSite()
        {
            var siteUp = false;

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            driver.Navigate().GoToUrl(baseurl);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));

            siteUp = driver.FindElementById("about")!= null;
        }

        [TearDown]
        public void MyTestCleanup()
        {
            driver.Quit();
        }

        [SetUp]
        public void MyTestInitialize()
        {
            driver = new ChromeDriver();
        }
    }
}
