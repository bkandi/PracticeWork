using System;
using ESPN.Utils;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using ESPN.Utils;
using ESPN.Pages;

namespace ESPN.Tests
{

    [TestFixture]
    public class BaseTest: ExtendedReports
    {
        public AndroidApp app;

       public LoginPage LoginPagewithFacebook;
        public MenuPage Menupagedata;
        public MenuSearchPage menusearchpage;
        public SettingsPage settingsPage;
        public void StartApp()
        {
            Properties config = new Properties("c:\\users\\bhavani.kandi\\documents\\visual studio 2015\\Projects\\ESPN\\ESPN\\TestData\\TestData.Properties");
            string apkPath = config.get("apkPath");

          app= ConfigureApp
             .Android
             .ApkFile(apkPath)
             .EnableLocalScreenshots()
             .StartApp();
        }
        [SetUp]
        public virtual void BeforeEachTest()
        {
            StartApp();
             LoginPagewithFacebook = new LoginPage(app);
            Menupagedata = new MenuPage(app);
            menusearchpage = new MenuSearchPage(app);
            settingsPage = new SettingsPage(app);
        }
       
    }
}
