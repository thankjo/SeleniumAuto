using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace FirstTestAutomation.PageObjects
{
    class AutoComplete
    {
        private readonly IWebDriver _driver;

        public AutoComplete(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "autocomplete")]
        private IWebElement autocompletetextbox;

        [FindsBy(How = How.ClassName, Using = "pac-item")]
        private IWebElement autocompleteselector;

        public void FillTextbox()
        {
            autocompletetextbox.Clear();
            autocompletetextbox.SendKeys("1280 Massachusetts Avenue, Cambridge, MA, USA");
            Thread.Sleep(1000);
            autocompleteselector.Click();
        }

        public void LoadForm()
        {
            _driver.Url = "http://formy-project.herokuapp.com/autocomplete";
        }
    }
}
