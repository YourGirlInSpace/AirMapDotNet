# AirMap.CreateFlight Method 
 

Creates a new flight using the parameters in <a href="T_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters">FlightCreationParameters</a>.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Task<Flight> CreateFlight(
	FlightCreationParameters creationParams
)
```

**VB**<br />
``` VB
Public Function CreateFlight ( 
	creationParams As FlightCreationParameters
) As Task(Of Flight)
```

**C++**<br />
``` C++
public:
Task<Flight^>^ CreateFlight(
	FlightCreationParameters^ creationParams
)
```

**F#**<br />
``` F#
member CreateFlight : 
        creationParams : FlightCreationParameters -> Task<Flight> 

```


#### Parameters
&nbsp;<dl><dt>creationParams</dt><dd>Type: <a href="T_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters">AirMapDotNet.Entities.FlightAPI.FlightCreationParameters</a><br />The parameters of the new flight.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="T_AirMapDotNet_Entities_FlightAPI_Flight">Flight</a>)<br />The created flight.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td /></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/szf0ccz1" target="_blank">AuthenticationException</a></td><td>If the <a href="P_AirMapDotNet_AirMap_AuthenticationToken">AuthenticationToken</a> is not set, or has expired, or the token is not valid for this resource.</td></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the <a href="P_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters_Geometry">Geometry</a> property of *creationParams* is not a <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_LineString">LineString</a> or <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_Polygon">Polygon</a>.</td></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the request fails.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMap">AirMap Class</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />