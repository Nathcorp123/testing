using finalspecflow.POM;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace finalspecflow.Steps
{
    [Binding]
    public class ToTestLoginFunctionalityForOrangeHRmApplicationSteps
    {
        pom Call = new pom();

        [Given(@"Launch the browser and open the url")]
        public void GivenLaunchTheBrowserAndOpenTheUrl()
        {
            Call.clickLogin();
            Thread.Sleep(3000);
        }
        
        [Given(@"Enter the valid userid (.*) and password(.*)")]
        public void GivenEnterTheValidUseridAndPassword(string emailid, string password)
        {
            Call.enterEmail(emailid, password);
            Thread.Sleep(3000);
        }
        
        [When(@"Click on login button")]
        public void WhenClickOnLoginButton()
        {
            Call.login();
            Thread.Sleep(3000);
        }
        
        [Then(@"User should be sucessfully redirected to home page of application")]
        public void ThenUserShouldBeSucessfullyRedirectedToHomePageOfApplication()
        {
            Console.WriteLine("Welcome to home page");
        }
    }
}
