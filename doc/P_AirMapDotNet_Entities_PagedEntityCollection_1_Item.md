# PagedEntityCollection(*T*).Item Property 
 

Gets or sets the element at the specified index.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities">AirMapDotNet.Entities</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public T this[
	int index
] { get; set; }
```

**VB**<br />
``` VB
Public Default Property Item ( 
	index As Integer
) As T
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property T default[int index] {
	T get (int index) sealed;
	void set (int index, T value) sealed;
}
```

**F#**<br />
``` F#
abstract Item : 'T with get, set
override Item : 'T with get, set
```


#### Parameters
&nbsp;<dl><dt>index</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />The zero-based index of the element to get or set.</dd></dl>

#### Return Value
Type: <a href="T_AirMapDotNet_Entities_PagedEntityCollection_1">*T*</a><br />The element at the specified index.

#### Implements
<a href="http://msdn2.microsoft.com/en-us/library/ewthkb10" target="_blank">IList(T).Item(Int32)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/8xt94y6e" target="_blank">ArgumentOutOfRangeException</a></td><td>*index* is not a valid index in the <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">IList(T)</a>.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/8a7a4e64" target="_blank">NotSupportedException</a></td><td>The property is set and the <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">IList(T)</a> is read-only.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_Entities_PagedEntityCollection_1">PagedEntityCollection(T) Class</a><br /><a href="N_AirMapDotNet_Entities">AirMapDotNet.Entities Namespace</a><br />