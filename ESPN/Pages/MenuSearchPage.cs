using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Android;
using ESPN.Utils;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;


namespace ESPN.Pages
{
   public class MenuSearchPage:Basepage
    {
        Properties config = new Properties("c:\\users\\bhavani.kandi\\documents\\visual studio 2015\\Projects\\ESPN\\ESPN\\TestData\\TestData.Properties");
        protected readonly Query Menusearch;

        CSVreader csvreader;
        Dictionary<string, string> dict;
        public MenuSearchPage(AndroidApp app) : base(app)
        {
            csvreader = new CSVreader();
            dict = csvreader.reader();
            string Menusearch1;
            dict.TryGetValue("menusearch", out Menusearch1);
            Menusearch = x => x.Id(Menusearch1);
        }
        public void clicksearchbutton()
        {
            app.Tap(Menusearch);
        }
        public void Entertextinmenusearchbox()
        {
            string menusearchdata = config.get("menusearchdata");
            app.EnterText(Menusearch, menusearchdata);
        }
    }
}
