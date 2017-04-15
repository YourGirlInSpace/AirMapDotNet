Status API
===

The Status API describes the flight status for a proposed flight area.

A proposed flight area could be any of the following:
 - A `LatLon` with a radius
 - A `LineString` geometry
 - A `Polygon` geometry

The Status API summarizes the flight safety of an area using a simple traffic light system:  Green indicates that there are no known advisories hindering a flight in an area, Yellow indicates that the operator may require additional authorization or actions to fly in an area, and Red indicates that the flight area is strictly regulated and it is probably not safe to fly for the majority of operators.

The Status API will provide you with a list of any `AirspaceObject` that intersects the proposed flight area.  It will also provide the current weather, and the maximum safe distance away from the takeoff point you can fly before you encounter an `AirspaceObject`.

### Point/Radius Flight Area
```CSharp
AirMap am = new AirMap(AIRMAP_API_KEY);

// Gets the status of a flight area around <33.553928, -117.717091> with a radius of 250 meters
Status status = am.GetStatus(33.553928, -117.717091, 250);
```

### LineString Geometry
```CSharp
AirMap am = new AirMap(AIRMAP_API_KEY);

Geometry path = Utilities.CreatePath(new LatLon(33.553928, -117.717091), new LatLon(33.557054, -117.713874), new LatLon(33.558606, -117.719524));

// Gets the status of a flight area around the described path, within a distance of 100 meters from the line.
Status status = am.GetStatus(path, 100);
```

### Polygon Geometry
```CSharp
AirMap am = new AirMap(AIRMAP_API_KEY);

Geometry poly = GeoUtilities.CreateRectangle(new LatLon(33.558490, -117.721603), new LatLon(33.549965, -117.709821));

// Gets the status of a flight area around the described polygon.
Status status = am.GetStatus(poly);
```

