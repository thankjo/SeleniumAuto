using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FirstTestAutomation.PageObjects
{
    class DatePicker
    {
        private readonly IWebDriver _driver;

        public DatePicker(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void LoadForm()
        {
            _driver.Url = "http://formy-project.herokuapp.com/datepicker";
        }

        [FindsBy(How = How.Id, Using = "datepicker")]
        IWebElement datepicker;

        public void PickDate()
        {
            datepicker.SendKeys("03/14/2015");

        }
    }
}
