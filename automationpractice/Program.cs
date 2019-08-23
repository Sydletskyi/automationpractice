using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace automationpractice
{
    public class Program
    {

        static void Main(string[] args)
        {
            //RunTests();

            TestMethod();
        }

        static void RunTests ()
        {
            var account = new AccountCreation();
            account.Initialize();
            account.EnteringInvalidEmail();
            account.EnteringAlreadyUsedEmail();

            var social = new CheckSocialLinks();
            social.Initialize();
            social.ClickOnFacebook();
        }

        static void TestMethod ()
        {
            var contact = new ContactUs();
            contact.Initialize();
            contact.EmptyMessageErrorCheck();

        }
    }
}
