using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AJAXtutorial.Models
{
    public class Hotel
    {

        public Hotel(string name)
        {
            Name = name;
        }

        [Key]
        public int HotelID { get; set; }
        public string Name { get; set; }
        //FK/nav prop
        [ForeignKey("City")]
        public int CityID { get; set; }
        public virtual City City { get; set; }
    }
}