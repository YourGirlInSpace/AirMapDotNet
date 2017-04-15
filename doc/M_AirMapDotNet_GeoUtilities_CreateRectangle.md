# GeoUtilities.CreateRectangle Method 
 

Creates a new <a href="T_AirMapDotNet_Entities_GeoJSON_Geometry">Geometry</a> object with a rectanglular <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_Polygon">Polygon</a> feature.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public static Geometry CreateRectangle(
	LatLon topLeft,
	LatLon bottomRight
)
```

**VB**<br />
``` VB
Public Shared Function CreateRectangle ( 
	topLeft As LatLon,
	bottomRight As LatLon
) As Geometry
```

**C++**<br />
``` C++
public:
static Geometry^ CreateRectangle(
	LatLon^ topLeft, 
	LatLon^ bottomRight
)
```

**F#**<br />
``` F#
static member CreateRectangle : 
        topLeft : LatLon * 
        bottomRight : LatLon -> Geometry 

```


#### Parameters
&nbsp;<dl><dt>topLeft</dt><dd>Type: <a href="T_AirMapDotNet_LatLon">AirMapDotNet.LatLon</a><br />The top left coordinate of the rectangle.</dd><dt>bottomRight</dt><dd>Type: <a href="T_AirMapDotNet_LatLon">AirMapDotNet.LatLon</a><br />The bottom right coordinate of the rectangle.</dd></dl>

#### Return Value
Type: <a href="T_AirMapDotNet_Entities_GeoJSON_Geometry">Geometry</a><br />A <a href="T_AirMapDotNet_Entities_GeoJSON_Geometry">Geometry</a> object with a rectangular <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_Polygon">Polygon</a> feature.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If either *topLeft* or *bottomRight* are null.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_GeoUtilities">GeoUtilities Class</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />