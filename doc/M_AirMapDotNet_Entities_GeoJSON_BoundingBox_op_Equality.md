# BoundingBox.Equality Operator 
 

Determines whether *left* is equal to *right*.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities_GeoJSON">AirMapDotNet.Entities.GeoJSON</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public static bool operator ==(
	BoundingBox left,
	BoundingBox right
)
```

**VB**<br />
``` VB
Public Shared Operator = ( 
	left As BoundingBox,
	right As BoundingBox
) As Boolean
```

**C++**<br />
``` C++
public:
static bool operator ==(
	BoundingBox^ left, 
	BoundingBox^ right
)
```

**F#**<br />
``` F#
static let inline (=)
        left : BoundingBox * 
        right : BoundingBox  : bool
```


#### Parameters
&nbsp;<dl><dt>left</dt><dd>Type: <a href="T_AirMapDotNet_Entities_GeoJSON_BoundingBox">AirMapDotNet.Entities.GeoJSON.BoundingBox</a><br />The first <a href="T_AirMapDotNet_Entities_GeoJSON_BoundingBox">BoundingBox</a>.</dd><dt>right</dt><dd>Type: <a href="T_AirMapDotNet_Entities_GeoJSON_BoundingBox">AirMapDotNet.Entities.GeoJSON.BoundingBox</a><br />The second <a href="T_AirMapDotNet_Entities_GeoJSON_BoundingBox">BoundingBox</a>.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br /><b>True</b> if *left* equals *right*, otherwise <b>false</b>.

## See Also


#### Reference
<a href="T_AirMapDotNet_Entities_GeoJSON_BoundingBox">BoundingBox Class</a><br /><a href="N_AirMapDotNet_Entities_GeoJSON">AirMapDotNet.Entities.GeoJSON Namespace</a><br />