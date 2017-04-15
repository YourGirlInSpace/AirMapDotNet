# AirMap.GetProfile Method 
 

Retrieves the profile for the currently authenticated user.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Task<PilotProfile> GetProfile()
```

**VB**<br />
``` VB
Public Function GetProfile As Task(Of PilotProfile)
```

**C++**<br />
``` C++
public:
Task<PilotProfile^>^ GetProfile()
```

**F#**<br />
``` F#
member GetProfile : unit -> Task<PilotProfile> 

```


#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="T_AirMapDotNet_Entities_PilotAPI_PilotProfile">PilotProfile</a>)<br />A <a href="T_AirMapDotNet_Entities_PilotAPI_PilotProfile">PilotProfile</a> containing details on the currently authenticated user.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_AirMapDotNet_Authentication_AuthenticationException">AuthenticationException</a></td><td>If the <a href="P_AirMapDotNet_AirMap_AuthenticationToken">AuthenticationToken</a> is not set, or has expired, or the token is not valid for this resource.</td></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the request fails.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMap">AirMap Class</a><br /><a href="Overload_AirMapDotNet_AirMap_GetProfile">GetProfile Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />