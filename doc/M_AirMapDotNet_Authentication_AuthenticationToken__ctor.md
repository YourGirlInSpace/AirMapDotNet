# AuthenticationToken Constructor 
 

Creates a new <a href="T_AirMapDotNet_Authentication_AuthenticationToken">AuthenticationToken</a> from a JWT-encoded ID token.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Authentication">AirMapDotNet.Authentication</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public AuthenticationToken(
	string token
)
```

**VB**<br />
``` VB
Public Sub New ( 
	token As String
)
```

**C++**<br />
``` C++
public:
AuthenticationToken(
	String^ token
)
```

**F#**<br />
``` F#
new : 
        token : string -> AuthenticationToken
```


#### Parameters
&nbsp;<dl><dt>token</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />A JWT-encoded ID token provided by AirMap's SSO</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *token* is null.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_Authentication_AuthenticationToken">AuthenticationToken Class</a><br /><a href="N_AirMapDotNet_Authentication">AirMapDotNet.Authentication Namespace</a><br />