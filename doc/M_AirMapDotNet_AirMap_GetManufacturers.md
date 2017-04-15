# AirMap.GetManufacturers Method 
 

Retrieves the list of recognized manufacturers.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Task<Manufacturer[]> GetManufacturers()
```

**VB**<br />
``` VB
Public Function GetManufacturers As Task(Of Manufacturer())
```

**C++**<br />
``` C++
public:
Task<array<Manufacturer^>^>^ GetManufacturers()
```

**F#**<br />
``` F#
member GetManufacturers : unit -> Task<Manufacturer[]> 

```


#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="T_AirMapDotNet_Entities_AircraftAPI_Manufacturer">Manufacturer</a>[])<br />A list of recognized manufacturers.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the request fails.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMap">AirMap Class</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />