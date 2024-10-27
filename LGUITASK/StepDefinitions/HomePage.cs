﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAUCEDEMOUITASK.StepDefinitions
{
    public class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver _driver)
        {
            driver = _driver;
        }

        //Method 
        public void NavigateSDEMOSite(string SDEMOUrl) => driver.Navigate().GoToUrl(Environemt.SauceDemo_Url);
        
        public void EnterUsername()
        {
            var usernameText = driver.FindElement(By.XPath("//input[@id='user-name']"));
            usernameText.SendKeys("standard_user");
        }


        public void EnterPassWord()
        {
            var passWordText = driver.FindElement(By.XPath("//input[@id='password']"));
            passWordText.SendKeys("secret_sauce");
        }

        public void ClickOnLoginButton()=>driver.FindElement(By.XPath("//input[@id='login-button']")).Click();

        public void ClickOnAddToCartButton() => driver.FindElement(By.XPath("//button[text()='Add to cart']")).Click();

        public void ClickOnShoppingCartBasket()=>driver.FindElement(By.XPath("//div[@class='shopping_cart_container']")).Click();

        public void ClickCheckOutButton()=>driver.FindElement(By.XPath("//button[@id='checkout']")).Click();    

        public bool VerifyCheckOutInformation()
        {

           string checkoutInformationText =  driver.FindElement(By.XPath("//span[text()='Checkout: Your Information']")).Text;
            return checkoutInformationText.Equals(checkoutInformationText);
           
        }
        

        

        
        
       
    }
}
