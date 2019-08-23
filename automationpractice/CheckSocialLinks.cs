using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace automationpractice
{
    public class CheckSocialLinks
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

        //public Func<IWebDriver, bool> UrlToBe(string url)
        //{
        //    return (driver) => { return driver.Url.ToLowerInvariant().Equals(url.ToLowerInvariant()); };
        //}


        public bool ClickOnFacebook ()
        {
            var facebookButton = driver.FindElement(By.ClassName("facebook"));
            facebookButton.Click();

            string urlToCheck = "https://www.facebook.com/groups/525066904174158/";

            driver.SwitchTo().Window(driver.WindowHandles.LastOrDefault());

            Console.WriteLine(driver.Url);
            if (driver.Url == urlToCheck)
            
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
