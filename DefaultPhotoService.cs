using photo_service.Loggers;
using photo_service.Business;

using System;

namespace photo_service 
{
	public class DefaultPhotoService : PhotoService 
	{
		private PhotoService logger = new PhotoConsoleLogger();
		private PhotoService business = new PhotoGallery();

		public DefaultPhotoService() {
			logger.Upstream = business;
		}

		public override Uri getCityPhoto(string city)
		{
			return this.logger.getCityPhoto(city);
		}
	}
}
