using Automation.Core.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automation.Web.Steps.login
{
    [Binding]
    public class LoginSteps
    {
        private Login loginPage;
        private Dashboard dashboardPage;
      
        public LoginSteps()
        {
            loginPage = new Login();
        }

        [Given(@"Go to the login page")]
        public void GivenGoToTheLoginPage()
        {
            loginPage.OpenLogin();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            loginPage.LoginAs("admin", "admin");
        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            dashboardPage = loginPage.LoginSubmit();
        }

        [Then(@"I should see user logged in")]
        public void ThenIShouldSeeUserLoggedIn()
        {

            Assert.AreEqual(dashboardPage.IsDashboardPage(), true);
            loginPage.CleanUp();

        }

    }
}
