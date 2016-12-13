using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Android;
using NUnit.Framework;

namespace ESPN.Pages
{
   public class Basepage
    {
       
        public AndroidApp app;
        public Basepage(AndroidApp app)
        {
            this.app = app;
        }
    }
}
