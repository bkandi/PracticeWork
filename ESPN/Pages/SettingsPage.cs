using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Android;
using AppWebQuery = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppWebQuery>;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using ESPN.Utils;

namespace ESPN.Pages
{
    public class SettingsPage: Basepage
    {
       
        protected readonly Query settingslabel;
        protected readonly Query settingseditalerts;
        protected readonly Query clicksettingsbutton;
 
       CSVreader csvreader;
        Dictionary<string, string> dict;
        public SettingsPage(AndroidApp app) : base(app)
        {
            csvreader = new CSVreader();
            dict = csvreader.reader();
            string settingslabel1;
            dict.TryGetValue("settingslabel", out settingslabel1);
            settingslabel = x => x.Marked(settingslabel1);
            string settingseditalerts1;
            dict.TryGetValue("settingeditalert", out settingseditalerts1);
            string[] s = settingseditalerts1.Split(':');
            settingseditalerts = x => x.Id(s[0]).Text(s[1]);
            string clicksettingsbutton1;
            dict.TryGetValue("clicksettingbutton", out clicksettingsbutton1);
            string[] s1 = settingseditalerts1.Split(':');
            clicksettingsbutton = x => x.Id(s1[0]).Text(s1[1]);
            
        }
        public void tapseetinglabel()
        {
            app.Tap(settingslabel);
        }
        public void clicksettings()
        {
            app.Tap(clicksettingsbutton);
        }
        public void clicksettingseditalerts()
        {
            app.Tap(settingseditalerts);
        }
        
    }
}
