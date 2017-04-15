# AirMap.GetCurrentFlights Method (Geometry, Int32, Boolean)
 

Retrieves a list of all currently active flights within a geographic area.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Task<IEnumerable<Flight>> GetCurrentFlights(
	Geometry geom,
	int limit,
	bool enhance
)
```

**VB**<br />
``` VB
Public Function GetCurrentFlights ( 
	geom As Geometry,
	limit As Integer,
	enhance As Boolean
) As Task(Of IEnumerable(Of Flight))
```

**C++**<br />
``` C++
public:
Task<IEnumerable<Flight^>^>^ GetCurrentFlights(
	Geometry^ geom, 
	int limit, 
	bool enhance
)
```

**F#**<br />
``` F#
member GetCurrentFlights : 
        geom : Geometry * 
        limit : int * 
        enhance : bool -> Task<IEnumerable<Flight>> 

```


#### Parameters
&nbsp;<dl><dt>geom</dt><dd>Type: <a href="T_AirMapDotNet_Entities_GeoJSON_Geometry">AirMapDotNet.Entities.GeoJSON.Geometry</a><br />The geographic area to search.</dd><dt>limit</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />The maximum amount of flights to return.</dd><dt>enhance</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">System.Boolean</a><br />If <b>true</b>, the returned data will be enhanced with extra information.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="http://msdn2.microsoft.com/en-us/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="T_AirMapDotNet_Entities_FlightAPI_Flight">Flight</a>))<br />A list of allcurrently active flights in the area defined by *geom*.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *geom* is null.</td></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the request fails.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMap">AirMap Class</a><br /><a href="Overload_AirMapDotNet_AirMap_GetCurrentFlights">GetCurrentFlights Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />