using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationAprilCohort.Utilities;

namespace TestAutomationAprilCohort.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage() 
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.CssSelector("input[type='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));


        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername()
        {
            Username.SendKeys("Learnwithpride1234");
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

        public void EnterEmail()
        {
            Email.SendKeys("abc123@lwp.com");
        }

        public void EnterPassword()
        {
            Password.SendKeys("PasswordSecure");
        }

        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }

        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }











    }
}
