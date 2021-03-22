using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicTestFrameworkUsingSeleniumCsharp.Helpers;
using BasicTestFrameworkUsingSeleniumCsharp.PageObject;
using BasicTestFrameworkUsingSeleniumCsharp.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BasicTestFrameworkUsingSeleniumCsharp.Tests
{
    [TestFixture]
    
    public class Sample: Utilitiy
    {
        [Test]
        public void Launch() {
            var HomePage = new HomePage(Driver);
            HomePage.UserLogin();
        }
        [Test]
        public void Launch2()
        {

           // Driver.Navigate().GoToUrl("https://google.com");

        }
    }
}
