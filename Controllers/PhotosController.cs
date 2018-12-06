using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace photo_service.Controllers
{
    [Route("api/[controller]")]
    public class PhotosController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Iceland", "Other" };
        }

        [HttpGet("{city}")]
        public string Get(string city)
        {
			switch (city) {
				case "Iceland": return "awesome";
				default: return "erw..." + city + "?";
			}
        }
    }
}
