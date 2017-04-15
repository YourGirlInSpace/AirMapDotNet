# AirMap.GetStatus Method (Geometry, Double)
 

Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied geometry and a radius *buffer* around the geometry.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Task<Status> GetStatus(
	Geometry geom,
	double buffer
)
```

**VB**<br />
``` VB
Public Function GetStatus ( 
	geom As Geometry,
	buffer As Double
) As Task(Of Status)
```

**C++**<br />
``` C++
public:
Task<Status^>^ GetStatus(
	Geometry^ geom, 
	double buffer
)
```

**F#**<br />
``` F#
member GetStatus : 
        geom : Geometry * 
        buffer : float -> Task<Status> 

```


#### Parameters
&nbsp;<dl><dt>geom</dt><dd>Type: <a href="T_AirMapDotNet_Entities_GeoJSON_Geometry">AirMapDotNet.Entities.GeoJSON.Geometry</a><br />The geometry of the flight area.</dd><dt>buffer</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">System.Double</a><br />The buffer around a <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_LineString">LineString</a>.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a>)<br />A <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object describing the status of the flight area.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If *geom* is not a <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_LineString">LineString</a> or <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_Polygon">Polygon</a>.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *geom* is null.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/8xt94y6e" target="_blank">ArgumentOutOfRangeException</a></td><td>If *buffer* is not in the range 0 to 10000.</td></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the request fails.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMap">AirMap Class</a><br /><a href="Overload_AirMapDotNet_AirMap_GetStatus">GetStatus Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />