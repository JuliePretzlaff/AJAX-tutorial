using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AJAXtutorial.Models
{
    public class Country
    {

        public Country(string name)
        {
            Name = name;
            Cities = new List<City>();
        }
        public string Name { get; set; }
        public List<City> Cities { get; set; }
       
    }
}
