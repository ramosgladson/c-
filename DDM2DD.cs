public static string DMS2DD(this string latitudeOrLongitude)
{
	string latlong = "";
        var pointArray = latitudeOrLongitude.Split(':');
        latlong = (Double.Parse(pointArray[0]) - (Double.Parse(pointArray[1]) / 60) - (Double.Parse(pointArray[2]) / 3600)).ToString().Replace(",", ".");
        return latlong;
}
