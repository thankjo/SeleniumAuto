using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstTestAutomation
{
    public class Startup
    {
        [NUnit.Framework.TestCase]
        public void ExecuteAutoCompleteTest()
        {
            IWebDriver webdriver = new ChromeDriver();
            PageObjects.AutoComplete autoComplete = new PageObjects.AutoComplete(webdriver);
            autoComplete.LoadForm();
            autoComplete.FillTextbox();
            Thread.Sleep(2000);
            webdriver.Close();
        }
    }
}
