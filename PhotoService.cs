using System;

namespace photo_service 
{
	public abstract class PhotoService 
	{
		public PhotoService Upstream { get; set; } 

		public abstract Uri getCityPhoto(string city); 
	}
}
