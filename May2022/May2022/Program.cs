using System;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Chrome;




namespace May2022
{
    internal class program
    {
        static void Main(string[] args)
        {
            // Open Chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Lauch turn up portal 
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            
            // Identify username textbox and valid enter username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // Identify password textbox and valid enter password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // Identify log in button and click
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(1500);

            // Identify and see if user has successfully loged in 

            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if(helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Login successfully!");
            }
            else
            {
                Console.WriteLine("Login failed");
            }

            // Identify Administration button and click 
            IWebElement adminButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminButton.Click();

            // Identify Time & Material button and click
            IWebElement tmButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmButton.Click();

            // Identify Create New button and click 
            IWebElement creatNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            creatNewButton.Click();

            // Identify TyepCode dropdown button and click
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]"));
            typeCodeDropdown.Click();

            // Identify Material button and click 
            IWebElement materialButton = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            materialButton.Click();

            // Identify Code textbox and enter code
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("may2022");

            // Identify Description textbox and etner description
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("may2022");

            // Identify Price Per Unit textbox and enter price
            IWebElement priceTextBox = driver.FindElement(By.Id(""))

            // Idenify Save button and click


        }
    }
}
