# Requestor.DeleteAsync Method 
 

Deletes the resource at *uri*.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Requestors">AirMapDotNet.Requestors</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public abstract Task<JSendStatus> DeleteAsync(
	Uri uri,
	string apiKey,
	AuthenticationToken token
)
```

**VB**<br />
``` VB
Public MustOverride Function DeleteAsync ( 
	uri As Uri,
	apiKey As String,
	token As AuthenticationToken
) As Task(Of JSendStatus)
```

**C++**<br />
``` C++
public:
virtual Task<JSendStatus>^ DeleteAsync(
	Uri^ uri, 
	String^ apiKey, 
	AuthenticationToken^ token
) abstract
```

**F#**<br />
``` F#
abstract DeleteAsync : 
        uri : Uri * 
        apiKey : string * 
        token : AuthenticationToken -> Task<JSendStatus> 

```


#### Parameters
&nbsp;<dl><dt>uri</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/txt7706a" target="_blank">System.Uri</a><br />The URI of the resource.</dd><dt>apiKey</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Your AirMap API key.</dd><dt>token</dt><dd>Type: <a href="T_AirMapDotNet_Authentication_AuthenticationToken">AirMapDotNet.Authentication.AuthenticationToken</a><br />The authentication token to use in this request.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="T_AirMapDotNet_JSendStatus">JSendStatus</a>)<br />The result of the deletion.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *uri* is null.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_Requestors_Requestor">Requestor Class</a><br /><a href="N_AirMapDotNet_Requestors">AirMapDotNet.Requestors Namespace</a><br />