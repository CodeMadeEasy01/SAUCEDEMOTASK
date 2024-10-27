using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using SAUCEDEMOUITASK.StepDefinitions;
using System.Security.Policy;

namespace LGUITASK.StepDefinitions
{
    [Binding]
    public sealed class SDEMOUIStepDefinitions
    {
        IWebDriver driver;
        HomePage homePage;

        public SDEMOUIStepDefinitions(IObjectContainer container)
        {

            {
                // driver= container.Resolve<IWebDriver>();
                homePage = container.Resolve<HomePage>();

            }

        }

            [Given(@"I am on sauce demo site")]
            public void GivenIAmOnSauceDemoSite()
            {
                 homePage.NavigateSDEMOSite("SDEMOUrl");   
            }

            [Given(@"I enter accepted  username")]
            public void GivenIEnterAcceptedUsername()
            {
                 homePage.EnterUsername();
            }

            [Given(@"I enter accepted  password")]
            public void GivenIEnterAcceptedPassword()
            {
                homePage.EnterPassWord();   
            }

            [Then(@"I Click on Login Button")]
            public void ThenIClickOnLoginButton()
            {
               homePage.ClickOnLoginButton();
            }

        [Given(@"I Click on Login Button")]
        public void GivenIClickOnLoginButton()
        {
            homePage.ClickOnLoginButton();
        }

        [When(@"I click on Add to Cart Button")]
        public void WhenIClickOnAddToCartButton()
        {
            homePage.ClickOnAddToCartButton();
        }

        [Given(@"I click on Shopping Cart")]
        public void GivenIClickOnShoppingCart()
        {
            homePage.ClickOnShoppingCartBasket();
        }



        [Given(@"I click on CheckOut Button")]
        public void GivenIClickOnCheckOutButton()
        {
            homePage.ClickCheckOutButton();   
        }


        [Given(@"I click on Add to Cart Button")]
        public void GivenIClickOnAddToCartButton()
        {
            homePage.ClickOnAddToCartButton();
        }


        [Then(@"I successfully see check information displayed")]
        public void ThenISuccessfullySeeCheckInformationDisplayed()
        {
            Assert.IsTrue(homePage.VerifyCheckOutInformation());
        }


    }
}
