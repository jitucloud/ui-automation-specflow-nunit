using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace Automation.Core.Pages
{
    public enum BrowerType
    {
        Chrome,
        Firefox,
        IE
    }

    public class PageBase : Base
    {
        public PageBase(IWebDriver driver)
        {
            _driver = driver;
        }

        public PageBase()
        {
            ChooseDriverInstance(BrowerType.Chrome);
        }

        private void ChooseDriverInstance(BrowerType browserType)
        {
            if (browserType == BrowerType.Chrome)
            {
                var options = new ChromeOptions();
             //   options.AddArguments("headless");
                _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembl‌​y().Location), options);
            }
            else if (browserType == BrowerType.Firefox)
                _driver = new ChromeDriver();
        }

        public void CloseBrowser()
        {
            _driver.Quit();
        }

    }
}
