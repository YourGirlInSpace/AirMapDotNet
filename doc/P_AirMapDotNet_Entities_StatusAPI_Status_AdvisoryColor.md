# Status.AdvisoryColor Property 
 

The advisory color.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities_StatusAPI">AirMapDotNet.Entities.StatusAPI</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public string AdvisoryColor { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property AdvisoryColor As String
	Get
```

**C++**<br />
``` C++
public:
property String^ AdvisoryColor {
	String^ get ();
}
```

**F#**<br />
``` F#
member AdvisoryColor : string with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## Remarks

The color follows a simple traffic light pattern.

Green indicates that there are no known advisories, and it is probably safe to fly.

Yellow indicates that the operator may require additional authorization or actions to fly in the area.

Red indicates that the flight area is strictly regulated and is probably not safe to fly for the majority of operators.


## See Also


#### Reference
<a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status Class</a><br /><a href="N_AirMapDotNet_Entities_StatusAPI">AirMapDotNet.Entities.StatusAPI Namespace</a><br />