using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FirstTestAutomation.PageObjects
{
    class CheckBox
    {
        private readonly IWebDriver _driver;

        public CheckBox(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void LoadForm()
        {
            _driver.Url = "http://formy-project.herokuapp.com/checkbox";
        }
        [FindsBy(How = How.Id, Using = "checkbox-2")]
        IWebElement checkbox2;
        [FindsBy(How = How.Id, Using = "checkbox-1")]
        IWebElement checkbox1;
        [FindsBy(How = How.Id, Using = "checkbox-3")]
        IWebElement checkbox3;


        public void FillCheckBox()
        {
            checkbox2.Click();
            checkbox1.Click();
            checkbox3.Click();

        }
    }
}
