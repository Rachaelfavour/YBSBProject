using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using YBSBProject.PageObjects;

namespace YBSBProject.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage = new LoginPage();


        [Given(@"I navigate to the site ""(.*)""")]
        public void GivenINavigateToTheSite(string url)
        {
            loginPage.Navigate(url);
        }


        [When(@"I click on Sign in")]
        public void WhenIClickOnSignIn()
        {
           loginPage.SignIn();
        }

        [When(@"I Click Sign in with IMDb")]
        public void WhenIClickSignInWithIMDb()
        {
          loginPage.SignInWithIMDb();
        }



        [When(@"I enter email address ""(.*)""")]
        public void WhenIEnterEmailAddress(string emailtxt)
        {
           loginPage.TypeEmail(emailtxt);
        }

        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string passwordtxt)
        {
            Thread.Sleep(5000);
            loginPage.TypePassword(passwordtxt);
        }


        [When(@"I click on Sign button")]
        public void WhenIClickOnSignButton()
        {
            loginPage.SubmitButton();
        }
      
        
       


        [When(@"I enter invalid password ""(.*)""")]
        public void WhenIEnterInvalidPassword(string passwordtxt)
        {
           loginPage.TypePassword(passwordtxt);
        }

       

        [Then(@"I logged in and Kome displayed successfully")]
        public void ThenILoggedInAndKomeDisplayedSuccessfully()
        {
            Assert.IsTrue(loginPage.KomeDisplayedSuccessfully());
        }

        [Then(@"there was a problem displayed")]
        public void ThenThereWasAProblemDisplayed()
        {
            Assert.IsTrue(loginPage.ThereWasAProblem());
        }




    }
}
