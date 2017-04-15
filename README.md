# AirMapDotNet

AirMapDotNet is an open source library for accessing and manipulating the AirMap API.

## Before you Start
### Sign up for an AirMap Developer Account
To access the API, you need to register for an AirMap developer account [here](https://dashboard.airmap.io/developer).

### Read the Documentation
The documentation for this project is located [here](/doc/Home.md)

## Using the SDK

To begin using the SDK, first create an `AirMap` object with an API key:

```CSharp
AirMap am = new AirMap(API_KEY);
```

To use the Authenticated features, create an `AuthenticationToken` and pass it to the `AirMap` object:

```CSharp
AuthenticationToken at = new AuthenticationToken(ID_TOKEN);

am.AuthenticationToken = at;
```

Please see the [documentation](/doc/Home.md) for details on each method and what is available.

Have fun!