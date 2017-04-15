# GeoUtilities.CreateCircle Method (LatLon, Double)
 

Creates a new <a href="T_AirMapDotNet_Entities_GeoJSON_Geometry">Geometry</a> object with a circular <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_Polygon">Polygon</a> feature with a radius of *radius* and the center position *center*.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public static Geometry CreateCircle(
	LatLon center,
	double radius
)
```

**VB**<br />
``` VB
Public Shared Function CreateCircle ( 
	center As LatLon,
	radius As Double
) As Geometry
```

**C++**<br />
``` C++
public:
static Geometry^ CreateCircle(
	LatLon^ center, 
	double radius
)
```

**F#**<br />
``` F#
static member CreateCircle : 
        center : LatLon * 
        radius : float -> Geometry 

```


#### Parameters
&nbsp;<dl><dt>center</dt><dd>Type: <a href="T_AirMapDotNet_LatLon">AirMapDotNet.LatLon</a><br />The center position.</dd><dt>radius</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">System.Double</a><br />The radius of the circle in meters.</dd></dl>

#### Return Value
Type: <a href="T_AirMapDotNet_Entities_GeoJSON_Geometry">Geometry</a><br />A <a href="T_AirMapDotNet_Entities_GeoJSON_Geometry">Geometry</a> object with a circular <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_Polygon">Polygon</a> feature.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *center* is null.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_GeoUtilities">GeoUtilities Class</a><br /><a href="Overload_AirMapDotNet_GeoUtilities_CreateCircle">CreateCircle Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />