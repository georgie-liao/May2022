using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            // Maximize Chrome browser
            driver.Manage().Window.Maximize();

            // Lauch turn up portal 
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            try
            {
                // Identify username textbox and valid enter username
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");

                // Identify password textbox and valid enter password
                IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
                passwordTextbox.SendKeys("123123");

                // Identify log in button and click
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();

            }
            catch(Exception ex)
            {
                Assert.Fail("TurnUp portal page did not launch.", ex.Message);
            }
        
         

        }
    }
}
