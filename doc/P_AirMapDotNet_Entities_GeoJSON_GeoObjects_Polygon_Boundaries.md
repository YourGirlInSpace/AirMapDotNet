# Polygon.Boundaries Property 
 

A list of boundaries for each polygon shape.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities_GeoJSON_GeoObjects">AirMapDotNet.Entities.GeoJSON.GeoObjects</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Collection<LineString> Boundaries { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Boundaries As Collection(Of LineString)
	Get
```

**C++**<br />
``` C++
public:
property Collection<LineString^>^ Boundaries {
	Collection<LineString^>^ get ();
}
```

**F#**<br />
``` F#
member Boundaries : Collection<LineString> with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/ms132397" target="_blank">Collection</a>(<a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_LineString">LineString</a>)

## Remarks
Per the GeoJSON standard (RFC7946), clockwise rings represent the exterior boundary of the polygon, and counterclockwise rings represent holes.

## See Also


#### Reference
<a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_Polygon">Polygon Class</a><br /><a href="N_AirMapDotNet_Entities_GeoJSON_GeoObjects">AirMapDotNet.Entities.GeoJSON.GeoObjects Namespace</a><br />