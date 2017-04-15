# PagedEntityCollection(*T*).Remove Method 
 

Removes the first occurrence of a specific object from the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a>.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities">AirMapDotNet.Entities</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public bool Remove(
	T item
)
```

**VB**<br />
``` VB
Public Function Remove ( 
	item As T
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool Remove(
	T item
) sealed
```

**F#**<br />
``` F#
abstract Remove : 
        item : 'T -> bool 
override Remove : 
        item : 'T -> bool 
```


#### Parameters
&nbsp;<dl><dt>item</dt><dd>Type: <a href="T_AirMapDotNet_Entities_PagedEntityCollection_1">*T*</a><br />The object to remove from the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a>.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />true if *item* was successfully removed from the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a>; otherwise, false. This method also returns false if *item* is not found in the original <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a>.

#### Implements
<a href="http://msdn2.microsoft.com/en-us/library/bye7h94w" target="_blank">ICollection(T).Remove(T)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/8a7a4e64" target="_blank">NotSupportedException</a></td><td>The <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a> is read-only.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_Entities_PagedEntityCollection_1">PagedEntityCollection(T) Class</a><br /><a href="N_AirMapDotNet_Entities">AirMapDotNet.Entities Namespace</a><br />