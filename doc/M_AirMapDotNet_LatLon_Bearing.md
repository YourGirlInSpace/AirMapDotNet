# LatLon.Bearing Method 
 

Calculates the bearing from this <a href="T_AirMapDotNet_LatLon">LatLon</a> to another <a href="T_AirMapDotNet_LatLon">LatLon</a>.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public double Bearing(
	LatLon other
)
```

**VB**<br />
``` VB
Public Function Bearing ( 
	other As LatLon
) As Double
```

**C++**<br />
``` C++
public:
double Bearing(
	LatLon^ other
)
```

**F#**<br />
``` F#
member Bearing : 
        other : LatLon -> float 

```


#### Parameters
&nbsp;<dl><dt>other</dt><dd>Type: <a href="T_AirMapDotNet_LatLon">AirMapDotNet.LatLon</a><br />The other <a href="T_AirMapDotNet_LatLon">LatLon</a>.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">Double</a><br />The bearing from this <a href="T_AirMapDotNet_LatLon">LatLon</a> to *other*.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *other* is null.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_LatLon">LatLon Class</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />