using photo_service.Business;

using System;

namespace photo_service.Loggers 
{
	public class PhotoConsoleLogger : PhotoService
	{
		public override Uri getCityPhoto(string city) 
		{
			Console.WriteLine("Getting photo for city: " + city);

			var ret = this.Upstream.getCityPhoto(city); 

			Console.WriteLine(city + " = " + ret.ToString());

			return ret;
		}
	}
}
