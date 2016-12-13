using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ESPN.Tests
{
    public class SettingsTests:BaseTest
    {
        [Test]
        public void settingsTests()
        {
            Menupagedata.clickSignuplater();
            settingsPage.tapseetinglabel();
            settingsPage.clicksettings();
            settingsPage.clicksettingseditalerts();
        }
    }
}
