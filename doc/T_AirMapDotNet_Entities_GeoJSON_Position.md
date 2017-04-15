# Position Class
 

Represents a three-dimensional position on a map.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;AirMapDotNet.Entities.GeoJSON.Position<br />
**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities_GeoJSON">AirMapDotNet.Entities.GeoJSON</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public sealed class Position : IEquatable<Position>
```

**VB**<br />
``` VB
Public NotInheritable Class Position
	Implements IEquatable(Of Position)
```

**C++**<br />
``` C++
public ref class Position sealed : IEquatable<Position^>
```

**F#**<br />
``` F#
[<SealedAttribute>]
type Position =  
    class
        interface IEquatable<Position>
    end
```

The Position type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_GeoJSON_Position__ctor">Position()</a></td><td>
Creates a new Position.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_GeoJSON_Position__ctor_1">Position(LatLon)</a></td><td>
Creates a new Position.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_GeoJSON_Position__ctor_2">Position(LatLon, Double)</a></td><td>
Creates a new Position.</td></tr></table>&nbsp;
<a href="#position-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_GeoJSON_Position_Elevation">Elevation</a></td><td>
The elevation of the position above the WGS84 reference ellipsoid in meters.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_GeoJSON_Position_LatLon">LatLon</a></td><td>
The Latitude and Longitude of the position,</td></tr></table>&nbsp;
<a href="#position-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_GeoJSON_Position_Equals_1">Equals(Object)</a></td><td>
Determines whether the specified <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a> is equal to the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Object.Equals(Object)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_GeoJSON_Position_Equals">Equals(Position)</a></td><td>
Indicates whether the current object is equal to another object of the same type.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_GeoJSON_Position_GetHashCode">GetHashCode</a></td><td>
Serves as a hash function for a particular type.
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">Object.GetHashCode()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#position-class">Back to Top</a>

## Operators
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_AirMapDotNet_Entities_GeoJSON_Position_op_Equality">Equality</a></td><td>
Determines whether *left* is equal to *right*.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_AirMapDotNet_Entities_GeoJSON_Position_op_Inequality">Inequality</a></td><td>
Determines whether *left* is not equal to *right*.</td></tr></table>&nbsp;
<a href="#position-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_AirMapDotNet_Entities_GeoJSON_Position_Epsilon">Epsilon</a></td><td>
The absolute tolerance before an elevation may be considered zero. In this case, 1mm.</td></tr></table>&nbsp;
<a href="#position-class">Back to Top</a>

## See Also


#### Reference
<a href="N_AirMapDotNet_Entities_GeoJSON">AirMapDotNet.Entities.GeoJSON Namespace</a><br />