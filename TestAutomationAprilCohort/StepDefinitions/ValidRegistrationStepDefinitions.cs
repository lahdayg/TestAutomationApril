using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationAprilCohort.PageObject;

namespace TestAutomationAprilCohort.StepDefinitions
{
    [Binding]
    public class ValidRegistrationStepDefinitions
    {
        RegistrationPage registrationPage;

        public ValidRegistrationStepDefinitions()
        { 
            registrationPage= new RegistrationPage();

        }





        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I click on Sign up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.ClickOnSignUp();
        }

        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            registrationPage.EnterUsername();
        }

        [Given(@"I enter my email")]
        public void GivenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }

        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }

        [When(@"I click on the Sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            registrationPage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsNewArticleDisplayed);
        }

        [Given(@"I forgot to add something")]
        public void GivenIForgotToAddSomething()
        {
            throw new PendingStepException();
        }

    }
}
