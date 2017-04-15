# Href(*T*).Compile Method (NameValueCollection)
 

Compiles the <a href="T_AirMapDotNet_Href_1">Href(T)</a> into a URL with the specified query parameters.

**Namespace:**&nbsp;<a href="N_AirMapDotNet">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public Uri Compile(
	NameValueCollection parameters
)
```

**VB**<br />
``` VB
Public Function Compile ( 
	parameters As NameValueCollection
) As Uri
```

**C++**<br />
``` C++
public:
Uri^ Compile(
	NameValueCollection^ parameters
)
```

**F#**<br />
``` F#
member Compile : 
        parameters : NameValueCollection -> Uri 

```


#### Parameters
&nbsp;<dl><dt>parameters</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/689y5thy" target="_blank">System.Collections.Specialized.NameValueCollection</a><br />The query parameters to append to the <a href="P_AirMapDotNet_Href_1_Uri">Uri</a></dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/txt7706a" target="_blank">Uri</a><br />The compiled URL.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>If *parameters* is null.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_Href_1">Href(T) Class</a><br /><a href="Overload_AirMapDotNet_Href_1_Compile">Compile Overload</a><br /><a href="N_AirMapDotNet">AirMapDotNet Namespace</a><br />