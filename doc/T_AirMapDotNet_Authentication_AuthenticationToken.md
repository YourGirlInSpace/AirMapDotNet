# AuthenticationToken Class
 

The Authentication Token used to access user-restricted features of the AirMap API.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;AirMapDotNet.Authentication.AuthenticationToken<br />
**Namespace:**&nbsp;<a href="N_AirMapDotNet_Authentication">AirMapDotNet.Authentication</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public sealed class AuthenticationToken
```

**VB**<br />
``` VB
Public NotInheritable Class AuthenticationToken
```

**C++**<br />
``` C++
public ref class AuthenticationToken sealed
```

**F#**<br />
``` F#
[<SealedAttribute>]
type AuthenticationToken =  class end
```

The AuthenticationToken type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Authentication_AuthenticationToken__ctor">AuthenticationToken</a></td><td>
Creates a new AuthenticationToken from a JWT-encoded ID token.</td></tr></table>&nbsp;
<a href="#authenticationtoken-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Authentication_AuthenticationToken_Audience">Audience</a></td><td>
The audience field of the ID token.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Authentication_AuthenticationToken_Expiry">Expiry</a></td><td>
The time when this authentication token expires.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Authentication_AuthenticationToken_IssuedAt">IssuedAt</a></td><td>
The time when this authentication token was generated.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Authentication_AuthenticationToken_Issuer">Issuer</a></td><td>
The issuer field of the ID token.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Authentication_AuthenticationToken_IsValid">IsValid</a></td><td>
The authentication token's validity. <b>True</b> if the token is valid and in date, otherwise <b>false</b>.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Authentication_AuthenticationToken_Subject">Subject</a></td><td>
The subject field of the ID token.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Authentication_AuthenticationToken_Token">Token</a></td><td>
The full token passed in the Authentication HTTP header.</td></tr></table>&nbsp;
<a href="#authenticationtoken-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a> is equal to the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as a hash function for a particular type.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#authenticationtoken-class">Back to Top</a>

## Remarks
The Authentication Token is the ID token returned through the AirMap Javascript Authentication library. It is a JWT token that does not require signature validation.

## See Also


#### Reference
<a href="N_AirMapDotNet_Authentication">AirMapDotNet.Authentication Namespace</a><br />