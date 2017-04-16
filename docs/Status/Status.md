Status API
===

The Status API is used to obtain the current status of a proposed flight area.  Think of it as a traffic light:  Green means it's a good place to fly, red means the flight is probably not allowed for most people, and yellow means there are advisories in the area and additional actions may be required, such as providing notice to an airport.

The Status API provides all of the airspace constraints for a given flight plan, defined through one of three methods:  Point/Radius, Polygon and Waypoints.  This includes:

 - Traffic Light (Green, Yellow, Red) describing the overall safety of a flight in the area
 - Flight advisories within your flight area
 - Known requirements for flying in the area
 - Current weather conditions.
 
The Status API accepts a flight area described as a point/radius, a polygon or a series of waypoints.

![](https://files.readme.io/3b563b6-Geo_Types.png)
  
  
  
### Determining Direction and Distance to an Advisory

While it is not contained in the response directly, it can be useful to know the bearing and distance to an advisory.  The AirMapDotNet SDK makes this easy:

```CSharp

// Current position
LatLon launchPoint = new LatLon(33.9590, -118.3962);

// The advisory position
LatLon advisoryPosition = new LatLon(33.9847, -118.5130);

// The true bearing to the advisory in degrees
double bearing = launchPoint.Bearing(advisoryPosition);

// The distance to the advisory in meters
double distance = launchPoint.Distance(advisoryPosition);
```