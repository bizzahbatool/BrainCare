//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Assets.Controllers.Models
{
    public class Country
    {
        public string name { get; set; }
        public string code { get; set; }


        public static List<Country> GetCountries()
        {
            List<Country> items = new List<Country>();
            items.Add(new Country { code = "PK" , name="Pakistan" });
            items.Add(new Country { code = "CH", name = "Switzerland" });
            return items;
        }
    }

}
