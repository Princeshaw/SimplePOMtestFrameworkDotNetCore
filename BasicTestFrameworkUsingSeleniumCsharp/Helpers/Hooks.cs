using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTestFrameworkUsingSeleniumCsharp.Helpers
{

    public enum BrowerType
    {
        Chrome,
        Firefox,
        IE
    }
    [TestFixture]
    public class Hooks: BaseClass
    {
        private BrowerType _browserType;


            public Hooks(BrowerType browser)
            {
                _browserType = browser;
            }


            [SetUp]
            public void InitializeTest()
            {
                ChooseDriverInstance(_browserType);
            }

            private void ChooseDriverInstance(BrowerType browserType)
            {

                if (browserType == BrowerType.Chrome)
                    Driver = new ChromeDriver();
                else if (browserType == BrowerType.Firefox)
                {
                 
                }
            }

            [TearDown]
            public void CloseBrowser()
            {
                Driver.Quit();
            }


        }
}
