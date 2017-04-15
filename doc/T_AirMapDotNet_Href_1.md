# Href(*T*) Class
 

Represents a link to an AirMap API resource.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;AirMapDotNet.Href(T)<br />
**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public class Href<T> : IEquatable<Href<T>>
where T : class, IAirMapEntity

```

**VB**<br />
``` VB
Public Class Href(Of T As {Class, IAirMapEntity})
	Implements IEquatable(Of Href(Of T))
```

**C++**<br />
``` C++
generic<typename T>
where T : ref class, IAirMapEntity
public ref class Href : IEquatable<Href<T>^>
```

**F#**<br />
``` F#
type Href<'T when 'T : not struct and IAirMapEntity> =  
    class
        interface IEquatable<Href<'T>>
    end
```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The underlying type behind the link.</dd></dl>&nbsp;
The Href(T) type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Href_1__ctor">Href(T)()</a></td><td>
Creates a new Href(T) with an empty <a href="P_AirMapDotNet_Href_1_Uri">Uri</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Href_1__ctor_1">Href(T)(Uri)</a></td><td>
Creates a new Href(T) with the specified URI.</td></tr></table>&nbsp;
<a href="#href(*t*)-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Href_1_Uri">Uri</a></td><td>
The URI where the resource may be found.</td></tr></table>&nbsp;
<a href="#href(*t*)-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Href_1_Compile">Compile()</a></td><td>
Compiles the Href(T) into a URL.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Href_1_Compile_1">Compile(NameValueCollection)</a></td><td>
Compiles the Href(T) into a URL with the specified query parameters.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Href_1_Equals_1">Equals(Object)</a></td><td>
Determines whether the specified object is equal to the current object.
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Object.Equals(Object)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Href_1_Equals">Equals(Href(T))</a></td><td>
Indicates whether the current object is equal to another object of the same type.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Href_1_GetHashCode">GetHashCode</a></td><td>
Serves as the default hash function.
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">Object.GetHashCode()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#href(*t*)-class">Back to Top</a>

## Operators
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_AirMapDotNet_Href_1_op_Equality">Equality</a></td><td>
Determines whether the current Href(T) is equal to another Href(T).</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_AirMapDotNet_Href_1_op_Inequality">Inequality</a></td><td>
Determines whether the current Href(T) is not equal to another Href(T).</td></tr></table>&nbsp;
<a href="#href(*t*)-class">Back to Top</a>

## See Also


#### Reference
<a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />