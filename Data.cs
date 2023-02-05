namespace cetheve_nasa.data
{
    //Cr�ation de la classe CloseApproachDatum
    public class CloseApproachDatum
    {
        private string close_approach_date;
        public string getter_close_approach_date
        {
            get { return close_approach_date; }
            set { close_approach_date = value; }
        }

        private string close_approach_date_full;
        public string getter_close_approach_date_full
        {
            get { return close_approach_date_full; }
            set { close_approach_date_full = value; }
        }

        private string epoch_date_close_approach;
        public string getter_epoch_date_close_approach
        {
            get { return epoch_date_close_approach; }
            set { epoch_date_close_approach = value; }
        }

        private RelativeVelocity relative_velocity;
        public RelativeVelocity getter_relative_velocity
        {
            get { return relative_velocity; }
            set { relative_velocity = value; }
        }

        private MissDistance miss_distance;
        public MissDistance getter_miss_distance
        {
            get { return miss_distance; }
            set { miss_distance = value; }
        }

        private string orbiting_body;
        public string getter_orbiting_body
        {
            get { return orbiting_body; }
            set { orbiting_body = value; }
        }
    }

    //Cr�ation de la classe EstimatedDiameter
    public class EstimatedDiameter
    {
        private Kilometers kilometers;
        public Kilometers getter_kilometers
        {
            get { return kilometers; }
            set { kilometers = value; }
        }

        private Meters meters;
        public Meters getter_meters
        {
            get { return meters; }
            set { meters = value; }
        }

        private Miles miles;
        public Miles getter_miles
        {
            get { return miles; }
            set { miles = value; }
        }

        private Feet feet;
        public Feet getter_feet
        {
            get { return feet; }
            set { feet = value; }
        }
    }

    //Cr�ation de la classe Feet
    public class Feet
    {
        private double estimated_diameter_min;
        public double getter_estimated_diameter_min
        {
            get { return estimated_diameter_min; }
            set { estimated_diameter_min = value; }
        }

        private double estimated_diameter_max;
        public double getter_estimated_diameter_max
        {
            get { return estimated_diameter_max; }
            set { estimated_diameter_max = value; }
        }
    }

    //Cr�ation de la classe Kilometers
    public class Kilometers
    {
        private double estimated_diameter_min;
        public double getter_estimated_diameter_min
        {
            get { return estimated_diameter_min; }
            set { estimated_diameter_min = value; }
        }

        private double estimated_diameter_max;
        public double getter_estimated_diameter_max
        {
            get { return estimated_diameter_max; }
            set { estimated_diameter_max = value; }
        }
    }

    //Cr�ation de la classe Links
    public class Links
    {
        private string self;
        public string getter_self
        {
            get { return self; }
            set { self = value; }
        }
    }

    //Cr�ation de la classe Meters
    public class Meters
    {
        private double estimated_diameter_min;
        public double getter_estimated_diameter_min
        {
            get { return estimated_diameter_min; }
            set { estimated_diameter_min = value; }
        }

        private double estimated_diameter_max;
        public double getter_estimated_diameter_max
        {
            get { return estimated_diameter_max; }
            set { estimated_diameter_max = value; }
        }
    }

    //Cr�ation de la classe Miles
    public class Miles
    {
        private double estimated_diameter_min;
        public double getter_estimated_diameter_min
        {
            get { return estimated_diameter_min; }
            set { estimated_diameter_min = value; }
        }

        private double estimated_diameter_max;
        public double getter_estimated_diameter_max
        {
            get { return estimated_diameter_max; }
            set { estimated_diameter_max = value; }
        }
    }

    //Cr�ation de la classe MissDistance
    public class MissDistance
    {
        private string astronomical;
        public string getter_astronomical
        {
            get { return astronomical; }
            set { astronomical = value; }
        }

        private string lunar;
        public string getter_lunar
        {
            get { return lunar; }
            set { lunar = value; }
        }

        private string kilometers;
        public string getter_kilometers
        {
            get { return kilometers; }
            set { kilometers = value; }
        }

        private string miles;
        public string getter_miles
        {
            get { return miles; }
            set { miles = value; }
        }
    }

    //Cr�ation de la classe RelativeVelocity
    public class RelativeVelocity
    {
        private string kilometers_per_second;
        public string getter_kilometers_per_second
        {
            get { return kilometers_per_second; }
            set { kilometers_per_second = value; }
        }

        private string kilometers_per_hour;
        public string getter_kilometers_per_hour
        {
            get { return kilometers_per_hour; }
            set { kilometers_per_hour = value; }
        }

        private string miles_per_hour;
        public string getter_miles_per_hour
        {
            get { return miles_per_hour; }
            set { miles_per_hour = value; }
        }
    }

    //Cr�ation de la classe Root (classe principale)
    public class Root
    {
        private Links links;
        public Links getter_links
        {
            get { return links; }
            set { links = value; }
        }

        private string id;
        public string getter_id
        {
            get { return id; }
            set { id = value; }
        }

        private string neo_reference_id;
        public string getter_neo_reference_id
        {
            get { return neo_reference_id; }
            set { neo_reference_id = value; }
        }

        private string name;
        public string getter_name
        {
            get { return name; }
            set { name = value; }
        }


        private string nasa_jpl_url;
        public string getter_nasa_jpl_url
        {
            get { return nasa_jpl_url; }
            set { nasa_jpl_url = value; }
        }

        private double absolute_magnitude_h;
        public double getter_absolute_magnitude_h
        {
            get { return absolute_magnitude_h; }
            set { absolute_magnitude_h = value; }
        }

        private EstimatedDiameter estimated_diameter;
        public EstimatedDiameter getter_estimated_diameter
        {
            get { return estimated_diameter; }
            set { estimated_diameter = value; }
        }

        private bool is_potentially_hazardous_asteroid;
        public bool getter_is_potentially_hazardous_asteroid
        {
            get { return is_potentially_hazardous_asteroid; }
            set { is_potentially_hazardous_asteroid = value; }
        }

        private List<CloseApproachDatum> close_approach_data = new List<CloseApproachDatum>();
        public List<CloseApproachDatum> getter_close_approach_data
        {
            get { return close_approach_data; }
            set { close_approach_data = value; }
        }

        public void AddCloseApproachDatum(CloseApproachDatum newDatum)
        {
            close_approach_data.Add(newDatum);
        }

        private bool is_sentry_object;
        public bool getter_is_sentry_object
        {
            get { return is_sentry_object; }
            set { is_sentry_object = value; }
        }
    }
}