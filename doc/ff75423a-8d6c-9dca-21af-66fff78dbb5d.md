# Status Class
 

Provides the current status of a proposed flight area.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="498915d0-8dc8-c249-1048-8f0ca5925baa">AirMapDotNet.Entities.AirMapEntity</a><br />&nbsp;&nbsp;&nbsp;&nbsp;AirMapDotNet.Entities.StatusAPI.Status<br />
**Namespace:**&nbsp;<a href="12320c3a-5c84-cb32-046c-dfe03d44c547">AirMapDotNet.Entities.StatusAPI</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public class Status : AirMapEntity
```

**VB**<br />
``` VB
Public Class Status
	Inherits AirMapEntity
```

**C++**<br />
``` C++
public ref class Status : public AirMapEntity
```

**F#**<br />
``` F#
type Status =  
    class
        inherit AirMapEntity
    end
```

The Status type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="cb857ada-456c-45be-052c-ba44a893b695">Status</a></td><td>
Initializes a new instance of the Status class</td></tr></table>&nbsp;
<a href="#status-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="2821abd4-e2db-90b7-af10-4ef8ac4ac87c">Advisories</a></td><td>
A list of all <a href="c77ac3b7-2e5f-3676-6d4b-4fb2c4bc07ce">AirspaceObject</a>s intersecting the proposed flight.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="02ac9461-4078-409f-2173-741b951e3f20">AdvisoryColor</a></td><td>
The advisory color.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="032dccf1-d5fa-b40a-8ad6-b150b5708395">AirMap</a></td><td>
The <a href="be228503-8740-bc61-66cf-e4c36ebd34e2">AirMap</a> instance used to request the entity.
 (Inherited from <a href="498915d0-8dc8-c249-1048-8f0ca5925baa">AirMapEntity</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="f33ba3a5-60a0-c3e1-12eb-5ca723b5da5f">MaxSafeDistance</a></td><td>
The distance between a flight's takeoff point and the nearest yellow or red zone in meters.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="f55e2217-2d86-8a3f-3a3e-f3338517d712">RequestTime</a></td><td>
The time the request was completed.
 (Inherited from <a href="498915d0-8dc8-c249-1048-8f0ca5925baa">AirMapEntity</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="d8a8a239-a6d3-5af5-8e4d-aa7b26e963c6">Weather</a></td><td>
A <a href="d8a8a239-a6d3-5af5-8e4d-aa7b26e963c6">Weather</a> object containing current weather conditions.</td></tr></table>&nbsp;
<a href="#status-class">Back to Top</a>

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
<a href="#status-class">Back to Top</a>

## See Also


#### Reference
<a href="12320c3a-5c84-cb32-046c-dfe03d44c547">AirMapDotNet.Entities.StatusAPI Namespace</a><br />