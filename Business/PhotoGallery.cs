using photo_service;

using System;

namespace photo_service.Business 
{
	public class PhotoGallery : PhotoService
	{
		public override Uri getCityPhoto(string city) 
		{
			string photoFilename = getRandomCityPhotoFilename(city);

			Uri uri;

			if (photoFilename == null) 
			{
				uri = this.createDefaultUri();
			} 
			else 
			{
				uri = this.createUri(photoFilename);
			}

			return uri;
		}

		private string getRandomCityPhotoFilename(string city) 
		{
			return null;
		}

		private Uri createDefaultUri() 
		{
			return this.createUri("default.png");
		}

		private Uri createUri(string photoFilename) 
		{
			var builder = new UriBuilder();
			builder.Scheme = "http";
			builder.Host = "example.com";
			builder.Path = "/photos/" + photoFilename;

			return builder.Uri;
		}
	}
}
