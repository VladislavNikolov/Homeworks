namespace A.GalacticGPS
{
    using System;

    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }

            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("value", "Latitude should be between +- 90 degrees.");
                }

                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }

            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("value", "Longitude should be between +- 180 degrees.");
                }

                this.longitude = value;
            }
        }

        public Planet Planet
        {
            get
            {
                return this.planet;
            }

            set
            {
                this.planet = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}
