# AirMapException Class
 

The exception that is thrown when an error occurs during an interaction with the AirMap API.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">System.Exception</a><br />&nbsp;&nbsp;&nbsp;&nbsp;AirMapDotNet.AirMapException<br />
**Namespace:**&nbsp;<a href="b5783ccd-d544-c2c9-c0be-1f622d02460a">AirMapDotNet</a><br />**Assembly:**&nbsp;AirMapDotNet (in AirMapDotNet.dll) Version: 1.0.6313.34627 (1.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class AirMapException : Exception
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class AirMapException
	Inherits Exception
```

**C++**<br />
``` C++
[SerializableAttribute]
public ref class AirMapException : public Exception
```

**F#**<br />
``` F#
[<SerializableAttribute>]
type AirMapException =  
    class
        inherit Exception
    end
```

The AirMapException type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="bf614228-448c-2ef6-74e5-ab1b7efee196">AirMapException()</a></td><td>
Initializes a new instance of the AirMapException class.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="71c2d5fd-566f-8eba-383c-b4ce41ccebda">AirMapException(String)</a></td><td>
Initializes a new instance of the Exception class with a specified error message.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="8193199e-6812-9a4a-cb8b-baf5a5341c58">AirMapException(AirMapErrorData)</a></td><td>
Initializes a new instance of the AirMapException class.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="e5c4056c-562f-bd5c-3250-471b90a58224">AirMapException(JSendStatus)</a></td><td>
Initializes a new instance of the AirMapException class with a status code..</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="1753f882-8953-0ea5-51d4-5ea36c58080a">AirMapException(SerializationInfo, StreamingContext)</a></td><td>
Initializes a new instance of the AirMapException class with serialized data.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="dc750fd5-c315-4f39-0d02-31284530e132">AirMapException(String, AirMapErrorData)</a></td><td>
Initializes a new instance of the Exception class with a specified error message.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="c36cc704-90d6-a6cb-5aba-28b301b64f69">AirMapException(String, JSendStatus)</a></td><td>
Initializes a new instance of the Exception class with a specified error message and a status code..</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="7c504ae3-515b-024f-7f29-58555dd419ac">AirMapException(String, Exception)</a></td><td>
Initializes a new instance of the AirMapException class with a specified error message and a reference to the inner exception that is the cause of this exception.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="a5706db4-95a0-47cd-3167-e26f9032461a">AirMapException(JSendStatus, AirMapErrorData)</a></td><td>
Initializes a new instance of the AirMapException class with a status code..</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="134fdc0a-b0a5-90b7-bb00-9d38d18ac445">AirMapException(String, AirMapErrorData, Exception)</a></td><td>
Initializes a new instance of the AirMapException class with a specified error message and a reference to the inner exception that is the cause of this exception.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="6118a836-2338-7fd0-638e-9d84c04f3a05">AirMapException(String, JSendStatus, AirMapErrorData)</a></td><td>
Initializes a new instance of the Exception class with a specified error message and a status code..</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="6dfad453-c7ff-ed5b-feb8-1426876b9e63">AirMapException(String, JSendStatus, Exception)</a></td><td>
Initializes a new instance of the AirMapException class with a specified error message, a status code and a reference to the inner exception that is the cause of this exception.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="75b49cf0-d0b0-fc21-0485-dbc7f0282c58">AirMapException(String, JSendStatus, AirMapErrorData, Exception)</a></td><td>
Initializes a new instance of the AirMapException class with a specified error message, a status code and a reference to the inner exception that is the cause of this exception.</td></tr></table>&nbsp;
<a href="#airmapexception-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="http://msdn2.microsoft.com/en-us/library/2wyfbc48" target="_blank">Data</a></td><td>
Gets a collection of key/value pairs that provide additional user-defined information about the exception.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="28e27c08-6f6d-b369-a104-2ac4f0b274c6">Errors</a></td><td>
A list of the fields which caused the exception.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="http://msdn2.microsoft.com/en-us/library/71tawy4s" target="_blank">HelpLink</a></td><td>
Gets or sets a link to the help file associated with this exception.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="http://msdn2.microsoft.com/en-us/library/sh5cw61c" target="_blank">HResult</a></td><td>
Gets or sets HRESULT, a coded numerical value that is assigned to a specific exception.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="http://msdn2.microsoft.com/en-us/library/902sca80" target="_blank">InnerException</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a> instance that caused the current exception.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="http://msdn2.microsoft.com/en-us/library/9btwf6wk" target="_blank">Message</a></td><td>
Gets a message that describes the current exception.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="http://msdn2.microsoft.com/en-us/library/85weac5w" target="_blank">Source</a></td><td>
Gets or sets the name of the application or the object that causes the error.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dxzhy005" target="_blank">StackTrace</a></td><td>
Gets a string representation of the immediate frames on the call stack.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="ca0fd26c-75ad-a1f7-d947-6f7ed8095382">Status</a></td><td>
The status code sent from the AirMap API.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="http://msdn2.microsoft.com/en-us/library/2wchw354" target="_blank">TargetSite</a></td><td>
Gets the method that throws the current exception.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a>.)</td></tr></table>&nbsp;
<a href="#airmapexception-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a> is equal to the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/49kcee3b" target="_blank">GetBaseException</a></td><td>
When overridden in a derived class, returns the <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a> that is the root cause of one or more subsequent exceptions.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as a hash function for a particular type.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="18c719f1-f30e-e4fc-c801-507d18329678">GetObjectData</a></td><td>
Sets the <a href="http://msdn2.microsoft.com/en-us/library/a9b6042e" target="_blank">SerializationInfo</a> with information about the AirMapException.
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/fwb1489e" target="_blank">Exception.GetObjectData(SerializationInfo, StreamingContext)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/44zb316t" target="_blank">GetType</a></td><td>
Gets the runtime type of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/es4y6f7e" target="_blank">ToString</a></td><td>
Creates and returns a string representation of the current exception.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a>.)</td></tr></table>&nbsp;
<a href="#airmapexception-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected event](media/protevent.gif "Protected event")</td><td><a href="http://msdn2.microsoft.com/en-us/library/ee332915" target="_blank">SerializeObjectState</a></td><td>
Occurs when an exception is serialized to create an exception state object that contains serialized data about the exception.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">Exception</a>.)</td></tr></table>&nbsp;
<a href="#airmapexception-class">Back to Top</a>

## See Also


#### Reference
<a href="b5783ccd-d544-c2c9-c0be-1f622d02460a">AirMapDotNet Namespace</a><br />