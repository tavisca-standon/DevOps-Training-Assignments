﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [Route("api/[controller]")]
    public class TaviscaController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "Welcome To Tavisca";
        }

     }
}
