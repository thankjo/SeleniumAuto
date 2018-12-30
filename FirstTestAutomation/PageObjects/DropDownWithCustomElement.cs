using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FirstTestAutomation.PageObjects
{
    class DropDownWithCustomElement
    {
        private readonly IWebDriver _driver;

        public DropDownWithCustomElement(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void LoadForm()
        {
            _driver.Url = "http://formy-project.herokuapp.com/dropdown";
        }

        [FindsBy(How = How.Id, Using = "dropdownMenuButton")]
        IWebElement button;

        
        [FindsBy(How = How.XPath, Using = @"/html/body/div/div/div")]
        IWebElement dropdownDiv;

        
        public void SelectDropDown(string linkText,string url)
        {
            button.Click();
            ReadOnlyCollection<IWebElement> collectionofAnchor= dropdownDiv.FindElements(By.ClassName("dropdown-item"));
            foreach (IWebElement itemAnchor in collectionofAnchor)
            {
                if(itemAnchor.Text.ToLower().Equals(linkText.ToLower()))
                {
                    itemAnchor.Click();
                    WebDriverWait wait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(10));
                    wait.Until(d => d.FindElement(By.TagName("html")));
                    Assert.AreEqual(url, _driver.Url);
                    break;
                }
            }           
        }

    }
}
