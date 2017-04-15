# Airport Class
 

Represents an airport.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject">AirMapDotNet.Entities.AirspaceObjects.AirspaceObject</a><br />&nbsp;&nbsp;&nbsp;&nbsp;AirMapDotNet.Entities.AirspaceObjects.Airport<br />
**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities_AirspaceObjects">AirMapDotNet.Entities.AirspaceObjects</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public class Airport : AirspaceObject
```

**VB**<br />
``` VB
Public Class Airport
	Inherits AirspaceObject
```

**C++**<br />
``` C++
public ref class Airport : public AirspaceObject
```

**F#**<br />
``` F#
type Airport =  
    class
        inherit AirspaceObject
    end
```

The Airport type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_AirspaceObjects_Airport__ctor">Airport</a></td><td>
Initializes a new instance of the Airport class</td></tr></table>&nbsp;
<a href="#airport-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject_City">City</a></td><td>
The city where this object exists.
 (Inherited from <a href="T_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject">AirspaceObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject_Country">Country</a></td><td>
The country where this object exists.
 (Inherited from <a href="T_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject">AirspaceObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_Airport_Elevation">Elevation</a></td><td>
The elevation of the airport in feet.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject_Geometry">Geometry</a></td><td>
The geometry of the object.
 (Inherited from <a href="T_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject">AirspaceObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_Airport_IATA">IATA</a></td><td>
The airport's IATA code.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_Airport_ICAO">ICAO</a></td><td>
The airport's ICAO code.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject_ID">ID</a></td><td>
The unique ID of this object.
 (Inherited from <a href="T_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject">AirspaceObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_Airport_InstrumentApproach">InstrumentApproach</a></td><td><b>True</b> if the airport has an instrument approach procedure.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject_LastUpdated">LastUpdated</a></td><td>
The time when this object was last updated.
 (Inherited from <a href="T_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject">AirspaceObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_Airport_LongestRunway">LongestRunway</a></td><td>
The longest runway at this airport in feet.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject_Name">Name</a></td><td>
The name of this object.
 (Inherited from <a href="T_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject">AirspaceObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject_ObjectType">ObjectType</a></td><td>
The type of this object.
 (Inherited from <a href="T_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject">AirspaceObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_Airport_Paved">Paved</a></td><td><b>True</b> if the airport has a paved runway.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_Airport_Phone">Phone</a></td><td>
The phone number of the airport manager or person of authority.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject_Properties">Properties</a></td><td>
Unique properties of the object.
 (Inherited from <a href="T_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject">AirspaceObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_Airport_Rules">Rules</a></td><td>
The flight rules associated with this airport.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_Airport_Runways">Runways</a></td><td>
The runways at this airport.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject_State">State</a></td><td>
The state where this object exists.
 (Inherited from <a href="T_AirMapDotNet_Entities_AirspaceObjects_AirspaceObject">AirspaceObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_Airport_Tower">Tower</a></td><td><b>True</b> if the airport has a staffed air traffic control tower.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirspaceObjects_Airport_Use">Use</a></td><td>
The usage of the airport.</td></tr></table>&nbsp;
<a href="#airport-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a> is equal to the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as a hash function for a particular type.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#airport-class">Back to Top</a>

## See Also


#### Reference
<a href="N_AirMapDotNet_Entities_AirspaceObjects">AirMapDotNet.Entities.AirspaceObjects Namespace</a><br />