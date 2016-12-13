using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;
using ESPN.Utils;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace ESPN.Pages
{
    public class MenuPage : Basepage
    {
        protected readonly Query Signuplater;
        protected readonly Query ESPNlogo;
        protected readonly Query SubmenuSports;
        protected readonly Query SubmenuSportslink;
        
        CSVreader csvreader;
        Dictionary<string, string> dict;
        public MenuPage(AndroidApp app) : base(app)
        {
            csvreader = new CSVreader();
            dict = csvreader.reader();
            string Signuplater1;
            dict.TryGetValue("signuplater", out Signuplater1);
            Signuplater = x => x.Id(Signuplater1);
            string ESPNlogo1;
            dict.TryGetValue("ESPNlogo", out ESPNlogo1);
            ESPNlogo = x => x.Marked(ESPNlogo1);
            string SubmenuSports1;
            dict.TryGetValue("SubmenuSports", out SubmenuSports1);
            SubmenuSports = x => x.Marked(SubmenuSports1);
            string SubmenuSportslink1;
            dict.TryGetValue("sunmenuSportsLink", out SubmenuSportslink1);
            SubmenuSportslink = x => x.Marked(SubmenuSportslink1);
        }
        public void clickSignuplater()
        {
            app.Tap(Signuplater);
        }
        public void clickESPNlogo()
        {
            app.Tap(ESPNlogo);
        }
        public void readESPNlogodata()
        {
            app.Tap(SubmenuSports);
        }
        public void getsubmenusportslinkdata()
        {
            app.WaitForElement(C => C.Id("sport_name"));
           AppResult[] itmevalues= app.Query(C => C.Id("sport_name"));
            for (int i = 0; i < 5; i++)
            {
                int j;
                int length = itmevalues.Length;
                Console.WriteLine("loop count" + length);
                for (j = 0; j < itmevalues.Length-1; j++)
                {
                    Console.WriteLine(itmevalues[j].Text);
                   
                }
                app.DragCoordinates(359, 16788, 359, 391);
                //// app.Scroll(itmevalues[j].Text);
                //// app.ScrollTo(itmevalues[j].Text);
                //app.ScrollUp(itmevalues[j].Text, Xamarin.UITest.ScrollStrategy.Auto, 0.65, 300, false);
                // app.ScrollDownTo(c => c.All().Id("TextField").Index(3), c => c.Id("ScrollViewer"));
                //app.ScrollUpTo(C => C.Id("sport_name").All(),);
            }
        }
    }
}
