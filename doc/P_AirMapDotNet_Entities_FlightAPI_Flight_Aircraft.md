# Flight.Aircraft Property 
 

The aircraft being flown.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities_FlightAPI">AirMapDotNet.Entities.FlightAPI</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public virtual Aircraft Aircraft { get; set; }
```

**VB**<br />
``` VB
Public Overridable Property Aircraft As Aircraft
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property Aircraft^ Aircraft {
	Aircraft^ get ();
	void set (Aircraft^ value);
}
```

**F#**<br />
``` F#
abstract Aircraft : Aircraft with get, set
override Aircraft : Aircraft with get, set
```


#### Property Value
Type: <a href="T_AirMapDotNet_Entities_AircraftAPI_Aircraft">Aircraft</a>

## Remarks
Can be replaced with <a href="P_AirMapDotNet_Entities_FlightAPI_Flight_AircraftID">AircraftID</a> if the `enhance` query is set to <i>false</i>.

## See Also


#### Reference
<a href="T_AirMapDotNet_Entities_FlightAPI_Flight">Flight Class</a><br /><a href="N_AirMapDotNet_Entities_FlightAPI">AirMapDotNet.Entities.FlightAPI Namespace</a><br />