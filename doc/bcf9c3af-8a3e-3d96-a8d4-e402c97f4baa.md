# FlightCreationParameters.EndTime Property 
 

Landing time.

**Namespace:**&nbsp;<a href="a60d18d4-c6d0-7461-9b94-22e39530ec94">AirMapDotNet.Entities.FlightAPI</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

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
Type: <a href="http://msdn2.microsoft.com/en-us/library/03ybds8y" target="_blank">DateTime</a><br />Must be less than four hours from <a href="d7bb579b-4a64-03c0-e602-e869538104ce">StartTime</a>.

## See Also


#### Reference
<a href="549601ba-94fc-cf54-6b64-fed97d1c6032">FlightCreationParameters Class</a><br /><a href="a60d18d4-c6d0-7461-9b94-22e39530ec94">AirMapDotNet.Entities.FlightAPI Namespace</a><br />