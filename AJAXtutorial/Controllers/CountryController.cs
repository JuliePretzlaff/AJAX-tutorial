using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAXtutorial.Controllers
{
    private List<Country> countries = new List<Country>
        {
            new Country("Cuyahoga")
            {
                Cities = new List<City>
                {
                    new City("Solon"),
                    new City("Bay Village"),
                    new City("North Olmsted"),
                }
            },
            new County("Lorain")
            {
                Cities = new List<City>
                {
                    new City("Avon"),
                    new City("Elyria"),
                    new City("Oberlin"),
                }
            }
        };
}