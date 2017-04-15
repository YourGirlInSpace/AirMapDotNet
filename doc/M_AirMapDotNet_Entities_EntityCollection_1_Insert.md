# EntityCollection(*T*).Insert Method 
 

Inserts an item to the <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">IList(T)</a> at the specified index.

**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities">AirMapDotNet.Entities</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public void Insert(
	int index,
	T item
)
```

**VB**<br />
``` VB
Public Sub Insert ( 
	index As Integer,
	item As T
)
```

**C++**<br />
``` C++
public:
virtual void Insert(
	int index, 
	T item
) sealed
```

**F#**<br />
``` F#
abstract Insert : 
        index : int * 
        item : 'T -> unit 
override Insert : 
        index : int * 
        item : 'T -> unit 
```


#### Parameters
&nbsp;<dl><dt>index</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />The zero-based index at which *item* should be inserted.</dd><dt>item</dt><dd>Type: <a href="T_AirMapDotNet_Entities_EntityCollection_1">*T*</a><br />The object to insert into the <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">IList(T)</a>.</dd></dl>

#### Implements
<a href="http://msdn2.microsoft.com/en-us/library/8zsfbxz8" target="_blank">IList(T).Insert(Int32, T)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/8xt94y6e" target="_blank">ArgumentOutOfRangeException</a></td><td>*index* is not a valid index in the <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">IList(T)</a>.</td></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/8a7a4e64" target="_blank">NotSupportedException</a></td><td>The <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">IList(T)</a> is read-only.</td></tr></table>

## See Also


#### Reference
<a href="T_AirMapDotNet_Entities_EntityCollection_1">EntityCollection(T) Class</a><br /><a href="N_AirMapDotNet_Entities">AirMapDotNet.Entities Namespace</a><br />