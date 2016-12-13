using System;
using System.Collections.Generic;
using System.Data.OleDb;
using LumenWorks.Framework.IO.Csv;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ESPN.Utils
{
    public class CSVreader
        
    {
        public Dictionary<string, string> reader()
        {
            List<string> list = new List<string>();

            string filepath = "C:\\Users\\bhavani.kandi\\Documents\\Visual Studio 2015\\Projects\\ESPN\\ESPN\\TestData\\Locators.csv";
            using (StreamReader readFile = new StreamReader(filepath))
            {
                string line;
                while ((line = readFile.ReadLine()) != null)
                {
                   list.Add(line);
                }
                readFile.Close();
            }

            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (int j = 0; j < list.Count; j++)
            {
               
                String[] s = list[j].Split(',');
                for (int i = 0; i < s.Length-1; i++)
                {
                        dict.Add(s[0], s[1]);
                                       
                }
            }
            return dict;
        }
    }
}
