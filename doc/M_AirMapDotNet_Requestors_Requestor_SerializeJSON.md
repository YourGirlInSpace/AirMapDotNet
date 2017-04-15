# Requestor.SerializeJSON Method 
 

Serializes an object to a JSON string.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Requestors">AirMapDotNet.Requestors</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public virtual string SerializeJSON(
	Object data
)
```

**VB**<br />
``` VB
Public Overridable Function SerializeJSON ( 
	data As Object
) As String
```

**C++**<br />
``` C++
public:
virtual String^ SerializeJSON(
	Object^ data
)
```

**F#**<br />
``` F#
abstract SerializeJSON : 
        data : Object -> string 
override SerializeJSON : 
        data : Object -> string 
```


#### Parameters
&nbsp;<dl><dt>data</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />The object to serialize.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a><br />The serialized JSON string.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the serialization fails.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *data* is null.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_Requestors_Requestor">Requestor Class</a><br /><a href="N_AirMapDotNet_Requestors">AirMapDotNet.Requestors Namespace</a><br />