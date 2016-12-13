using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Xamarin.UITest.Queries;
using System.Threading;

namespace ESPN.Tests
{
    class mytest: BaseTest
    {
        [Test]
        public void mytest1()
        {
          app.Repl();
            /* app.Tap(c => c.Id("btn_signin"));
             Thread.Sleep(100000);
            /*AppWebResult[] arrResultTest = app.Query(c => c.WebView().Css("DIV"));
             string s1 = arrResultTest[0].Id;
             string s2 = arrResultTest[0].Class;
             string s3 = arrResultTest[0].Html;
             string s4 = arrResultTest[0].TextContent;
             string s5 = arrResultTest[0].Value;
             Console.WriteLine("s1 id"+s1); Console.WriteLine("s2 class"+s2);
             Console.WriteLine("s3 html"+s3);
             Console.WriteLine("s4 TextContent" + s4);
             Console.WriteLine("s5 Value" + s5);
             app.EnterText(C => C.Css("#usernanerow"), "Bhavani");
             app.EnterText(C => C.Css("#passwordrow"), "Bhavani");*/
          /* Menupagedata.clickSignuplater();
            Menupagedata.clickESPNlogo();
            Menupagedata.readESPNlogodata();
            Menupagedata.getsubmenusportslinkdata();*/
        }
    }
}
 