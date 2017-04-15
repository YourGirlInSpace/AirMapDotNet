# AirMapException Constructor (String, JSendStatus, AirMapErrorData)
 

Initializes a new instance of the Exception class with a specified error message and a status code..

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public AirMapException(
	string message,
	JSendStatus status,
	AirMapErrorData data
)
```

**VB**<br />
``` VB
Public Sub New ( 
	message As String,
	status As JSendStatus,
	data As AirMapErrorData
)
```

**C++**<br />
``` C++
public:
AirMapException(
	String^ message, 
	JSendStatus status, 
	AirMapErrorData^ data
)
```

**F#**<br />
``` F#
new : 
        message : string * 
        status : JSendStatus * 
        data : AirMapErrorData -> AirMapException
```


#### Parameters
&nbsp;<dl><dt>message</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The error message that explains the reason for the exception.</dd><dt>status</dt><dd>Type: <a href="T_AirMapDotNet_JSendStatus">AirMapDotNet.JSendStatus</a><br />A <a href="T_AirMapDotNet_JSendStatus">JSendStatus</a> representation of the resultant status property.</dd><dt>data</dt><dd>Type: <a href="T_AirMapDotNet_Entities_AirMapErrorData">AirMapDotNet.Entities.AirMapErrorData</a><br />A representation of the fields that caused the error and how they failed.</dd></dl>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMapException">AirMapException Class</a><br /><a href="Overload_AirMapDotNet_AirMapException__ctor">AirMapException Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />