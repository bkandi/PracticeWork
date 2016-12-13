using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using NUnit.Framework;
namespace ESPN.Utils
{
   public class ExtendedReports
    {
        protected ExtentReports extent;
        protected ExtentTest test;

        [SetUp]
        public void FixtureInit()
        {
            extent = ExtentManager.Instance;

        }

        [TearDown]
        public void TearDown()
        {
            var status = TestContext.CurrentContext.Result.Status;
            //var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
            //		? ""
            //		: string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.StackTrace);
            LogStatus logstatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = LogStatus.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = LogStatus.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = LogStatus.Skip;
                    break;
                default:
                    logstatus = LogStatus.Pass;
                    break;
            }

            test.Log(logstatus, "Test ended with " + logstatus);

            extent.EndTest(test);
            extent.Flush();
        }
    }
    internal class ExtentManager
    {

        private static readonly ExtentReports _instance =
            new ExtentReports("C:\\Users\\bhavani.kandi\\Documents\\Visual Studio 2015\\Projects\\ESPN\\ESPN\\Reports\\Extent.Net.html", DisplayOrder.OldestFirst);


        static ExtentManager() { }

        private ExtentManager() { }

        public static ExtentReports Instance
        {
            get
            {
                return _instance;
            }
        }


    }
}
