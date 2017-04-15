# AirMap.GetModel Method 
 

Retrieves a drone model using its unique GUID.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Task<Model> GetModel(
	string modelId
)
```

**VB**<br />
``` VB
Public Function GetModel ( 
	modelId As String
) As Task(Of Model)
```

**C++**<br />
``` C++
public:
Task<Model^>^ GetModel(
	String^ modelId
)
```

**F#**<br />
``` F#
member GetModel : 
        modelId : string -> Task<Model> 

```


#### Parameters
&nbsp;<dl><dt>modelId</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The drone model's GUID.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="T_AirMapDotNet_Entities_AircraftAPI_Model">Model</a>)<br />A <a href="T_AirMapDotNet_Entities_AircraftAPI_Model">Model</a> containing the drone model's information.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the request fails.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *modelId* is null or equals <a href="http://msdn2.microsoft.com/en-us/library/74wsya52" target="_blank">Empty</a>.</td></tr></table>

## Examples

```
AirMap am = new AirMap("YOUR API KEY");

// Information on the Phantom 3
var phantom3 = await am.GetModel("b3b1c26f-06da-4eae-9390-667c90039175");
```


## See Also


#### Reference
<a href="T_AirMapDotNet_AirMap">AirMap Class</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />