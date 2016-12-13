using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using ESPN.Utils;
using RelevantCodes.ExtentReports;

namespace ESPN.Tests
{
    public class LoginTest:BaseTest
    {
        [Test]
        public void Login()
        {
            test = extent.StartTest("LoginPagewithWebview", "Verifying the login page whether user is able to identifying the elements using webviewmodel");
            LoginPagewithFacebook.waitforelementmethod();
            LoginPagewithFacebook.LoginwithFacebook();
            Thread.Sleep(100000);
            LoginPagewithFacebook.username();
            LoginPagewithFacebook.Password();
            test.Log(LogStatus.Pass, "pass");
        }
    }
}
