![](media/airmapdotnet_banner.png)

![Version 1.0.1](https://img.shields.io/badge/version-1.0.1-blue.svg) [![Docs: Latest](https://img.shields.io/badge/docs-latest-brightgreen.svg?style=flat)](http://airmapdotnet.readthedocs.io/en/latest/Getting%20Started/)

AirMapDotNet is an open source library for accessing and manipulating the AirMap API.


## Before you Start

### AirMap Developer Account

Before you begin, you will need to sign up for a developer account to create an API key so you can begin to make API calls.  Here are the steps to getting an account:

1. Sign up for a free AirMap account on the [Developer Portal](https://dashboard.airmap.io/developer/).
2. Apply to become a developer.  This may take several days.
3. Create a new application.
4. Generate an API key.

### Install AirMapDotNet

To install AirMapDotNet, simply run the following command in the Package Manager Console:

```
Install-Package AirMapDotNet
```

Or install the library from NuGet using the following command:

```
nuget install AirMapDotNet
```

### Test the SDK

First, download the `airmap.config.json` file from your dashboard and place it in the project's working directory.

Then, load the file using `APIConfiguration.LoadFromFileAsync`.

Finally, create a new `AirMap` instance with the configuration and explore to your heart's content!

```CSharp
APIConfiguration config = await APIConfiguration.LoadFromFileAsync("airmap.config.json");
AirMap am = new AirMap(config);

Manufacturers[] manus = await am.GetManufacturers();
```

If the code above does not produce an `AirMapException`, you're good to go!

### Authentication

To use some features of the AirMap API, you must authenticate the user.  To do this, simply use `AuthenticationService.LoginAsync`:

```CSharp
APIConfiguration config = await APIConfiguration.LoadFromFileAsync("airmap.config.json");
AirMap am = new AirMap(config);

am.AuthenticationToken = await AuthenticationService.LoginAsync(am, username, password);

PilotProfile profile = await am.GetProfile();
```

## Documentation

Documentation is hosted on ReadTheDocs [here](http://airmapdotnet.rtfd.io/).


<sub><sub>Disclaimer:  AirMapDotNet is not, and does not claim to be affiliated with AirMap or any of its products or employees.  This is an open source project available to the public under the GNU Public License.  Trademarks referenced, including AIRMAP, NOFLYZONE, and DRONEZONING and any associated logos are owned exclusively by AirMap, Inc.<sub><sub>
