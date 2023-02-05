using cetheve_nasa.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cetheve_nasa.image_data
{
    internal class ImageData
    {
        private string date;
        public string getter_date
        {
            get { return date; }
            set { date = value; }
        }

        private string explanation;
        public string getter_explanation
        {
            get { return explanation; }
            set { explanation = value; }
        }

        private string hdurl;
        public string getter_hdurl
        {
            get { return hdurl; }
            set { hdurl = value; }
        }

        private string media_type;
        public string getter_media_type
        {
            get { return media_type; }
            set { media_type = value; }
        }


        private string service_version;
        public string getter_service_version
        {
            get { return service_version; }
            set { service_version = value; }
        }

        private string title;
        public string getter_title
        {
            get { return title; }
            set { title = value; }
        }

        private string url;
        public string getter_url
        {
            get { return url; }
            set { url = value; }
        }
    }
}

