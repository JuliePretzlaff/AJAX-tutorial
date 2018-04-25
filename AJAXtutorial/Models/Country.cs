using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

       [Key]
        public string Name { get; set; }
        public List<City> Cities { get; set; }

    }
}
