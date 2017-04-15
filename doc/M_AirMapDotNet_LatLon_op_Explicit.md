# LatLon&nbsp;Explicit Conversion (Double[] to LatLon)
 

Explicitly converts a <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">Double</a> array into a <a href="T_AirMapDotNet_LatLon">LatLon</a> object.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public static explicit operator LatLon (
	double[] data
)
```

**VB**<br />
``` VB
Public Shared Narrowing Operator CType ( 
	data As Double()
) As LatLon
```

**C++**<br />
``` C++
static explicit operator LatLon^ (
	array<double>^ data
)
```

**F#**<br />
``` F#

```


#### Parameters
&nbsp;<dl><dt>data</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">System.Double</a>[]<br />The array of coordinates.</dd></dl>

#### Return Value
Type: <a href="T_AirMapDotNet_LatLon">LatLon</a><br />A <a href="T_AirMapDotNet_LatLon">LatLon</a> object that represents the array.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/8xt94y6e" target="_blank">ArgumentOutOfRangeException</a></td><td>If *data* does not have exactly two elements.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *data* is null.</td></tr></table>

## Remarks
This method assumes that array index 0 is the longitude, and array index 1 is the latitude.

## See Also


#### Reference
<a href="T_AirMapDotNet_LatLon">LatLon Class</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />