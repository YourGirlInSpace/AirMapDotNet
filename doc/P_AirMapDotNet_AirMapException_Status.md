# AirMapException.Status Property 
 

The status code sent from the AirMap API.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public JSendStatus Status { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Status As JSendStatus
	Get
```

**C++**<br />
``` C++
public:
property JSendStatus Status {
	JSendStatus get ();
}
```

**F#**<br />
``` F#
member Status : JSendStatus with get

```


#### Property Value
Type: <a href="T_AirMapDotNet_JSendStatus">JSendStatus</a><br />A <a href="T_AirMapDotNet_JSendStatus">JSendStatus</a> representation of the AirMap API response data's "status" property.

## Remarks

The status code is determined from the JSend specification.
&nbsp;<table><tr><td><a href="T_AirMapDotNet_JSendStatus">Success</a></td><td>All went well, and (usually) some data was returned.</td></tr><tr><td><a href="T_AirMapDotNet_JSendStatus">Fail</a></td><td>There was a problem with the data submitted, or some pre-condition of the API call wasn't satisfied.</td></tr><tr><td><a href="T_AirMapDotNet_JSendStatus">Error</a></td><td>An error occurred in processing the request, i.e. an exception was thrown.</td></tr></table>&nbsp;
Additionally, the <a href="T_AirMapDotNet_JSendStatus">JSendStatus</a> contains an <a href="T_AirMapDotNet_JSendStatus">Unknown</a> value which represents a state in which either the status property was not set, or it does not apply.


## See Also


#### Reference
<a href="T_AirMapDotNet_AirMapException">AirMapException Class</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />