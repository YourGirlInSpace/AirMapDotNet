# Requestor.DeserializeJSON(*T*) Method 
 

Deserializes a JSON string into an object *T*.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Requestors">AirMapDotNet.Requestors</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public virtual T DeserializeJSON<T>(
	string data
)

```

**VB**<br />
``` VB
Public Overridable Function DeserializeJSON(Of T) ( 
	data As String
) As T
```

**C++**<br />
``` C++
public:
generic<typename T>
virtual T DeserializeJSON(
	String^ data
)
```

**F#**<br />
``` F#
abstract DeserializeJSON : 
        data : string -> 'T 
override DeserializeJSON : 
        data : string -> 'T 
```


#### Parameters
&nbsp;<dl><dt>data</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The JSON data to deserialize.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The type to deserialize to.</dd></dl>

#### Return Value
Type: *T*<br />The deserialized data, casted to *T*.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_AirMapDotNet_AirMapException">AirMapException</a></td><td>If the deserialization fails.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *data* is null or equals <a href="http://msdn2.microsoft.com/en-us/library/74wsya52" target="_blank">Empty</a>.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_Requestors_Requestor">Requestor Class</a><br /><a href="N_AirMapDotNet_Requestors">AirMapDotNet.Requestors Namespace</a><br />