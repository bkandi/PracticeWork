using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RelevantCodes.ExtentReports;

namespace ESPN.Tests
{
   public  class MenuSearchTest: BaseTest
    {
        [Test]
        public void MenuSearchTestaction()
        {
            test = extent.StartTest("Menusearch", "Identifying the games menu search");
            Menupagedata.clickSignuplater();
            menusearchpage.clicksearchbutton();
            menusearchpage.Entertextinmenusearchbox();
            test.Log(LogStatus.Pass, "Pass");
        }
    }
}
