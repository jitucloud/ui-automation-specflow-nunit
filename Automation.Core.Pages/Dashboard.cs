using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.Core.Pages
{
    public class Dashboard : PageBase
    {
        public Dashboard(IWebDriver driver) : base(driver) { }

        [CacheLookup]
        public IWebElement txtUsername
        {
            get { return _driver.FindElement(By.Id("UserName")); }
        }


        public bool IsDashboardPage()
        {
            var dd = _driver.Title;
            return dd.Contains("Dashboard");
        }

        public void CleanUp()
        {
            this.CloseBrowser();
        }

    }
}
