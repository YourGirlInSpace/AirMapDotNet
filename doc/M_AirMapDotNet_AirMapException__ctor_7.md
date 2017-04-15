# AirMapException Constructor (String, AirMapErrorData, Exception)
 

Initializes a new instance of the AirMapException class with a specified error message and a reference to the inner exception that is the cause of this exception.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public AirMapException(
	string message,
	AirMapErrorData data,
	Exception inner
)
```

**VB**<br />
``` VB
Public Sub New ( 
	message As String,
	data As AirMapErrorData,
	inner As Exception
)
```

**C++**<br />
``` C++
public:
AirMapException(
	String^ message, 
	AirMapErrorData^ data, 
	Exception^ inner
)
```

**F#**<br />
``` F#
new : 
        message : string * 
        data : AirMapErrorData * 
        inner : Exception -> AirMapException
```


#### Parameters
&nbsp;<dl><dt>message</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The error message that explains the reason for the exception.</dd><dt>data</dt><dd>Type: <a href="T_AirMapDotNet_Entities_AirMapErrorData">AirMapDotNet.Entities.AirMapErrorData</a><br />A representation of the fields that caused the error and how they failed.</dd><dt>inner</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">System.Exception</a><br />The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</dd></dl>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMapException">AirMapException Class</a><br /><a href="Overload_AirMapDotNet_AirMapException__ctor">AirMapException Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />