using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Android;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
namespace ESPN.Tests
{
   public class MenuTest:BaseTest
    {
        [Test]
        public void  MenulistTest()
        {
            test = extent.StartTest("Menulist", "Identifying the games menu list");
            Menupagedata.clickSignuplater();
             Menupagedata.clickESPNlogo();
            Menupagedata.readESPNlogodata();
            Menupagedata.getsubmenusportslinkdata();
            test.Log(LogStatus.Pass, "pass");
        }
    }
}
