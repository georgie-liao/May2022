using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
           

            // Identify Administration button and click 
            IWebElement adminButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminButton.Click();

            // Identify Time & Material button and click
            IWebElement tmButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmButton.Click();

        }

        public void GoToEmployeePage(IWebDriver driver)
        {
            // Identify Administration button and click 
            IWebElement adminButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminButton.Click();

            // Identify Time & Material button and click
            IWebElement employeeButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeButton.Click();


        }
    }
}
