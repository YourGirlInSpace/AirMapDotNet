# LatLon.Epsilon Field
 

The absolute tolerance before the difference between latitudes or longitudes may be considered zero. In this case, roughly half an inch.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public const double Epsilon = 1E-07
```

**VB**<br />
``` VB
Public Const Epsilon As Double = 1E-07
```

**C++**<br />
``` C++
public:
literal double Epsilon = 1E-07
```

**F#**<br />
``` F#
static val mutable Epsilon: float
```


#### Field Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">Double</a>

## Remarks

The Epsilon constant is used in equality methods to determine whether a latitude or longitude equals another latitude or longitude. Due to floating point errors, it is conceivable that two otherwise equal-appearing numbers may differ by a minute amount.

To combat this, an Epsilon is defined describing the minimum useful granularity before the absolute difference between the two numbers may be considered zero.

For example, 
```
// The expected value
double lat1 = 26;

// This may happen due to floating point errors.
// Normally, the effect is much smaller than this, down to 1e-37.
double lat2 = 26.00000000000000001;

// This will resolve to false because the two values have a
// very slightly different value.
double equal1 = lat1 == lat2;

// This will resolve to true, because the absolute difference
// between the two values is 1e-17 -- less than the Epsilon's
// value of 1e-7.
double equal2 = Math.Abs(lat1 - lat2) < Epsilon;
```



## See Also


#### Reference
<a href="T_AirMapDotNet_LatLon">LatLon Class</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />