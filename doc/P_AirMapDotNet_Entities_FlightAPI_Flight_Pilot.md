# Flight.Pilot Property 
 

The pilot conducting this flight.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities_FlightAPI">AirMapDotNet.Entities.FlightAPI</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public virtual PilotProfile Pilot { get; set; }
```

**VB**<br />
``` VB
Public Overridable Property Pilot As PilotProfile
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property PilotProfile^ Pilot {
	PilotProfile^ get ();
	void set (PilotProfile^ value);
}
```

**F#**<br />
``` F#
abstract Pilot : PilotProfile with get, set
override Pilot : PilotProfile with get, set
```


#### Property Value
Type: <a href="T_AirMapDotNet_Entities_PilotAPI_PilotProfile">PilotProfile</a>

## Remarks
Can be replaced with <a href="P_AirMapDotNet_Entities_FlightAPI_Flight_PilotID">PilotID</a> if the `enhance` query is set to <i>false</i>.

## See Also


#### Reference
<a href="T_AirMapDotNet_Entities_FlightAPI_Flight">Flight Class</a><br /><a href="N_AirMapDotNet_Entities_FlightAPI">AirMapDotNet.Entities.FlightAPI Namespace</a><br />