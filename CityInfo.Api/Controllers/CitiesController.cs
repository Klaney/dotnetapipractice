﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    public class CitiesController : Controller
    { 
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>()
            {
                new {id=1, Name="New York City"},
                new {id=2, Name="Antwerp"}
            });
        }
    }
}
