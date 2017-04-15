# GeoUtilities.CreateCircle Method (LatLon, Double, Int32)
 

Creates a new <a href="T_AirMapDotNet_Entities_GeoJSON_Geometry">Geometry</a> object with a circular <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_Polygon">Polygon</a> feature with a radius of *radius* and the center position *center*.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public static Geometry CreateCircle(
	LatLon center,
	double radius,
	int points
)
```

**VB**<br />
``` VB
Public Shared Function CreateCircle ( 
	center As LatLon,
	radius As Double,
	points As Integer
) As Geometry
```

**C++**<br />
``` C++
public:
static Geometry^ CreateCircle(
	LatLon^ center, 
	double radius, 
	int points
)
```

**F#**<br />
``` F#
static member CreateCircle : 
        center : LatLon * 
        radius : float * 
        points : int -> Geometry 

```


#### Parameters
&nbsp;<dl><dt>center</dt><dd>Type: <a href="T_AirMapDotNet_LatLon">AirMapDotNet.LatLon</a><br />The center position.</dd><dt>radius</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">System.Double</a><br />The radius of the circle in meters.</dd><dt>points</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />The number of points describing the circumference of the circle up to a maximum of 64.</dd></dl>

#### Return Value
Type: <a href="T_AirMapDotNet_Entities_GeoJSON_Geometry">Geometry</a><br />A <a href="T_AirMapDotNet_Entities_GeoJSON_Geometry">Geometry</a> object with a circular <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_Polygon">Polygon</a> feature.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/8xt94y6e" target="_blank">ArgumentOutOfRangeException</a></td><td>If the number of points is less than 3 or greater than 64.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *center* is null.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_GeoUtilities">GeoUtilities Class</a><br /><a href="Overload_AirMapDotNet_GeoUtilities_CreateCircle">CreateCircle Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />