# AirMap.GetModels Method 
 

Retrieves a list of drone models.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Task<Model[]> GetModels(
	string manufacturerID,
	string modelFilter
)
```

**VB**<br />
``` VB
Public Function GetModels ( 
	manufacturerID As String,
	modelFilter As String
) As Task(Of Model())
```

**C++**<br />
``` C++
public:
Task<array<Model^>^>^ GetModels(
	String^ manufacturerID, 
	String^ modelFilter
)
```

**F#**<br />
``` F#
member GetModels : 
        manufacturerID : string * 
        modelFilter : string -> Task<Model[]> 

```


#### Parameters
&nbsp;<dl><dt>manufacturerID</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Optional manufacturer GUID.</dd><dt>modelFilter</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Optional model filter.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="T_AirMapDotNet_Entities_AircraftAPI_Model">Model</a>[])<br />A list of drone models filtered by *manufacturerID* and *modelFilter*.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the request fails.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If both *modelFilter* and *manufacturerID* are null or equals <a href="http://msdn2.microsoft.com/en-us/library/74wsya52" target="_blank">Empty</a>.</td></tr></table>

## Remarks
The filters both expect full phrases, such as "Phantom" for the Phantom 3.

## Examples

```
AirMap am = new AirMap("YOUR API KEY");

// All Phantom drones from DJI
var phantoms = await am.GetModels(manufacturerID: "2a55b47e-ca49-4b7e-99c7-dee9cd784ec9", modelFilter: "phantom");

// All drones by Yuneec
var phantoms = await am.GetModels(manufacturerID: "0c71de37-d500-4702-91ef-56d7ec606aa7");

// All drones containing the word "Typhoon"
var phantoms = await am.GetModels(modelFilter: "Typhoon");
```


## See Also


#### Reference
<a href="T_AirMapDotNet_AirMap">AirMap Class</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />