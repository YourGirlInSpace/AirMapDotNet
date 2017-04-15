# AirMap.GetStatus Method (LatLon, Boolean)
 

Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied position with optional weather information.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Task<Status> GetStatus(
	LatLon latlon,
	bool weather
)
```

**VB**<br />
``` VB
Public Function GetStatus ( 
	latlon As LatLon,
	weather As Boolean
) As Task(Of Status)
```

**C++**<br />
``` C++
public:
Task<Status^>^ GetStatus(
	LatLon^ latlon, 
	bool weather
)
```

**F#**<br />
``` F#
member GetStatus : 
        latlon : LatLon * 
        weather : bool -> Task<Status> 

```


#### Parameters
&nbsp;<dl><dt>latlon</dt><dd>Type: <a href="T_AirMapDotNet_LatLon">AirMapDotNet.LatLon</a><br />The <a href="T_AirMapDotNet_LatLon">LatLon</a> of the launch point.</dd><dt>weather</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">System.Boolean</a><br />If <b>true</b>, weather information will be supplied in the response.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a>)<br />A <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object describing the status of the flight area.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *latlon* is null.</td></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the request fails.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMap">AirMap Class</a><br /><a href="Overload_AirMapDotNet_AirMap_GetStatus">GetStatus Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />