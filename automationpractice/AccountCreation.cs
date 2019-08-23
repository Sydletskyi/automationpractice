using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace automationpractice
{
    public class AccountCreation
    {
        static IWebDriver driver;

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void DriverStop()
        {
            driver.Close();
        }

        public bool EnteringInvalidEmail ()
        {
            var SingInButton = driver.FindElement(By.XPath("//*[@class=\"login\"]"));
            SingInButton.Click();

            var CreateAnAccountButton = driver.FindElement(By.Id("SubmitCreate"));
            CreateAnAccountButton.Click();

            //if (IsElementPresent((By.Id("create_account_error"))))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            var invalidEmailMessage = driver.FindElement(By.XPath("//*[@id=\"create_account_error\"]/ol/li")).Text;
            if (invalidEmailMessage.Contains("Invalid email address."))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EnteringAlreadyUsedEmail()
        {
            var SingInButton = driver.FindElement(By.XPath("//*[@class=\"login\"]"));
            SingInButton.Click();

            var EmailAdressInputField = driver.FindElement(By.Id("email_create"));
            EmailAdressInputField.SendKeys("test@test.com");

            var CreateAnAccountButton = driver.FindElement(By.Id("SubmitCreate"));
            CreateAnAccountButton.Click();

            var alreadyUsedEmailMessage = driver.FindElement(By.XPath("//*[@id=\"create_account_error\"]/ol/li")).Text;
            if (alreadyUsedEmailMessage.Contains("this email address has already been registered"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
