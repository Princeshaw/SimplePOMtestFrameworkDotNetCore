using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace BasicTestFrameworkUsingSeleniumCsharp.PageObject
{
    public class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How=How.PartialLinkText,Using ="Home")]
        public IWebElement HomeLink { get; set; }

        [FindsBy(How = How.PartialLinkText,Using ="Log in")]
        public IWebElement LoginLink { get; set; }

        [FindsBy(How = How.Id, Using = "loginusername")]
        public IWebElement UserInput  { get; set; }

        [FindsBy(How = How.Id, Using = "loginpassword")]
        public IWebElement UserPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Log in']")]
        public IWebElement LoginButton { get; set; }
        public void UserLogin() {
            LoginLink.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(UserInput));
            UserInput.SendKeys("TestId");
            wait.Until(ExpectedConditions.ElementToBeClickable(UserPassword));
            UserPassword.SendKeys("testing");
            LoginButton.Click();

        }

    }
}
