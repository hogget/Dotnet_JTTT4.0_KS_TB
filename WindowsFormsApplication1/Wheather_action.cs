using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Net;



namespace WindowsFormsApplication1
{
    public class Wheather_action
    {
        ////////////////////////////////////////
        
        
        public class Configuration
        {
            public int id { get; set; }//potrzebujemy???
            public string akcja { get; set; }
            public string serwis { get; set; }
            public string querry { get; set; }
            public string mail { get; set; }
            public string path { get; set; }

            public Configuration(string akcja, string serwis, string querry, string mail, string path)
            {
                this.akcja = akcja;
                this.serwis = serwis;
                this.querry = querry;
                this.mail = mail;
                this.path = path;
                System.Console.Write("Configuration created: " + this.ToString());
            }

            public Configuration()
            {
            }

            public override string ToString()
            {
                string ret = "akcja: " + akcja + " serwis: " + serwis;
                if (!string.IsNullOrEmpty(querry))
                    ret += " querry: " + querry;
                if (!string.IsNullOrEmpty(mail))
                    ret += " mail: " + mail;
                return ret;
            }



            public string ConfName
            {
                get
                {
                    return this.ToString();
                }
            }
        }

    }




}

