using System;

namespace AirMapDotNet
{
    /// <summary>
    /// Represents a latitude and longitude pair.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lat")]
    public class LatLon : IEquatable<LatLon>
    {
        /// <summary>
        /// The mean radius of the Earth, defined as 6378.137 km.
        /// </summary>
        public const double EarthRadius = 6378137;

        /// <summary>
        /// The absolute tolerance before the difference between latitudes or longitudes may be considered zero.
        /// In this case, roughly half an inch.
        /// </summary>
        /// <remarks><para>The <see cref="Epsilon"/> constant is used in equality methods to determine whether a latitude
        /// or longitude equals another latitude or longitude.  Due to floating point errors, it is conceivable that
        /// two otherwise equal-appearing numbers may differ by a minute amount.</para>
        /// <para>To combat this, an <see cref="Epsilon"/> is defined describing the minimum useful granularity before the
        /// absolute difference between the two numbers may be considered zero.</para>
        /// <para>For example,
        /// <code>
        /// // The expected value
        /// double lat1 = 26;
        /// 
        /// // This may happen due to floating point errors.
        /// // Normally, the effect is much smaller than this, down to 1e-37.
        /// double lat2 = 26.00000000000000001;
        /// 
        /// // This will resolve to false because the two values have a
        /// // very slightly different value.
        /// double equal1 = lat1 == lat2;
        /// 
        /// // This will resolve to true, because the absolute difference
        /// // between the two values is 1e-17 -- less than the Epsilon's
        /// // value of 1e-7.
        /// double equal2 = Math.Abs(lat1 - lat2) &lt; Epsilon;
        /// </code></para>
        /// </remarks>
        public const double Epsilon = 1e-7;

        private double _lat, _lon;

        /// <summary>
        /// The Longitude.
        /// </summary>
        /// <value>The Longitude, in degrees.  Must be between -180 and +180.</value>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="value"/> is less than -180 or greater than +180.</exception>
        public double Longitude
        {
            get { return _lon; }
            set
            {
                if (value < -180 || value > 180)
                    throw new ArgumentOutOfRangeException(nameof(value), "Longitude must be in range -180 to 180.");

                _lon = value;
            }
        }

        /// <summary>
        /// The Latitude.
        /// </summary>
        /// <value>The Latitude, in degrees.  Must be between -90 and +90.</value>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="value"/> is less than -90 or greater than +90.</exception>
        public double Latitude
        {
            get { return _lat; }
            set
            {
                if (value < -90 || value > 90)
                    throw new ArgumentOutOfRangeException(nameof(value), "Latitude must be in range -90 to 90.");

                _lat = value;
            }
        }

        /// <summary>
        /// Creates a new <see cref="LatLon"/> at 0N 0W.
        /// </summary>
        public LatLon()
        {
            Latitude = 0;
            Longitude = 0;
        }
        
        /// <summary>
        /// Creates a new <see cref="LatLon"/> with the described <paramref name="lat"/> and <paramref name="lon"/>.
        /// </summary>
        /// <param name="lat">The value to assign to <see cref="Latitude"/></param>
        /// <param name="lon">The value to assign to <see cref="Longitude"/></param>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="lat"/> is less than -90 or greater than +90.</exception>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="lon"/> is less than -180 or greater than +180.</exception>
        public LatLon(double lat, double lon)
        {
            if (lat < -90 || lat > 90)
                throw new ArgumentOutOfRangeException(nameof(lat), "Latitude must be in range -90 to 90.");
            if (lon < -180 || lon > 180)
                throw new ArgumentOutOfRangeException(nameof(lon), "Longitude must be in range -180 to 180.");

            Latitude = lat;
            Longitude = lon;
        }

        /// <summary>
        /// Converts the <see cref="LatLon"/> object into a Degree-Minute-Second form.
        /// </summary>
        /// <returns>A Degree-Minute-Second form of this <see cref="LatLon"/> object.</returns>
        public string ToDMS()
        {
            double lat_deg = Math.Floor(Math.Abs(Latitude));
            double lat_min = Math.Floor((Math.Abs(Latitude) - Math.Abs(lat_deg)) * 60);
            double lat_secs = Math.Round(((Math.Abs(Latitude) - Math.Abs(lat_deg)) * 60 - Math.Abs(lat_min)) * 60, 1);

            double lon_deg = Math.Floor(Math.Abs(Longitude));
            double lon_min = Math.Floor((Math.Abs(Longitude) - Math.Abs(lon_deg)) * 60);
            double lon_secs = Math.Round(((Math.Abs(Longitude) - Math.Abs(lon_deg)) * 60 - Math.Abs(lon_min)) * 60, 1);

            return
                $"{Math.Abs(lat_deg):0#}°{Math.Abs(lat_min):0#}'{Math.Abs(lat_secs):0#.0}\"{(Latitude < 0 ? "S" : "N")} {Math.Abs(lon_deg):0#}°{Math.Abs(lon_min):0#}'{Math.Abs(lon_secs):0#.0}\"{(Longitude < 0 ? "W" : "E")}";
        }
        
        /// <summary>
        /// Projects a new <see cref="LatLon"/> exactly <paramref name="bearing"/> degrees and <paramref name="distance"/> meters away.
        /// </summary>
        /// <param name="bearing">The bearing to the new point, in degrees.</param>
        /// <param name="distance">The distance to the new point, in meters.</param>
        /// <returns>The projected <see cref="LatLon"/>.</returns>
        public LatLon Project(double bearing, double distance)
        {
            double theta = bearing * Math.PI / 180.0;
            double latRad = Latitude * Math.PI / 180.0;
            double lonRad = Longitude * Math.PI / 180.0;

            double lat2 =
                Math.Asin(Math.Sin(latRad) * Math.Cos(distance / EarthRadius) + Math.Cos(latRad) * Math.Sin(distance / EarthRadius) * Math.Cos(theta));
            double lon2 =
                lonRad + Math.Atan2(Math.Sin(theta) * Math.Sin(distance / EarthRadius) * Math.Cos(latRad), Math.Cos(distance / EarthRadius) - Math.Sin(latRad) * Math.Sin(lat2));

            lat2 = lat2 * (180.0 / Math.PI);
            lon2 = lon2 * (180.0 / Math.PI);

            return new LatLon(lat2, lon2);
        }

        /// <summary>
        /// Calculates the distance between two <see cref="LatLon"/> points.
        /// </summary>
        /// <param name="other">The other <see cref="LatLon"/>.</param>
        /// <returns>The distance between the two <see cref="LatLon"/> points in meters.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="other"/> is null.</exception>
        public double Distance(LatLon other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            double lat1_rad = Latitude * Math.PI / 180.0;
            double lon1_rad = Longitude * Math.PI / 180.0;
            double lat2_rad = other.Latitude * Math.PI / 180.0;
            double lon2_rad = other.Longitude * Math.PI / 180.0;

            double angularDistance = Math.Acos(Math.Sin(lat1_rad) * Math.Sin(lat2_rad) + Math.Cos(lat1_rad) * Math.Cos(lat2_rad) * Math.Cos(Math.Abs(lon2_rad - lon1_rad)));
            return EarthRadius * angularDistance;
        }

        /// <summary>
        /// Calculates the bearing from this <see cref="LatLon"/> to another <see cref="LatLon"/>.
        /// </summary>
        /// <param name="other">The other <see cref="LatLon"/>.</param>
        /// <returns>The bearing from this <see cref="LatLon"/> to <paramref name="other"/>.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="other"/> is null.</exception>
        public double Bearing(LatLon other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            double lat1_rad = Latitude*Math.PI/180.0;
            double lon1_rad = Longitude*Math.PI/180.0;
            double lat2_rad = other.Latitude*Math.PI/180.0;
            double lon2_rad = other.Longitude*Math.PI/180.0;

            double dLon = lon2_rad - lon1_rad;
            double y = Math.Sin(dLon) * Math.Cos(lat2_rad);
            double x = Math.Cos(lat1_rad) * Math.Sin(lat2_rad) - Math.Sin(lat1_rad) * Math.Cos(lat2_rad) * Math.Cos(dLon);

            double bearing = Math.Atan2(y, x) * 180.0 / Math.PI;

            if (bearing < 0)
                bearing = bearing + 360.0;

            return bearing % 360.0;
        }

        /// <inheritdoc />
        public override string ToString() => ToDMS();

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return Equals(obj as LatLon);
        }

        /// <inheritdoc />
        public bool Equals(LatLon other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Math.Abs(Longitude - other.Longitude) < Epsilon && Math.Abs(Latitude - other.Latitude) < Epsilon;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return (Longitude.GetHashCode()*397) ^ Latitude.GetHashCode();
            }
        }
        
        /// <summary>
        /// Determines whether <paramref name="left"/> is equal to <paramref name="right"/>.
        /// </summary>
        /// <param name="left">The first <see cref="LatLon"/>.</param>
        /// <param name="right">The second <see cref="LatLon"/>.</param>
        /// <returns><b>True</b> if <paramref name="left"/> equals <paramref name="right"/>, otherwise <b>false</b>.</returns>
        public static bool operator ==(LatLon left, LatLon right)
        {
            return Equals(left, right);
        }


        /// <summary>
        /// Determines whether <paramref name="left"/> is not equal to <paramref name="right"/>.
        /// </summary>
        /// <param name="left">The first <see cref="LatLon"/>.</param>
        /// <param name="right">The second <see cref="LatLon"/>.</param>
        /// <returns><b>True</b> if <paramref name="left"/> does not equal <paramref name="right"/>, otherwise <b>false</b>.</returns>
        public static bool operator !=(LatLon left, LatLon right)
        {
            return !Equals(left, right);
        }
    }
}