# PagedEntityCollection(*T*).Contains Method 
 

Determines whether the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a> contains a specific value.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities">AirMapDotNet.Entities</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public bool Contains(
	T item
)
```

**VB**<br />
``` VB
Public Function Contains ( 
	item As T
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool Contains(
	T item
) sealed
```

**F#**<br />
``` F#
abstract Contains : 
        item : 'T -> bool 
override Contains : 
        item : 'T -> bool 
```


#### Parameters
&nbsp;<dl><dt>item</dt><dd>Type: <a href="T_AirMapDotNet_Entities_PagedEntityCollection_1">*T*</a><br />The object to locate in the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a>.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />true if *item* is found in the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a>; otherwise, false.

#### Implements
<a href="http://msdn2.microsoft.com/en-us/library/k5cf1d56" target="_blank">ICollection(T).Contains(T)</a><br />

## See Also


#### Reference
<a href="T_AirMapDotNet_Entities_PagedEntityCollection_1">PagedEntityCollection(T) Class</a><br /><a href="N_AirMapDotNet_Entities">AirMapDotNet.Entities Namespace</a><br />