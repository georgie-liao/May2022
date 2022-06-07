using May2022.Pages;
using May2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employe_Tests : CommonDriver
    {
        // page objects initialization
        HomePage homepageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();



        [Test, Order(1), Description("Create new employee record with valid data")]
        public void CreateEmployee()
        {
            homepageObj.GoToEmployeePage(driver);
            employeePageObj.CreateEmployee(driver);

        }

        [Test, Order(2), Description("Edit employee record created in test number 1")]
        public void EditeEmployee()
        {
            homepageObj.GoToEmployeePage(driver);
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order(3), Description("Delete employee record edited in test number 2")]
        public void DeleteEmployee()
        {
            homepageObj.GoToEmployeePage(driver);
            employeePageObj.DeleteEmployee(driver);
        }

    }
}
