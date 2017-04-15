# FlightCreationParameters Class
 

Provides flight creation parameters to the AirMap API.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;AirMapDotNet.Entities.FlightAPI.FlightCreationParameters<br />
**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities_FlightAPI">AirMapDotNet.Entities.FlightAPI</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public class FlightCreationParameters
```

**VB**<br />
``` VB
Public Class FlightCreationParameters
```

**C++**<br />
``` C++
public ref class FlightCreationParameters
```

**F#**<br />
``` F#
type FlightCreationParameters =  class end
```

The FlightCreationParameters type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters__ctor">FlightCreationParameters</a></td><td>
Initializes a new instance of the FlightCreationParameters class</td></tr></table>&nbsp;
<a href="#flightcreationparameters-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters_AircraftID">AircraftID</a></td><td>
The aircraft associated with the flight.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters_Buffer">Buffer</a></td><td>
The buffer size around the takeoff point or a <a href="T_AirMapDotNet_Entities_GeoJSON_GeoObjects_LineString">LineString</a> in meters.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters_EndTime">EndTime</a></td><td>
Landing time.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters_Geometry">Geometry</a></td><td>
Optional geometry attribute. Leave null to make this flight point-radius.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters_IsPublic">IsPublic</a></td><td>
Make the flight publically visible.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters_Latitude">Latitude</a></td><td>
The latitude of the takeoff point in degrees.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters_Longitude">Longitude</a></td><td>
The longitude of the takeoff point in degrees.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters_MaxAltitude">MaxAltitude</a></td><td>
The maximum altitude above the ground in meters.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters_Notify">Notify</a></td><td>
Give digital notice to the relevant authorities.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters_StartTime">StartTime</a></td><td>
Takeoff time.</td></tr></table>&nbsp;
<a href="#flightcreationparameters-class">Back to Top</a>

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
<a href="#flightcreationparameters-class">Back to Top</a>

## See Also


#### Reference
<a href="N_AirMapDotNet_Entities_FlightAPI">AirMapDotNet.Entities.FlightAPI Namespace</a><br />