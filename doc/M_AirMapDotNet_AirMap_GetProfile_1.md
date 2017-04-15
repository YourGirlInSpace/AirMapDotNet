# AirMap.GetProfile Method (String)
 

Retrieves the profile of the user with ID *uid*.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Task<PilotProfile> GetProfile(
	string uid
)
```

**VB**<br />
``` VB
Public Function GetProfile ( 
	uid As String
) As Task(Of PilotProfile)
```

**C++**<br />
``` C++
public:
Task<PilotProfile^>^ GetProfile(
	String^ uid
)
```

**F#**<br />
``` F#
member GetProfile : 
        uid : string -> Task<PilotProfile> 

```


#### Parameters
&nbsp;<dl><dt>uid</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The unique ID of the user.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="T_AirMapDotNet_Entities_PilotAPI_PilotProfile">PilotProfile</a>)<br />A <a href="T_AirMapDotNet_Entities_PilotAPI_PilotProfile">PilotProfile</a> containing publically-available details on the user.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the request fails.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *uid* is null or equals <a href="http://msdn2.microsoft.com/en-us/library/74wsya52" target="_blank">Empty</a>.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMap">AirMap Class</a><br /><a href="Overload_AirMapDotNet_AirMap_GetProfile">GetProfile Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />