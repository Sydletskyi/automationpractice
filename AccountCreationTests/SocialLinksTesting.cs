using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using automationpractice;

namespace AccountCreationTests
{

    [TestClass]
    public class SocialLinksTesting
    {

        [TestMethod]
        public void facebookButtonTest()
        {
            var socialLinks = new CheckSocialLinks();

            socialLinks.Initialize();

            Assert.IsTrue(socialLinks.ClickOnFacebook());

            socialLinks.DriverStop();
            
        }
    }
}
