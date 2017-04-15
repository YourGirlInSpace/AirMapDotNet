# LatLon.Project Method 
 

Projects a new <a href="T_AirMapDotNet_LatLon">LatLon</a> exactly *bearing* degrees and *distance* meters away.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public LatLon Project(
	double bearing,
	double distance
)
```

**VB**<br />
``` VB
Public Function Project ( 
	bearing As Double,
	distance As Double
) As LatLon
```

**C++**<br />
``` C++
public:
LatLon^ Project(
	double bearing, 
	double distance
)
```

**F#**<br />
``` F#
member Project : 
        bearing : float * 
        distance : float -> LatLon 

```


#### Parameters
&nbsp;<dl><dt>bearing</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">System.Double</a><br />The bearing to the new point, in degrees.</dd><dt>distance</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">System.Double</a><br />The distance to the new point, in meters.</dd></dl>

#### Return Value
Type: <a href="T_AirMapDotNet_LatLon">LatLon</a><br />The projected <a href="T_AirMapDotNet_LatLon">LatLon</a>.

## See Also


#### Reference
<a href="T_AirMapDotNet_LatLon">LatLon Class</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />