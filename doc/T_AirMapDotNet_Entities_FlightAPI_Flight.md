# Flight Class
 

Represents a flight event.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_AirMapDotNet_Entities_AirMapEntity">AirMapDotNet.Entities.AirMapEntity</a><br />&nbsp;&nbsp;&nbsp;&nbsp;AirMapDotNet.Entities.FlightAPI.Flight<br />
**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities_FlightAPI">AirMapDotNet.Entities.FlightAPI</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public class Flight : AirMapEntity
```

**VB**<br />
``` VB
Public Class Flight
	Inherits AirMapEntity
```

**C++**<br />
``` C++
public ref class Flight : public AirMapEntity
```

**F#**<br />
``` F#
type Flight =  
    class
        inherit AirMapEntity
    end
```

The Flight type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_FlightAPI_Flight__ctor">Flight</a></td><td>
Initializes a new instance of the Flight class</td></tr></table>&nbsp;
<a href="#flight-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_Aircraft">Aircraft</a></td><td>
The aircraft being flown.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_AircraftID">AircraftID</a></td><td>
The aircraft being flown.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirMapEntity_AirMap">AirMap</a></td><td>
The <a href="P_AirMapDotNet_Entities_IAirMapEntity_AirMap">AirMap</a> instance used to request the entity.
 (Inherited from <a href="T_AirMapDotNet_Entities_AirMapEntity">AirMapEntity</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_Buffer">Buffer</a></td><td>
The buffer radius around the <a href="P_AirMapDotNet_Entities_FlightAPI_Flight_Geometry">Geometry</a> in meters.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_City">City</a></td><td>
The city where the flight is being conducted.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_Country">Country</a></td><td>
The country where the flight is being conducted.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_CreatedAt">CreatedAt</a></td><td>
The time when this flight was created.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_EndTime">EndTime</a></td><td>
The time when the flight ends.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_Geometry">Geometry</a></td><td>
A description of the flight area.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_ID">ID</a></td><td>
The flight's unique ID.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_IsPublic">IsPublic</a></td><td>
If <i>true</i>, the flight is publically visible.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_Latitude">Latitude</a></td><td>
The central latitude of the flight.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_Longitude">Longitude</a></td><td>
The central longitude of the flight.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_MaxAltitude">MaxAltitude</a></td><td>
The maximum flight altitude in meters.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_Permits">Permits</a></td><td>
NFC</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_Pilot">Pilot</a></td><td>
The pilot conducting this flight.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_PilotID">PilotID</a></td><td>
The ID of the pilot who created the flight.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_AirMapEntity_RequestTime">RequestTime</a></td><td>
The time the request was completed.
 (Inherited from <a href="T_AirMapDotNet_Entities_AirMapEntity">AirMapEntity</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_StartTime">StartTime</a></td><td>
The time when the flight starts.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_Flight_State">State</a></td><td>
The state where the flight is being conducted.</td></tr></table>&nbsp;
<a href="#flight-class">Back to Top</a>

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
<a href="#flight-class">Back to Top</a>

## See Also


#### Reference
<a href="N_AirMapDotNet_Entities_FlightAPI">AirMapDotNet.Entities.FlightAPI Namespace</a><br />