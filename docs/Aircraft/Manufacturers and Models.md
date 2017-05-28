Manufacturers and Models
=========

To obtain a list of manufacturers, use the following code:

```CSharp
AirMap am = new AirMap(...);

var manus = await am.GetManufacturers();
```

This code will produce a list of `Manufacturer` objects that contains each individual manufacturer ID and the name.  To obtain the list of drone models a particular manufacturer manufactures, such as DJI, use:

```CSharp
AirMap am = new AirMap(...);

var manus = await am.GetManufacturers();
var dji = manus.FirstOrDefault(x => x.Name == "DJI");

var models = await dji.GetModels();
```

You may also utilize the `GetModels` method on your `AirMap` instance to search manually:

```CSharp
AirMap am = new AirMap(...);

// Get a list of ALL models from DJI
var models = await am.GetModels("DJI", null);

// Get a list of all models from DJI that start with "Phantom"
models = await am.GetModels("DJI", "Phantom");
```