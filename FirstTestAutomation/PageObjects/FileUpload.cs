
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FirstTestAutomation.PageObjects
{
    class FileUpload
    {
        private readonly IWebDriver _driver;

        public FileUpload(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void LoadForm()
        {
            _driver.Url = "http://formy-project.herokuapp.com/fileupload";
        }

        [FindsBy(How = How.Id, Using = "file-upload-field")]
        IWebElement fileupload;

        public void UploadForm()
        {
            fileupload.Click();
            System.Threading.Thread.Sleep(1000);
            System.Windows.Forms.SendKeys.SendWait(@"C:\Workspace_Smitha\files\2K-wallpaper.jpg");
            System.Threading.Thread.Sleep(1000);
            System.Windows.Forms.SendKeys.SendWait("{Enter}");
        }
    }
}
