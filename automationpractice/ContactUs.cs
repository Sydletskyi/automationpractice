using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;   
using OpenQA.Selenium.Support.UI;

namespace automationpractice
{
    public class ContactUs
    {
        static IWebDriver driver;
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

        public void EmptyMessageErrorCheck ()
        {
            var contactUsButton = driver.FindElement(By.Id("contact-link"));
            contactUsButton.Click();

            var chooseSubjectHeading = driver.FindElement(By.XPath("//*[@id=\"id_contact\"]"));

            SelectElement select = new SelectElement(chooseSubjectHeading);
            select.SelectByText("Customer service");
            
        }
    }
}
