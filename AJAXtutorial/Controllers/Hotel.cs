using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AJAXtutorial.Controllers
{
    public class Hotel
    {
        public Hotel(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

    }
}