using System;
using Xamarin.UITest;
using System.Collections.Generic;
using LumenWorks.Framework.IO.Csv;
using System.Configuration;
using System.IO;
using ESPN.Utils;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using AppWebQuery= System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppWebQuery>;
using NUnit.Framework;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;


namespace ESPN.Pages
{
    public class LoginPage : Basepage
    {

        protected readonly Query WaitForElemet;           
        string Webviewpassword;
       public Query Verifytext;
        protected readonly AppWebQuery WebviewUserName;

        CSVreader csvreader;
        Dictionary<string, string> dict;
        public LoginPage(AndroidApp app):base(app)
        {
            csvreader = new CSVreader();
            dict = csvreader.reader();
            string WaitforElement1;
            dict.TryGetValue("Loginbuttowithwebview", out WaitforElement1);
            WaitForElemet = x => x.Id(WaitforElement1);
            string WebviewUserName1;
            dict.TryGetValue("Webviewusername", out WebviewUserName1);
            WebviewUserName = x => x.Css(WebviewUserName1);
            dict.TryGetValue("Webviewpasword", out Webviewpassword);
            
        }

        public void waitforelementmethod()
        {
            app.WaitForElement(WaitForElemet);
        }
        public void LoginwithFacebook()
        {
            app.Tap(WaitForElemet);
        }
        public void username()
        {
            app.EnterText(WebviewUserName, "Bhavani");
        }
        public void Password()
        {
            app.EnterText(x => x.Css(Webviewpassword), "Bhavani");
        }
    }

}
