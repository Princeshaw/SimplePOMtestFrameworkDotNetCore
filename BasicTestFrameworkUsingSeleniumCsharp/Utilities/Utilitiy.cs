using BasicTestFrameworkUsingSeleniumCsharp.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace BasicTestFrameworkUsingSeleniumCsharp.Utilities
{
    
    [TestFixture]
    public class Utilitiy: BaseClass
    {
        [SetUp]
        public void LaunchApp() {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            Driver = new ChromeDriver(options);
            Driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
        }
        [TearDown]
        public void Close() {
            Driver.Quit();
        }
    }
}
