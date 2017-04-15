# FlightCreationParameters.EndTime Property 
 

Landing time.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities_FlightAPI">AirMapDotNet.Entities.FlightAPI</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public DateTime EndTime { get; set; }
```

**VB**<br />
``` VB
Public Property EndTime As DateTime
	Get
	Set
```

**C++**<br />
``` C++
public:
property DateTime EndTime {
	DateTime get ();
	void set (DateTime value);
}
```

**F#**<br />
``` F#
member EndTime : DateTime with get, set

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/03ybds8y" target="_blank">DateTime</a><br />Must be less than four hours from <a href="P_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters_StartTime">StartTime</a>.

## See Also


#### Reference
<a href="T_AirMapDotNet_Entities_FlightAPI_FlightCreationParameters">FlightCreationParameters Class</a><br /><a href="N_AirMapDotNet_Entities_FlightAPI">AirMapDotNet.Entities.FlightAPI Namespace</a><br />