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
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
        // page object intilization

        TMPage tmPagObj = new TMPage();
        HomePage homepageObj = new HomePage();



        [Test, Order(1), Description("Create Time and Material record with valid data")]
        public void CreatTM()
        {

            // Home page object initialization and definition 
            homepageObj.GoToTMPage(driver);


            // TM page object initialization and definition 
            tmPagObj.CreateTM(driver);

        }

        [Test, Order(2), Description("Edit Time and Material created in test number 1")]
        public void EditTM()
        {
            // Home page object initialization and definition 
            homepageObj.GoToTMPage(driver);


            // Edit TM
            tmPagObj.EditTM(driver);

        }

        [Test, Order(3), Description("Delete Time and Material record edited in test number 2")]
        public void DeleteTM()
        {


            // Delete TM
            tmPagObj.DeleteTM(driver);
        }


    }

}




 

   
    
   
