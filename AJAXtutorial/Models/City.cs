﻿using System;
using System.Collections.Generic;
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
        public string Name { get; set; }
        public List<Hotel> Hotels { get; set; }
    }
}