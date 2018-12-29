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

        [NUnit.Framework.TestCase]
        public void ExecuteCheckboxesTest()
        {
            IWebDriver webdriver = new ChromeDriver();
            PageObjects.CheckBox checkBox = new PageObjects.CheckBox(webdriver);
            checkBox.LoadForm();
            checkBox.FillCheckBox();
            Thread.Sleep(2000);
            webdriver.Close();
        }

        [NUnit.Framework.TestCase]
        public void ExecuteDatePickerTest()
        {
            IWebDriver webdriver = new ChromeDriver();
            PageObjects.DatePicker datePicker = new PageObjects.DatePicker(webdriver);
            datePicker.LoadForm();
            datePicker.PickDate();
            Thread.Sleep(2000);
            webdriver.Close();
        }

        [NUnit.Framework.TestCase]
        public void ExecuteFileUploadTest()
        {
            IWebDriver webdriver = new ChromeDriver();
            PageObjects.FileUpload fileUpload = new PageObjects.FileUpload(webdriver);
            fileUpload.LoadForm();
            fileUpload.UploadForm();
            Thread.Sleep(5000);
            webdriver.Close();
        }
    }
}
