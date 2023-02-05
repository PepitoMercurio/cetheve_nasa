using cetheve_nasa.image_data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cetheve_nasa.image
{
    internal class ImageBg
    {
        public ImageData ImageGetter(string key)
        {
            ImageData img = new ImageData();

            //on récuprère les données de l'Api
            var client = new HttpClient();
            var response = client.GetAsync("https://api.nasa.gov/planetary/apod?api_key=" + key).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var data = JObject.Parse(content);

            img.getter_date = (string)data["date"];
            img.getter_explanation = (string)data["explanation"];
            img.getter_hdurl = (string)data["hdurl"];
            img.getter_media_type = (string)data["media_type"];
            img.getter_service_version = (string)data["service_version"];
            img.getter_title = (string)data["title"];
            img.getter_url = (string)data["url"];

            return img;

        }
    }
}
