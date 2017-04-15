# AirMapException Constructor (AirMapErrorData)
 

Initializes a new instance of the AirMapException class.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public AirMapException(
	AirMapErrorData data
)
```

**VB**<br />
``` VB
Public Sub New ( 
	data As AirMapErrorData
)
```

**C++**<br />
``` C++
public:
AirMapException(
	AirMapErrorData^ data
)
```

**F#**<br />
``` F#
new : 
        data : AirMapErrorData -> AirMapException
```


#### Parameters
&nbsp;<dl><dt>data</dt><dd>Type: <a href="T_AirMapDotNet_Entities_AirMapErrorData">AirMapDotNet.Entities.AirMapErrorData</a><br />A representation of the fields that caused the error and how they failed.</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *data* is null.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMapException">AirMapException Class</a><br /><a href="Overload_AirMapDotNet_AirMapException__ctor">AirMapException Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />