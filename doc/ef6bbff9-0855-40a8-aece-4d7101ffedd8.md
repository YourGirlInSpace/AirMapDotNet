# AuthenticationToken Constructor 
 

Creates a new <a href="15258315-443b-55bc-8fbf-3bec8544fd11">AuthenticationToken</a> from a JWT-encoded ID token.

**Namespace:**&nbsp;<a href="acef933e-de19-163e-6ced-ad25d7d780e7">AirMapDotNet.Authentication</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

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
<a href="15258315-443b-55bc-8fbf-3bec8544fd11">AuthenticationToken Class</a><br /><a href="acef933e-de19-163e-6ced-ad25d7d780e7">AirMapDotNet.Authentication Namespace</a><br />