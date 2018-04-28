using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AJAXtutorial.Controllers
{
    public class City
    {
        public City(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public List<City> Hotels { get; set; }
    }
}