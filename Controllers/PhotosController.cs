using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace photo_service.Controllers
{
    [Route("api/[controller]")]
    public class PhotosController : Controller
    {
		private PhotoService service = new DefaultPhotoService(); 

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { 
				"Iceland", 
				"Other" 
			};
        }

        [HttpGet("{city}")]
        public string Get(string city)
        {
			Uri photoUrl = service.getCityPhoto(city);
		
			return photoUrl.ToString();
		}
    }
}
