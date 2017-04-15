# AirMap.EndFlight Method (String)
 

Ends a flight by its unique ID.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Task<DateTime> EndFlight(
	string flightId
)
```

**VB**<br />
``` VB
Public Function EndFlight ( 
	flightId As String
) As Task(Of DateTime)
```

**C++**<br />
``` C++
public:
Task<DateTime>^ EndFlight(
	String^ flightId
)
```

**F#**<br />
``` F#
member EndFlight : 
        flightId : string -> Task<DateTime> 

```


#### Parameters
&nbsp;<dl><dt>flightId</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The flight's unique ID.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="http://msdn2.microsoft.com/en-us/library/03ybds8y" target="_blank">DateTime</a>)<br />The time the flight was ended.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the request fails.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/szf0ccz1" target="_blank">AuthenticationException</a></td><td>If the <a href="P_AirMapDotNet_AirMap_AuthenticationToken">AuthenticationToken</a> is not set, or has expired, or the token is not valid for this resource.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *flightId* is null.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMap">AirMap Class</a><br /><a href="Overload_AirMapDotNet_AirMap_EndFlight">EndFlight Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />