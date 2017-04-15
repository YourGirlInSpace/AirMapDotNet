# AuthenticationException Constructor (SerializationInfo, StreamingContext)
 

Initializes a new instance of the <a href="T_AirMapDotNet_Authentication_AuthenticationException">AuthenticationException</a> with serialized data.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Authentication">AirMapDotNet.Authentication</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
protected AuthenticationException(
	SerializationInfo info,
	StreamingContext context
)
```

**VB**<br />
``` VB
Protected Sub New ( 
	info As SerializationInfo,
	context As StreamingContext
)
```

**C++**<br />
``` C++
protected:
AuthenticationException(
	SerializationInfo^ info, 
	StreamingContext context
)
```

**F#**<br />
``` F#
new : 
        info : SerializationInfo * 
        context : StreamingContext -> AuthenticationException
```


#### Parameters
&nbsp;<dl><dt>info</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/a9b6042e" target="_blank">System.Runtime.Serialization.SerializationInfo</a><br />The <a href="http://msdn2.microsoft.com/en-us/library/a9b6042e" target="_blank">SerializationInfo</a> that holds the serialized object data about the exception being thrown.</dd><dt>context</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/t16abws5" target="_blank">System.Runtime.Serialization.StreamingContext</a><br />The <a href="http://msdn2.microsoft.com/en-us/library/t16abws5" target="_blank">StreamingContext</a> that contains contextual information about the source or destination.</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>The *info* parameter is <b>null</b>.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/akw26cdk" target="_blank">SerializationException</a></td><td>The class name is <b>null</b> or <a href="http://msdn2.microsoft.com/en-us/library/sh5cw61c" target="_blank">HResult</a> is zero (0).</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_Authentication_AuthenticationException">AuthenticationException Class</a><br /><a href="Overload_AirMapDotNet_Authentication_AuthenticationException__ctor">AuthenticationException Overload</a><br /><a href="N_AirMapDotNet_Authentication">AirMapDotNet.Authentication Namespace</a><br />