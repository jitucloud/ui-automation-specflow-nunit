using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation.Core.Pages
{
    public class Login : PageBase
    {
        public Login() { }
        public Login(IWebDriver driver) : base(driver) { }

        [CacheLookup]
        public IWebElement txtUsername
        {
            get { return _driver.FindElement(By.Id("UserName")); }
        }

        [CacheLookup]
        public IWebElement txtPassword
        {
            get { return _driver.FindElement(By.Id("Password")); }
        }


        public IWebElement btnLogin
        {
            get { return _driver.FindElement(By.Id("Login")); }
        }


        public void OpenLogin()
        {
            _driver.Navigate().GoToUrl("https://localhost:44311/Account/Login");
        }

        public void LoginAs(string username, string password)
        {
            txtUsername.SendKeys(username);
            txtPassword.SendKeys(password);
        }

        public Dashboard LoginSubmit()
        {
            btnLogin.Submit();
            return new Dashboard(_driver);
        }

        public void CleanUp()
        {
            this.CloseBrowser();
        }

    }

}
