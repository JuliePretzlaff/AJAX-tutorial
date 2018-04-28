using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAXtutorial.Controllers
{
    public class CountryController : Controller
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
        public JsonResult GetCountries()
        {
            var countryNames = countries.Select(c => c.Name);
            return Json(countryNames, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCitiesInCountry(string countryName)
        {
            var country = countries.Single(c => c.Name == countryName);
            var schoolNames = country.Cities.Select(city => city.Name);
            return Json(schoolNames, JsonRequestBehavior.AllowGet);
        }
    }
}
