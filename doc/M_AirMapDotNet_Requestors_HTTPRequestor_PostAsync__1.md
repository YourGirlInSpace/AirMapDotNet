# HTTPRequestor.PostAsync(*T*) Method 
 

Posts an update for the resource at *uri*.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Requestors">AirMapDotNet.Requestors</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public override Task<T> PostAsync<T>(
	Uri uri,
	string apiKey,
	AuthenticationToken token,
	Object data
)
where T : class, IAirMapEntity

```

**VB**<br />
``` VB
Public Overrides Function PostAsync(Of T As {Class, IAirMapEntity}) ( 
	uri As Uri,
	apiKey As String,
	token As AuthenticationToken,
	data As Object
) As Task(Of T)
```

**C++**<br />
``` C++
public:
generic<typename T>
where T : ref class, IAirMapEntity
virtual Task<T>^ PostAsync(
	Uri^ uri, 
	String^ apiKey, 
	AuthenticationToken^ token, 
	Object^ data
) override
```

**F#**<br />
``` F#
abstract PostAsync : 
        uri : Uri * 
        apiKey : string * 
        token : AuthenticationToken * 
        data : Object -> Task<'T>  when 'T : not struct and IAirMapEntity
override PostAsync : 
        uri : Uri * 
        apiKey : string * 
        token : AuthenticationToken * 
        data : Object -> Task<'T>  when 'T : not struct and IAirMapEntity
```


#### Parameters
&nbsp;<dl><dt>uri</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/txt7706a" target="_blank">System.Uri</a><br />The URI of the resource.</dd><dt>apiKey</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Your AirMap API key.</dd><dt>token</dt><dd>Type: <a href="T_AirMapDotNet_Authentication_AuthenticationToken">AirMapDotNet.Authentication.AuthenticationToken</a><br />The authentication token to use in this request.</dd><dt>data</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />The data to post.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The underlying type returned from the resource.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(*T*)<br />The result of the posted data.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *uri* is null.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_Requestors_HTTPRequestor">HTTPRequestor Class</a><br /><a href="N_AirMapDotNet_Requestors">AirMapDotNet.Requestors Namespace</a><br />