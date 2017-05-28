Weather
===

The Status API exposes a `Weather` type to help enhance situational awareness.  All `GetStatus` overrides in the `AirMap` class have the option to include the `Weather` object.

The `Weather` object exposes the following properties:

| Property Name | Description                                           |
|---------------|-------------------------------------------------------|
| Conditions    | The overall weather conditions, i.e. "partly cloudy". |
| Icon          | The Icon ID for the current weather conditions.       |
| Humidity      | The relative humidity in percent (from 0 to 1).       |
| Visibility    | The visibility in kilometers.                         |
| Precipitation | The probability of rain in percent (from 0 to 1).     |
| Temperature   | The ambient air temperature in degrees Celsius.       |
| Wind.Heading  | The direction the wind is coming *from*.              |
| Wind.Speed    | The average wind speed in km/h.                       |
| Wind.Gusts    | The maximum wind gusts in km/h.

### Point/Radius Flight Area with Weather
```CSharp
AirMap am = new AirMap(...);

// Gets the status of a flight area around <33.553928, -117.717091> with a radius of 250 meters
Status status = am.GetStatus(33.553928, -117.717091, 250, true);

// Get the wind speed
double windSpeed = status.Weather.Wind.Speed;
```