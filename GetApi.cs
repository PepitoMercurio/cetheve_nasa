using cetheve_nasa.data;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics.Metrics;
using System.Net.Http;
using System.Text.Json;
using System.Xml.Linq;

namespace cetheve_nasa.get_api
{
    internal class GetApi
    {
        public List<Root> ApiGetter(string key)
        {
            //Date du jour (non implémenté par manque de temps)
            var today = DateTime.Now.ToString("yyyy-MM-dd");

            

            //Cette liste nous sert à stoquer les données de l'api pour les réutiliser ailleurs
            List<Root> api_result = new List<Root>();

            //on récuprère les données de l'Api
            var client = new HttpClient();
            var response = client.GetAsync("https://api.nasa.gov/neo/rest/v1/feed?start_date=2023-02-05&end_date=2023-02-05&api_key=" + key).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var data = JObject.Parse(content);

            //On fait un tableau de toutes les données de near_earth_objects
            JArray near_earth_objects = (JArray)data["near_earth_objects"][today];

            //Puis on les stoque dans une bibliothèque pour pouvoir récupérer les informations plus rapidement
            Dictionary<string, JObject> linksData = new Dictionary<string, JObject>();

            //On récupère les données des chaques comètes grace à self (lien de chaque comètes) pour les ranger dans un tableau
            foreach (JObject objects in near_earth_objects)
            {
                var all_link = (string)objects["links"]["self"];
                var data_client = new HttpClient();
                var response_each_links = data_client.GetAsync(all_link).Result;
                var content_each_links = response_each_links.Content.ReadAsStringAsync().Result;
                var data_each_links = JObject.Parse(content_each_links);
                linksData.Add(all_link, data_each_links);
            }

            //Grâce à cette boucle on va pouvoir stoquer les valeurs dans nos différentes classes
            foreach (var item in linksData)
            {
                //On défini nos différentes classes
                CloseApproachDatum close_approach_datum = new CloseApproachDatum();
                EstimatedDiameter estimated_diameter = new EstimatedDiameter();
                Feet feet = new Feet();
                Kilometers kilometers = new Kilometers();
                Links links = new Links();
                Meters meters = new Meters();
                Miles miles = new Miles();
                RelativeVelocity relative_velocity = new RelativeVelocity();
                MissDistance miss_distance = new MissDistance();
                Root main = new Root();

                //Cette liste sert à vider close_approach_datum
                List<CloseApproachDatum> empty_list = new List<CloseApproachDatum>();

                //On récupère le tableau close_approach_data pour povoir le parcourir plus tard
                var approach_data = item.Value["close_approach_data"];

                //on vide la List de close_approach_data
                main.getter_close_approach_data = empty_list;

                //on réinitialise l'id
                int approach_id = 0;

                //On parcours le tableau close_approach_data créé plus tôt pour récuperer toutes ses données et les trier
                foreach (var approach_elem in approach_data)
                {
                    
                    //Relative Velocity

                    //On utilise l'id de close_approach_data pour récupérer la bonne valeur
                    relative_velocity.getter_kilometers_per_second = (string)item.Value["close_approach_data"][approach_id]["relative_velocity"]["kilometers_per_second"];
                    relative_velocity.getter_kilometers_per_hour = (string)item.Value["close_approach_data"][approach_id]["relative_velocity"]["kilometers_per_hour"];
                    relative_velocity.getter_miles_per_hour = (string)item.Value["close_approach_data"][approach_id]["relative_velocity"]["miles_per_hour"];

                    //Miss Distance
                    miss_distance.getter_astronomical = (string)item.Value["close_approach_data"][approach_id]["miss_distance"]["astronomical"];
                    miss_distance.getter_lunar = (string)item.Value["close_approach_data"][approach_id]["miss_distance"]["lunar"];
                    miss_distance.getter_kilometers = (string)item.Value["close_approach_data"][approach_id]["miss_distance"]["kilometers"];
                    miss_distance.getter_miles = (string)item.Value["close_approach_data"][approach_id]["miss_distance"]["miles"];

                    //Close Approach Datum
                    close_approach_datum.getter_close_approach_date = (string)item.Value["close_approach_data"][approach_id]["close_approach_date"];
                    close_approach_datum.getter_close_approach_date_full = (string)item.Value["close_approach_data"][approach_id]["close_approach_date_full"];
                    close_approach_datum.getter_epoch_date_close_approach = (string)item.Value["close_approach_data"][approach_id]["epoch_date_close_approach"];
                    close_approach_datum.getter_relative_velocity = relative_velocity;
                    close_approach_datum.getter_miss_distance = miss_distance;
                    close_approach_datum.getter_orbiting_body = (string)item.Value["close_approach_data"][approach_id]["orbiting_body"];

                    main.AddCloseApproachDatum(close_approach_datum);
                    approach_id += 1;
                }

                //Kilometers
                kilometers.getter_estimated_diameter_min = (double)item.Value["estimated_diameter"]["kilometers"]["estimated_diameter_min"];
                kilometers.getter_estimated_diameter_max = (double)item.Value["estimated_diameter"]["kilometers"]["estimated_diameter_max"];

                //Meters
                meters.getter_estimated_diameter_min = (double)item.Value["estimated_diameter"]["meters"]["estimated_diameter_min"];
                meters.getter_estimated_diameter_max = (double)item.Value["estimated_diameter"]["meters"]["estimated_diameter_max"];

                //Miles
                miles.getter_estimated_diameter_min = (double)item.Value["estimated_diameter"]["miles"]["estimated_diameter_min"];
                miles.getter_estimated_diameter_max = (double)item.Value["estimated_diameter"]["miles"]["estimated_diameter_max"];

                //Feet
                feet.getter_estimated_diameter_min = (double)item.Value["estimated_diameter"]["feet"]["estimated_diameter_min"];
                feet.getter_estimated_diameter_max = (double)item.Value["estimated_diameter"]["feet"]["estimated_diameter_max"];

                //Estimated Diameter
                estimated_diameter.getter_kilometers = kilometers;
                estimated_diameter.getter_meters = meters;
                estimated_diameter.getter_miles = miles;
                estimated_diameter.getter_feet = feet;

                //Links
                links.getter_self = (string)item.Value["links"]["self"];

                //Root
                main.getter_id = (string)item.Value["id"];
                main.getter_neo_reference_id = (string)item.Value["neo_reference_id"];
                main.getter_name = (string)item.Value["name"];
                main.getter_links = links;
                main.getter_nasa_jpl_url = (string)item.Value["nasa_jpl_url"];
                main.getter_absolute_magnitude_h = (double)item.Value["absolute_magnitude_h"];
                main.getter_estimated_diameter = estimated_diameter;
                main.getter_is_potentially_hazardous_asteroid = (bool)item.Value["is_potentially_hazardous_asteroid"];

                api_result.Add(main);
                Console.WriteLine(api_result[0].getter_name);
                
            }
            return api_result;
        }
    }
}