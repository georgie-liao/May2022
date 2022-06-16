using May2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.Pages
{
    public class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            Thread.Sleep(1500);
            // Identify Create button and click 
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]", 5);
            Thread.Sleep(1500);

            // Identify Name textbox and enter name
            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("Hari TestName");
            Thread.Sleep(1000);


            // Identify Username textbox and enter name
            IWebElement usernameTextBox = driver.FindElement(By.Id("Username"));
            usernameTextBox.SendKeys("usernameHari123");
            Thread.Sleep(1000);

            //------------------ Contact ------------------------------------
            // Identify Edit Contact button and click
            IWebElement editContactButton = driver.FindElement(By.XPath("//*[@id='EditContactButton']"));
            editContactButton.Click();
            Thread.Sleep(2000);

            // Navigate to the pop up window
            driver.SwitchTo().Frame(0);


            // Identify Contact form and enter valid information
            // First name
            IWebElement firstName = driver.FindElement(By.Id("FirstName"));
            firstName.SendKeys("Harison");

            //Last name
            IWebElement lastName = driver.FindElement(By.Id("LastName"));
            lastName.SendKeys("LastName");

            // Prefered name
            IWebElement preferedName = driver.FindElement(By.Id("PreferedName"));
            preferedName.SendKeys("Hari");

            // Phone
            IWebElement phone = driver.FindElement(By.Id("Phone"));
            phone.SendKeys("09123456");

            // Mobile
            IWebElement moblie = driver.FindElement(By.Id("Mobile"));
            moblie.SendKeys("021052022");

            // Email
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("hari123@gmail.com");

            // Fax
            IWebElement fax = driver.FindElement(By.Id("Fax"));
            fax.SendKeys("123456");

            // Street
            IWebElement street = driver.FindElement(By.Id("Street"));
            street.SendKeys("123 Queen Street");

            // City
            IWebElement city = driver.FindElement(By.Id("City"));
            city.SendKeys("Auckland");

            // Postcode
            IWebElement postCode = driver.FindElement(By.Id("Postcode"));
            postCode.SendKeys("1011");

            // Postcode
            IWebElement country = driver.FindElement(By.Id("Country"));
            country.SendKeys("New Zealand");

            // identify Save contact button and click

            IWebElement contactSaveButton = driver.FindElement(By.XPath("//*[@id='submitButton']"));
            contactSaveButton.Click();
            Thread.Sleep(1000);

            //Retrun to main page
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);

            //--------------------------------------------------------------

            Thread.Sleep(1500);
            // Identify Password textbox and enter name
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("Password123!");
            Thread.Sleep(1000);

            // Identify RetypePassword textbox and enter name
            IWebElement retypePasswordTextBox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextBox.SendKeys("Password123!");
            Thread.Sleep(2000);

            // Identify IsAdmin tickbox and click
            IWebElement isAdminTickbox = driver.FindElement(By.XPath("//*[@id='IsAdmin']"));
            isAdminTickbox.Click();
            Thread.Sleep(2000);


            // Identify vehicle textbox and enter vehicle information
            IWebElement vehicleInputTag = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));

            vehicleInputTag.SendKeys("Brand: Tesla , Color: Silver , Plate: ABC123");
            Thread.Sleep(2000);


            // Identify group dropdown button and click to choose option
            IWebElement groupDropdown = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groupDropdown.Click();                                   
            Thread.Sleep(2000);

            IWebElement groupOptions = driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[74]"));
            groupOptions.Click();
            Thread.Sleep(1000);

            // Click group dropdown again to choose another option
            groupDropdown = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groupDropdown.Click();
            Thread.Sleep(1000);

            groupOptions = driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[75]"));
            groupOptions.Click();
            Thread.Sleep(1000);

            // Identify save button and click 
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            saveButton.Click();
            Thread.Sleep(2000);


            // Identify Back to List and click
            IWebElement backToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToList.Click();
            Thread.Sleep(2000);

            // Identify go to last page button and click
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            goToLastPage.Click();
            Thread.Sleep(2000);

            // Identify the new employee record created successfuly
            IWebElement newNameTextBox = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newUsernameTextBox = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));


            // Assert 2
            Assert.That(newNameTextBox.Text == "Hari TestName", "Actual record and expected record do not match.");
            Assert.That(newUsernameTextBox.Text == "usernameHari123", "Actual record and expected record do not match.");

        }
        public void EditEmployee(IWebDriver driver)
        {
            // Identify the newly created employee detials 
            // Go to last page
            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            LastPage.Click();
            Thread.Sleep(2000);
            
            // Find if the newly created employee details from Step 1: CreatEmployee 
            IWebElement findNewRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            Thread.Sleep(1000);

            if (findNewRecord.Text == "usernameHari123")
            {
                // Click on edite button 
                IWebElement editeButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                editeButton.Click();
                Thread.Sleep(2000);
            }
            else
            {
                Assert.Fail("Record to be edited not found");
            }

            // Edit name
            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.Clear();
            nameTextBox.SendKeys("Hari EditedName");
            Thread.Sleep(1000);


            // Edite username
            IWebElement usernameTextBox = driver.FindElement(By.Id("Username"));
            usernameTextBox.Clear();
            usernameTextBox.SendKeys("EditedUsernameHari123");
            Thread.Sleep(1000);

            //------------------ Edit Contacts ------------------------------------
            // Identify Edit Contact button and click
            IWebElement editContactButton = driver.FindElement(By.XPath("//*[@id='EditContactButton']"));
            editContactButton.Click();
            Thread.Sleep(2000);

            // Navigate to the pop up window
            driver.SwitchTo().Frame(0);


            // Edit First name
            IWebElement editedFirstName = driver.FindElement(By.Id("FirstName"));
            editedFirstName.Clear();
            editedFirstName.SendKeys("EditedFirstNameHarison");

            // Edit Last name
            IWebElement editedLastName = driver.FindElement(By.Id("LastName"));
            editedLastName.Clear();
            editedLastName.SendKeys("EditedLastName");

            // Edit  Prefered name
            IWebElement editedPreferedName = driver.FindElement(By.Id("PreferedName"));
            editedPreferedName.Clear();
            editedPreferedName.SendKeys("Hari");

            // Edit Phone
            IWebElement editedPhone = driver.FindElement(By.Id("Phone"));
            editedPhone.Clear();
            editedPhone.SendKeys("098745654321");

            // Edit Mobile
            IWebElement editedMoblie = driver.FindElement(By.Id("Mobile"));
            editedMoblie.Clear();
            editedMoblie.SendKeys("021020202");

            // Edit Email
            IWebElement editedEmail = driver.FindElement(By.Id("email"));
            editedEmail.Clear();
            editedEmail.SendKeys("123hari@gmail.com");

            // Edit Fax
            IWebElement editedFax = driver.FindElement(By.Id("Fax"));
            editedFax.Clear();
            editedFax.SendKeys("654321");

            // Edit Street
            IWebElement editedStreet = driver.FindElement(By.Id("Street"));
            editedStreet.Clear();
            editedStreet.SendKeys("123 King Street");

            // Edit City
            IWebElement edtiedCity = driver.FindElement(By.Id("City"));
            edtiedCity.Clear();
            edtiedCity.SendKeys("Wellington");

            // Edit Postcode
            IWebElement editedPostCode = driver.FindElement(By.Id("Postcode"));
            editedPostCode.Clear();
            editedPostCode.SendKeys("2022");

            // Edit Postcode
            IWebElement editedCountry = driver.FindElement(By.Id("Country"));
            editedCountry.Clear();
            editedCountry.SendKeys("Zealand New");

            // Save edtied contacts by click Save button

            IWebElement contactSaveButton = driver.FindElement(By.XPath("//*[@id='submitButton']"));
            contactSaveButton.Click();
            Thread.Sleep(1000);

            //Retrun to main page
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);

            //--------------------------------------------------------------

            Thread.Sleep(1500);
            // Edit password
            IWebElement editedPassword = driver.FindElement(By.Id("Password"));
            editedPassword.Clear();
            editedPassword.SendKeys("EditedPassw0rd!");
            Thread.Sleep(1000);

            // Identify edited password
            IWebElement retypeEditedPassword = driver.FindElement(By.Id("RetypePassword"));
            retypeEditedPassword.Clear();
            retypeEditedPassword.SendKeys("EditedPassw0rd!");
            Thread.Sleep(2000);

            // Identify IsAdmin tickbox and click
            IWebElement isAdminTickbox = driver.FindElement(By.XPath("//*[@id='IsAdmin']"));
            isAdminTickbox.Click();
            Thread.Sleep(2000);


            // Edit Vihicle information
            IWebElement editedVehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));

            editedVehicle.SendKeys("Brand: BMW , Color: Blue , Plate: CDF456");
            Thread.Sleep(2000);

            // Click group dropdown again to select groups
            IWebElement groupDropdown = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groupDropdown.Click();
            Thread.Sleep(1000);


            // Unselect current groups
            IWebElement currentgroup = driver.FindElement(By.XPath("//*[@id='groupList_taglist']/li[1]/span[2]"));
            currentgroup.Click();
            Thread.Sleep(1000);
            currentgroup = driver.FindElement(By.XPath("//*[@id='groupList_taglist']/li[1]/span[2]"));
            currentgroup.Click();
            Thread.Sleep(1000);

            // Click on group dropdown to select a group
            groupDropdown = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groupDropdown.Click();
            Thread.Sleep(1000);

            // Select group 1
            IWebElement groupOptions = driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[13]"));
            groupOptions.Click();                       
            Thread.Sleep(1000);

            // Click on group dropdown to select another group
            groupDropdown = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groupDropdown.Click();
            Thread.Sleep(1000);

            // Select group 2
            groupOptions = driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[24]"));
            groupOptions.Click();
            Thread.Sleep(1000);

            // Save changed details by click Save button 
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            saveButton.Click();
            Thread.Sleep(2000);

            // Identify if information has been edited sucessfully
            // Identify Back to List and click
            IWebElement backToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToList.Click();
            Thread.Sleep(2000);

            // Identify go to last page button and click
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            goToLastPage.Click();
            Thread.Sleep(3000);

            // Identify the new employee record created successfuly
            IWebElement editedName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));


            // Assert 2
            Assert.That(editedName.Text == "Hari EditedName", "Actual record and expected record do not match.");
            Assert.That(editedUserName.Text == "EditedUsernameHari123", "Actual record and expected record do not match.");



        }
        public void DeleteEmployee(IWebDriver driver)
        {
            // Identify last page button and click
            Thread.Sleep(1000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(1000);


            // Identify delete button and click
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            lastRecord.Click();

            Thread.Sleep(1000);

            driver.SwitchTo().Alert().Accept();

            // Identify last page button and click
            lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(3000);

            IWebElement theLastRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);

            // Assertion
            Assert.That(theLastRecord.Text != "Hari EditedName", "Employee record has been deleted successfully.");

        }
    }
}

