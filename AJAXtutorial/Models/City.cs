using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AJAXtutorial.Models
{
    public class City
    {

        public City(string name)
        {
            Name = name;
            Hotels = new List<Hotel>();
        }

        [Key]
        public int CityID { get; set; }
        public string Name { get; set; }
        public List<Hotel> Hotels { get; set; }

        //FK/nav prop
        [ForeignKey("Country")]
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}