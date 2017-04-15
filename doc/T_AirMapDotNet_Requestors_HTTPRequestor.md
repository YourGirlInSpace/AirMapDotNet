# HTTPRequestor Class
 

Provides several methods in which to interact with the AirMap API.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_AirMapDotNet_Requestors_Requestor">AirMapDotNet.Requestors.Requestor</a><br />&nbsp;&nbsp;&nbsp;&nbsp;AirMapDotNet.Requestors.HTTPRequestor<br />
**Namespace:**&nbsp;<a href="N_AirMapDotNet_Requestors">AirMapDotNet.Requestors</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public class HTTPRequestor : Requestor
```

**VB**<br />
``` VB
Public Class HTTPRequestor
	Inherits Requestor
```

**C++**<br />
``` C++
public ref class HTTPRequestor : public Requestor
```

**F#**<br />
``` F#
type HTTPRequestor =  
    class
        inherit Requestor
    end
```

The HTTPRequestor type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Requestors_HTTPRequestor__ctor">HTTPRequestor</a></td><td>
Initializes a new instance of the HTTPRequestor class</td></tr></table>&nbsp;
<a href="#httprequestor-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Requestors_HTTPRequestor_DeleteAsync">DeleteAsync</a></td><td>
Deletes the resource at *uri*.
 (Overrides <a href="M_AirMapDotNet_Requestors_Requestor_DeleteAsync">Requestor.DeleteAsync(Uri, String, AuthenticationToken)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Requestors_Requestor_DeserializeJSON__1">DeserializeJSON(T)</a></td><td>
Deserializes a JSON string into an object *T*.
 (Inherited from <a href="T_AirMapDotNet_Requestors_Requestor">Requestor</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a> is equal to the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Requestors_HTTPRequestor_GetAsync__1">GetAsync(T)</a></td><td>
Requests a specific resource using the *uri*.
 (Overrides <a href="M_AirMapDotNet_Requestors_Requestor_GetAsync__1">Requestor.GetAsync(T)(Uri, String, AuthenticationToken)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as a hash function for a particular type.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Requestors_HTTPRequestor_PatchAsync__1">PatchAsync(T)</a></td><td>
Patches the resource at *uri* with *data*.
 (Overrides <a href="M_AirMapDotNet_Requestors_Requestor_PatchAsync__1">Requestor.PatchAsync(T)(Uri, String, AuthenticationToken, Object)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Requestors_HTTPRequestor_PostAsync__1">PostAsync(T)</a></td><td>
Posts an update for the resource at *uri*.
 (Overrides <a href="M_AirMapDotNet_Requestors_Requestor_PostAsync__1">Requestor.PostAsync(T)(Uri, String, AuthenticationToken, Object)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Requestors_Requestor_SerializeJSON">SerializeJSON</a></td><td>
Serializes an object to a JSON string.
 (Inherited from <a href="T_AirMapDotNet_Requestors_Requestor">Requestor</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#httprequestor-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_AirMapDotNet_Requestors_HTTPRequestor_UserAgent">UserAgent</a></td><td>
The User Agent header sent to the AirMap API server.</td></tr></table>&nbsp;
<a href="#httprequestor-class">Back to Top</a>

## See Also


#### Reference
<a href="N_AirMapDotNet_Requestors">AirMapDotNet.Requestors Namespace</a><br />