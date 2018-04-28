using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAXtutorial.Controllers
{
    public class CountyController : Controller
    {
        private List<Country> countries = new List<Country>
        {
            new Country("Paraguay")
            {
                Cities = new List<City>
                {
                    new City("Trinidad"),
                    new City("Asuncion"),
                    new City("Encarnacion"),
                }
            },
            new Country("USA")
            {
                Cities = new List<City>
                {
                    new City("Cleveland"),
                    new City("Bozeman"),
                    new City("Bellingham"),
                }
            }
        };
    }
}
