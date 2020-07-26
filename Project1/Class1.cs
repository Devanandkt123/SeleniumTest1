using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    [TestFixture]
    public class Class1
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\LENOVO\Downloads\chromedriver_win32 (1)");
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("Https://WWW.Google.Com");

        }
        [Test]
        public void Test1()
        {
            IWebElement searchtextbox = driver.FindElement(By.Name("q"));
            searchtextbox.SendKeys("Selenium by C#");
            Console.WriteLine("Google search text entered!!!");
            searchtextbox.SendKeys(Keys.Enter);
            var title = driver.Title.ToString();
            Assert.AreEqual("Selenium by C# - Google Search", title);
            Console.WriteLine("Google search done successfully!!");
        }
        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }

    }
}
