using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SelenuimProject.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBSBProject.PageObjects
{
    class LoginPage
    {
        public IWebDriver driver;

        public LoginPage() 
        {
            driver = BaseTest.driver;
         
        }


        private By signIn = By.CssSelector("div.nav__userMenu.navbar__user.sc-jgPygj.ebbaoE > a");
        private By signInWithIMDbElement = By.CssSelector("#signin-options > div > div:nth-child(2) > a:nth-child(1)");
        private By typeEmailElement = By.XPath("//input[@type='email']");
        private By typePasswordElement = By.XPath("//input[@type='password']");
        private By clickSubmitButton = By.Id("signInSubmit");
        private By komeDisplayedSuccessfully = By.XPath("//span[@class='imdb-header__account-toggle--logged-in imdb-header__accountmenu-toggle navbar__user-name navbar__user-menu-toggle__name navbar__user-menu-toggle--desktop']");
        private By thereWasAProblem = By.CssSelector("#auth-error-message-box > div > h4");

         public void Navigate(string po)
            {
                driver.Navigate().GoToUrl(po);
            }

        public void SignIn()
        {
            driver.FindElement(signIn).Click();
        }



        public void SignInWithIMDb()
        {
            driver.FindElement(signInWithIMDbElement).Click();
        }

        public void TypeEmail(string emailtxt)

        {
                   
            driver.FindElement(typeEmailElement).SendKeys(emailtxt);
        }

        public void TypePassword(string passwordtxt)
        {
            driver.FindElement(typePasswordElement).SendKeys(passwordtxt);


        }


        public void SubmitButton()
        {
             driver.FindElement(clickSubmitButton).Click();

        }

        public bool KomeDisplayedSuccessfully()
        {
            return driver.FindElement(komeDisplayedSuccessfully).Displayed;
        }

        public bool ThereWasAProblem()
        {
            return driver.FindElement(thereWasAProblem).Displayed;
        }



    }
}

  
 