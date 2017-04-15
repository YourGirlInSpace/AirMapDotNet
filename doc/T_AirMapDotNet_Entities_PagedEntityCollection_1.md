# PagedEntityCollection(*T*) Class
 

Represents a paged collection of *T*.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_AirMapDotNet_Entities_AirMapEntity">AirMapDotNet.Entities.AirMapEntity</a><br />&nbsp;&nbsp;&nbsp;&nbsp;AirMapDotNet.Entities.PagedEntityCollection(T)<br />
**Namespace:**&nbsp;<a href="N_AirMapDotNet_Entities">AirMapDotNet.Entities</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
public class PagedEntityCollection<T> : AirMapEntity, 
	IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
where T : class, IAirMapEntity

```

**VB**<br />
``` VB
Public Class PagedEntityCollection(Of T As {Class, IAirMapEntity})
	Inherits AirMapEntity
	Implements IList(Of T), ICollection(Of T), 
	IEnumerable(Of T), IEnumerable
```

**C++**<br />
``` C++
generic<typename T>
where T : ref class, IAirMapEntity
public ref class PagedEntityCollection : public AirMapEntity, 
	IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
```

**F#**<br />
``` F#
type PagedEntityCollection<'T when 'T : not struct and IAirMapEntity> =  
    class
        inherit AirMapEntity
        interface IList<'T>
        interface ICollection<'T>
        interface IEnumerable<'T>
        interface IEnumerable
    end
```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The type represented in this collection.</dd></dl>&nbsp;
The PagedEntityCollection(T) type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_PagedEntityCollection_1__ctor">PagedEntityCollection(T)</a></td><td>
Initializes a new instance of the PagedEntityCollection(T) class</td></tr></table>&nbsp;
<a href="#pagedentitycollection(*t*)-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_PagedEntityCollection_1_AirMap">AirMap</a></td><td>
The <a href="P_AirMapDotNet_Entities_IAirMapEntity_AirMap">AirMap</a> instance used to request the entity.
 (Overrides <a href="P_AirMapDotNet_Entities_AirMapEntity_AirMap">AirMapEntity.AirMap</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_PagedEntityCollection_1_Count">Count</a></td><td>
Gets the number of elements contained in the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a>.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_PagedEntityCollection_1_IsReadOnly">IsReadOnly</a></td><td>
Gets a value indicating whether the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a> is read-only.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_PagedEntityCollection_1_Item">Item</a></td><td>
Gets or sets the element at the specified index.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_AirMapDotNet_Entities_PagedEntityCollection_1_RequestTime">RequestTime</a></td><td>
The time the request was completed.
 (Overrides <a href="P_AirMapDotNet_Entities_AirMapEntity_RequestTime">AirMapEntity.RequestTime</a>.)</td></tr></table>&nbsp;
<a href="#pagedentitycollection(*t*)-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_PagedEntityCollection_1_Add">Add</a></td><td>
Adds an item to the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_PagedEntityCollection_1_Clear">Clear</a></td><td>
Removes all items from the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_PagedEntityCollection_1_Contains">Contains</a></td><td>
Determines whether the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a> contains a specific value.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_PagedEntityCollection_1_CopyTo">CopyTo</a></td><td>
Copies the elements of the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a> to an <a href="http://msdn2.microsoft.com/en-us/library/czz5hkty" target="_blank">Array</a>, starting at a particular <a href="http://msdn2.microsoft.com/en-us/library/czz5hkty" target="_blank">Array</a> index.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a> is equal to the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_PagedEntityCollection_1_GetEnumerator">GetEnumerator</a></td><td>
Returns an enumerator that iterates through the collection.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as a hash function for a particular type.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_PagedEntityCollection_1_IndexOf">IndexOf</a></td><td>
Determines the index of a specific item in the <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">IList(T)</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_PagedEntityCollection_1_Insert">Insert</a></td><td>
Inserts an item to the <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">IList(T)</a> at the specified index.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_PagedEntityCollection_1_Remove">Remove</a></td><td>
Removes the first occurrence of a specific object from the <a href="http://msdn2.microsoft.com/en-us/library/92t2ye13" target="_blank">ICollection(T)</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_AirMapDotNet_Entities_PagedEntityCollection_1_RemoveAt">RemoveAt</a></td><td>
Removes the <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">IList(T)</a> item at the specified index.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#pagedentitycollection(*t*)-class">Back to Top</a>

## See Also


#### Reference
<a href="N_AirMapDotNet_Entities">AirMapDotNet.Entities Namespace</a><br />