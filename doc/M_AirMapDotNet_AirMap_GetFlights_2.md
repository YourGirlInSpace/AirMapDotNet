# AirMap.GetFlights Method (String, Boolean)
 

Retrieves a list of all flights within a geographic area.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Task<IEnumerable<Flight>> GetFlights(
	string geoJson,
	bool enhance
)
```

**VB**<br />
``` VB
Public Function GetFlights ( 
	geoJson As String,
	enhance As Boolean
) As Task(Of IEnumerable(Of Flight))
```

**C++**<br />
``` C++
public:
Task<IEnumerable<Flight^>^>^ GetFlights(
	String^ geoJson, 
	bool enhance
)
```

**F#**<br />
``` F#
member GetFlights : 
        geoJson : string * 
        enhance : bool -> Task<IEnumerable<Flight>> 

```


#### Parameters
&nbsp;<dl><dt>geoJson</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />A description of the area to request in <a href="http://geojson.org/">GeoJSON</a> format.</dd><dt>enhance</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">System.Boolean</a><br />If <b>true</b>, the response will populate detailed fields such as <i>aircraft</i> or <i>pilot</i>.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="http://msdn2.microsoft.com/en-us/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="T_AirMapDotNet_Entities_FlightAPI_Flight">Flight</a>))<br />A list of all flights inside the area defined in *geoJson*.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the request fails.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *geoJson* is null or equals <a href="http://msdn2.microsoft.com/en-us/library/74wsya52" target="_blank">Empty</a>.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMap">AirMap Class</a><br /><a href="Overload_AirMapDotNet_AirMap_GetFlights">GetFlights Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />