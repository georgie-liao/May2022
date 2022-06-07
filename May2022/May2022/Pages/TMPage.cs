using May2022.Utilities;
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
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Identify Create New button and click 
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]", 5);

            // Identify TyepCode dropdown button and click
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();
            Thread.Sleep(1000);

            // Identify Material button and click 
            IWebElement materialButton = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            materialButton.Click();
            Thread.Sleep(1000);

            // Identify Code textbox and enter code
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("may2022");
            Thread.Sleep(1000);

            // Identify Description textbox and etner description
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("may2022");
            Thread.Sleep(1000);

            // Identify Price Per Unit textbox and enter price
            IWebElement priceInputTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceInputTag.Click();

            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
            priceTextBox.SendKeys("20.22");
            Thread.Sleep(1000);

            // Idenify Save button and click
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            saveButton.Click();
            Thread.Sleep(1000);

            // Identify last page button and click
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPage.Click();
            Thread.Sleep(2000);

            // Identify the newly created record
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Assert 2
            Assert.That(newCode.Text == "may2022", "Actual record and expected record do not match.");
            Assert.That(newTypeCode.Text == "M", "Actual record and expected record do not match.");
            Assert.That(newDescription.Text == "may2022", "Actual record and expected record do not match.");
            Assert.That(newPrice.Text == "$20.22", "Actual record and expected record do not match.");


        }
        public void EditTM(IWebDriver driver)
        {
            Thread.Sleep(2000);

            // Identify last page button and click
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPage.Click();
            Thread.Sleep(2000);

            IWebElement findNewRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            if(findNewRecord.Text == "may2022")
            {
                // Click on edite button 
                IWebElement editeButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editeButton.Click();
                Thread.Sleep(2000);
            }
            else
            {
                Assert.Fail("Record to be edited not found");
            }

            

            // Choose time option from TypeCode dropdown 
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]"));
            typeCodeDropdown.Click();
            Thread.Sleep(1000);

            IWebElement materialButton = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            materialButton.Click();
            Thread.Sleep(1000);

            // Clear code textbox and enter new code 
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.Clear();
            codeTextBox.SendKeys("editMay2022");
            Thread.Sleep(1000);

            // Clear description textbox and enter new description
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys("editMay2022");
            Thread.Sleep(1000);

            // Clear price textbox and enter new price
            IWebElement editPriceInputTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            editPriceInputTag.Click();

            IWebElement editPriceTextbox = driver.FindElement(By.Id("Price"));
            editPriceTextbox.Clear();
            editPriceInputTag.SendKeys("202");
            Thread.Sleep(1000);


            // Identify and click on save button 
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            saveButton.Click();
            Thread.Sleep(1000);

            // Identify last page button and click
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(1000);

            // Identify the newly created record
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastRecord.Text == "editMay2022")
            {
                Console.WriteLine("New record edited successfully");
            }
            else
            {
                Console.WriteLine("Failed to edit record");
            }

        }

        public void DeleteTM(IWebDriver driver)
        {
            // Identify last page button and click
            Thread.Sleep(1000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(1000);


            // Identify delete button and click
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            lastRecord.Click();
           
            Thread.Sleep(1000);

            driver.SwitchTo().Alert().Accept();

            // Identify last page button and click
            IWebElement theLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            theLastPageButton.Click();
            Thread.Sleep(1000);

            IWebElement thelastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            // Assertion
            Assert.That(thelastRecord.Text != "editMay2022", "Time and material record has been deleted successfully.");

        }

    }
}
