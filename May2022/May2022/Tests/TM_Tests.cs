using System;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Chrome;
using May2022.Pages;
using NUnit.Framework;
using May2022.Utilities;

namespace May2022
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void LoginActions()
        {
            // Open chrome browser
          driver = new ChromeDriver();

            // Login page object initialization and definition 
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.LoginSteps(driver);

            // Home page object initialization and definition 
            HomePage homepageObj = new HomePage();
            homepageObj.GoToTMPage(driver);
        }
        [Test, Order(1), Description("Create Time and Material record with valid data")]
        public void CreatTM()
        {
            // TM page object initialization and definition 
            TMPage tmPagObj = new TMPage();
            tmPagObj.CreateTM(driver);

        }
        [Test, Order(2), Description("Edit Time and Material created in test number 1")]
        public void EditTM()
        {
            // Edit TM
            TMPage tmPagObj = new TMPage();
            tmPagObj.EditTM(driver);

        }
        [Test, Order(3), Description("Delete Time and Material record edited in test number 2")]
        public void DeleteTM()
        {
            // Delete TM
            TMPage tmPagObj = new TMPage();
            tmPagObj.DeleteTM(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {

        }
    }

}




 

   
    
   
