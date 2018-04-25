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
        public string Name { get; set; }
    }
}