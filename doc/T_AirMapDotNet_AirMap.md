# AirMap Class
 

The representation of a session on the AirMap API.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;AirMapDotNet.AirMap<br />
**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public class AirMap
```

**VB**<br />
``` VB
Public Class AirMap
```

**C++**<br />
``` C++
public ref class AirMap
```

**F#**<br />
``` F#
type AirMap =  class end
```

The AirMap type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap__ctor">AirMap</a></td><td>
Creates a new AirMap API session using the provided *apiKey*.</td></tr></table>&nbsp;
<a href="#airmap-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_AirMap_AuthenticationToken">AuthenticationToken</a></td><td>
The authentication token used by this session.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_AirMap_Requestor">Requestor</a></td><td>
The <a href="P_AirMapDotNet_AirMap_Requestor">Requestor</a> used to interact with the AirMap API.</td></tr></table>&nbsp;
<a href="#airmap-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_CreateFlight">CreateFlight</a></td><td>
Creates a new flight using the parameters in <a href="T_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters">FlightCreationParameters</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_DeleteFlight_1">DeleteFlight(String)</a></td><td>
Deletes a flight by its unique ID.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_DeleteFlight">DeleteFlight(Flight)</a></td><td>
Deletes a flight.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_EndFlight_1">EndFlight(String)</a></td><td>
Ends a flight by its unique ID.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_EndFlight">EndFlight(Flight)</a></td><td>
Ends a flight.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a> is equal to the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetCurrentFlights">GetCurrentFlights(Geometry)</a></td><td>
Retrieves a list of all currently active flights within a geographic area.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetCurrentFlights_1">GetCurrentFlights(Geometry, Boolean)</a></td><td>
Retrieves a list of all currently active flights within a geographic area.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetCurrentFlights_2">GetCurrentFlights(Geometry, Int32)</a></td><td>
Retrieves a list of all currently active flights within a geographic area.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetCurrentFlights_3">GetCurrentFlights(Geometry, Int32, Boolean)</a></td><td>
Retrieves a list of all currently active flights within a geographic area.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetFlights_1">GetFlights(String)</a></td><td>
Retrieves a list of all flights within a geographic area.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetFlights_2">GetFlights(String, Boolean)</a></td><td>
Retrieves a list of all flights within a geographic area.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetFlights_3">GetFlights(String, Int32)</a></td><td>
Retrieves a list of all flights within a geographic area.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetFlights">GetFlights(Geometry, Int32)</a></td><td>
Retrieves a list of all flights within a geographic area.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetFlights_4">GetFlights(String, Int32, Boolean)</a></td><td>
Retrieves a list of all flights within a geographic area.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as a hash function for a particular type.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetManufacturers">GetManufacturers</a></td><td>
Retrieves the list of recognized manufacturers.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_AirMapDotNet_AirMap_GetModel">GetModel</a></td><td>
Retrieves a drone model using its unique GUID.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_AirMapDotNet_AirMap_GetModels">GetModels</a></td><td>
Retrieves a list of drone models.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetProfile">GetProfile()</a></td><td>
Retrieves the profile for the currently authenticated user.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetProfile_1">GetProfile(String)</a></td><td>
Retrieves the profile of the user with ID *uid*.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetStatus">GetStatus(Geometry)</a></td><td>
Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied geometry.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetStatus_4">GetStatus(LatLon)</a></td><td>
Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied position.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetStatus_8">GetStatus(Double, Double)</a></td><td>
Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied position.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetStatus_1">GetStatus(Geometry, Boolean)</a></td><td>
Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied geometry with optional weather information.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetStatus_2">GetStatus(Geometry, Double)</a></td><td>
Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied geometry and a radius *buffer* around the geometry.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetStatus_5">GetStatus(LatLon, Boolean)</a></td><td>
Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied position with optional weather information.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetStatus_6">GetStatus(LatLon, Double)</a></td><td>
Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied position and a radius *buffer* around the position.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetStatus_9">GetStatus(Double, Double, Boolean)</a></td><td>
Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied position with optional weather information.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetStatus_10">GetStatus(Double, Double, Double)</a></td><td>
Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied position and a radius *buffer* around the position.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetStatus_3">GetStatus(Geometry, Double, Boolean)</a></td><td>
Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied geometry and a radius *buffer* around the geometry, with optional weather information.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetStatus_7">GetStatus(LatLon, Double, Boolean)</a></td><td>
Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied position and a radius *buffer* around the position, with optional weather information.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_AirMap_GetStatus_11">GetStatus(Double, Double, Double, Boolean)</a></td><td>
Retrieves a <a href="T_AirMapDotNet_Entities_StatusAPI_Status">Status</a> object for a supplied position and a radius *buffer* around the position, with optional weather information.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#airmap-class">Back to Top</a>

## See Also


#### Reference
<a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />