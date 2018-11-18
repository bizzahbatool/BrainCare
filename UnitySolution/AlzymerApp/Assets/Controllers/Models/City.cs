//using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Assets.Controllers.Models
{
    public class City
    {
        public string country { get; set; }
        public string name { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }


        public static List<City> GetCities()
        {
            List<City> items = new List<City>();
            items.Add(new City { country = "PK", lat = "0.0",lng = "0.0", name = "Lahore" });
            items.Add(new City { country = "PK", lat = "0.0", lng = "0.0", name = "Faisalabad" });
            items.Add(new City { country = "PK", lat = "0.0", lng = "0.0", name = "Karachi" });
            items.Add(new City { country = "PK", lat = "0.0", lng = "0.0", name = "Islamabad" });
            items.Add(new City { country = "PK", lat = "0.0", lng = "0.0", name = "Peshawar" });
            items.Add(new City { country = "PK", lat = "0.0", lng = "0.0", name = "Quetta" });
            items.Add(new City { country = "PK", lat = "0.0", lng = "0.0", name = "Multan" });
            items.Add(new City { country = "PK", lat = "0.0", lng = "0.0", name = "Hyderabad" });

            items.Add(new City { country = "CH", lat = "0.0", lng = "0.0", name = "Beromünster" });
            items.Add(new City { country = "CH", lat = "0.0", lng = "0.0", name = "Bernex" });
            items.Add(new City { country = "CH", lat = "0.0", lng = "0.0", name = "Bern" });
            items.Add(new City { country = "CH", lat = "0.0", lng = "0.0", name = "Beringen" });
            items.Add(new City { country = "CH", lat = "0.0", lng = "0.0", name = "Berikon" });
            items.Add(new City { country = "CH", lat = "0.0", lng = "0.0", name = "Berg" });
            items.Add(new City { country = "CH", lat = "0.0", lng = "0.0", name = "Benken" });
            items.Add(new City { country = "CH", lat = "0.0", lng = "0.0", name = "Belp" });
            return items;
        }

        public static List<City> GetCities(string countryCode)
        {
            List<City> items = GetCities();
            return items.Where(i => i.country.Equals(countryCode)).ToList();
        }
        #region city Json
        private string CitiesList = @"";
        #endregion  
    }
}
