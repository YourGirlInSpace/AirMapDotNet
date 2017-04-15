# PagedEntityCollection(*T*).Add Method 
 

Adds an item to the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a>.

**Namespace:**&nbsp;<a href="98571a09-2783-53ee-6a50-029c1c8ea39b">AirMapDotNet.Entities</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public void Add(
	T item
)
```

**VB**<br />
``` VB
Public Sub Add ( 
	item As T
)
```

**C++**<br />
``` C++
public:
virtual void Add(
	T item
) sealed
```

**F#**<br />
``` F#
abstract Add : 
        item : 'T -> unit 
override Add : 
        item : 'T -> unit 
```


#### Parameters
&nbsp;<dl><dt>item</dt><dd>Type: <a href="99a7744d-c2ac-49e0-1429-c6e44f367023">*T*</a><br />The object to add to the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a>.</dd></dl>

#### Implements
<a href="http://msdn2.microsoft.com/en-us/library/63ywd54z" target="_blank">ICollection(T).Add(T)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/8a7a4e64" target="_blank">NotSupportedException</a></td><td>The <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a> is read-only.</td></tr></table>

## See Also


#### Reference
<a href="99a7744d-c2ac-49e0-1429-c6e44f367023">PagedEntityCollection(T) Class</a><br /><a href="98571a09-2783-53ee-6a50-029c1c8ea39b">AirMapDotNet.Entities Namespace</a><br />