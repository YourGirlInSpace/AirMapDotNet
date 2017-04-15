# AirMapException.GetObjectData Method 
 

Sets the <a href="http://msdn2.microsoft.com/en-us/library/a9b6042e" target="_blank">SerializationInfo</a> with information about the <a href="T_AirMapDotNet_AirMapException">AirMapException</a>.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public override void GetObjectData(
	SerializationInfo info,
	StreamingContext context
)
```

**VB**<br />
``` VB
Public Overrides Sub GetObjectData ( 
	info As SerializationInfo,
	context As StreamingContext
)
```

**C++**<br />
``` C++
public:
virtual void GetObjectData(
	SerializationInfo^ info, 
	StreamingContext context
) override
```

**F#**<br />
``` F#
abstract GetObjectData : 
        info : SerializationInfo * 
        context : StreamingContext -> unit 
override GetObjectData : 
        info : SerializationInfo * 
        context : StreamingContext -> unit 
```


#### Parameters
&nbsp;<dl><dt>info</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/a9b6042e" target="_blank">System.Runtime.Serialization.SerializationInfo</a><br />The <a href="http://msdn2.microsoft.com/en-us/library/a9b6042e" target="_blank">SerializationInfo</a> that holds the serialized object data about the exception being thrown.</dd><dt>context</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/t16abws5" target="_blank">System.Runtime.Serialization.StreamingContext</a><br />The <a href="http://msdn2.microsoft.com/en-us/library/t16abws5" target="_blank">StreamingContext</a> that contains contextual information about the source or destination.</dd></dl>

#### Implements
<a href="http://msdn2.microsoft.com/en-us/library/27cxsdk6" target="_blank">ISerializable.GetObjectData(SerializationInfo, StreamingContext)</a><br /><a href="http://msdn2.microsoft.com/en-us/library/854b9522" target="_blank">_Exception.GetObjectData(SerializationInfo, StreamingContext)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>The *info* parameter is a null reference.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_AirMapException">AirMapException Class</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />