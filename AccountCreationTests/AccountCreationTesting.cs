using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using automationpractice;


namespace AccountCreationTests
{
    [TestClass]
    public class AccountCreationTesting
    {
        [TestMethod]
        public void EnteringInvalidEmail()
        {
            var account = new AccountCreation();
            account.Initialize();
            account.EnteringInvalidEmail();

            Assert.IsTrue(account.EnteringInvalidEmail());

            account.DriverStop();
            
        }

        [TestMethod]
        public void EnteringAreadyUsedEmail ()
        {
            var account = new AccountCreation();

            account.Initialize();
            account.EnteringAlreadyUsedEmail();

            Assert.IsTrue(account.EnteringAlreadyUsedEmail());

            account.DriverStop();
        }
    }
}
