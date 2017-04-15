# AirMapException Constructor (String, JSendStatus, Exception)
 

Initializes a new instance of the AirMapException class with a specified error message, a status code and a reference to the inner exception that is the cause of this exception.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public AirMapException(
	string message,
	JSendStatus status,
	Exception inner
)
```

**VB**<br />
``` VB
Public Sub New ( 
	message As String,
	status As JSendStatus,
	inner As Exception
)
```

**C++**<br />
``` C++
public:
AirMapException(
	String^ message, 
	JSendStatus status, 
	Exception^ inner
)
```

**F#**<br />
``` F#
new : 
        message : string * 
        status : JSendStatus * 
        inner : Exception -> AirMapException
```


#### Parameters
&nbsp;<dl><dt>message</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The error message that explains the reason for the exception.</dd><dt>status</dt><dd>Type: <a href="T_AirMapDotNet_JSendStatus">AirMapDotNet.JSendStatus</a><br />A <a href="T_AirMapDotNet_JSendStatus">JSendStatus</a> representation of the resultant status property.</dd><dt>inner</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">System.Exception</a><br />The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</dd></dl>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMapException">AirMapException Class</a><br /><a href="Overload_AirMapDotNet_AirMapException__ctor">AirMapException Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />