# LatLon Class
 

Represents a latitude and longitude pair.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;AirMapDotNet.LatLon<br />
**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public class LatLon : IEquatable<LatLon>
```

**VB**<br />
``` VB
Public Class LatLon
	Implements IEquatable(Of LatLon)
```

**C++**<br />
``` C++
public ref class LatLon : IEquatable<LatLon^>
```

**F#**<br />
``` F#
type LatLon =  
    class
        interface IEquatable<LatLon>
    end
```

The LatLon type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_LatLon__ctor">LatLon</a></td><td>
Creates a new LatLon with the described *lat* and *lon*.</td></tr></table>&nbsp;
<a href="#latlon-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_LatLon_Latitude">Latitude</a></td><td>
The Latitude.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_LatLon_Longitude">Longitude</a></td><td>
The Longitude.</td></tr></table>&nbsp;
<a href="#latlon-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_LatLon_Bearing">Bearing</a></td><td>
Calculates the bearing from this LatLon to another LatLon.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_LatLon_Distance">Distance</a></td><td>
Calculates the distance between two LatLon points.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_LatLon_Equals_1">Equals(Object)</a></td><td>
Determines whether the specified <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a> is equal to the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Object.Equals(Object)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_LatLon_Equals">Equals(LatLon)</a></td><td>
Indicates whether the current object is equal to another object of the same type.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_LatLon_GetHashCode">GetHashCode</a></td><td>
Serves as a hash function for a particular type.
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">Object.GetHashCode()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_LatLon_Project">Project</a></td><td>
Projects a new LatLon exactly *bearing* degrees and *distance* meters away.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_LatLon_ToDMS">ToDMS</a></td><td>
Converts the LatLon object into a Degree-Minute-Second form.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_LatLon_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">Object.ToString()</a>.)</td></tr></table>&nbsp;
<a href="#latlon-class">Back to Top</a>

## Operators
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_AirMapDotNet_LatLon_op_Equality">Equality</a></td><td>
Determines whether *left* is equal to *right*.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_AirMapDotNet_LatLon_op_Explicit">Explicit(Double[] to LatLon)</a></td><td>
Explicitly converts a <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">Double</a> array into a LatLon object.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_AirMapDotNet_LatLon_op_Inequality">Inequality</a></td><td>
Determines whether *left* is not equal to *right*.</td></tr></table>&nbsp;
<a href="#latlon-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_AirMapDotNet_LatLon_EarthRadius">EarthRadius</a></td><td>
The mean radius of the Earth, defined as 6378.137 km.</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_AirMapDotNet_LatLon_Epsilon">Epsilon</a></td><td>
The absolute tolerance before the difference between latitudes or longitudes may be considered zero. In this case, roughly half an inch.</td></tr></table>&nbsp;
<a href="#latlon-class">Back to Top</a>

## See Also


#### Reference
<a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />