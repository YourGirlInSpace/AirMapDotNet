# FlightCreationParameters.Geometry Property 
 

Optional geometry attribute. Leave null to make this flight point-radius.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities_FlightAPI">AirMapDotNet.Entities.FlightAPI</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Geometry Geometry { get; set; }
```

**VB**<br />
``` VB
Public Property Geometry As Geometry
	Get
	Set
```

**C++**<br />
``` C++
public:
property Geometry^ Geometry {
	Geometry^ get ();
	void set (Geometry^ value);
}
```

**F#**<br />
``` F#
member Geometry : Geometry with get, set

```


#### Property Value
Type: <a href="T_AirMapDotNet_Entities_GeoJSON_Geometry">Geometry</a>

## Remarks
The only two accepted geometries are <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_LineString">LineString</a> and <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_Polygon">Polygon</a>.

## See Also


#### Reference
<a href="T_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters">FlightCreationParameters Class</a><br /><a href="N_AirMapDotNet_Entities_FlightAPI">AirMapDotNet.Entities.FlightAPI Namespace</a><br />