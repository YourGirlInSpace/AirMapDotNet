Getting Started
=========

Thank you for taking the time to look at the AirMapDotNet SDK!  Before you can start using the SDK, there are a few things you need to do first.

## Prerequisites

### AirMap Developer Account

Before you begin, you will need to sign up for a developer account to create an API key so you can begin to make API calls.  Here are the steps to getting an account:

1. Sign up for a free AirMap account on the [Developer Portal](https://dashboard.airmap.io/developer/).
2. Apply to become a developer.  This may take several days.
![Developer Registration](https://files.readme.io/c80a8e0-applydeveloper.png)
3. Create a new application.
![Application Creation](https://files.readme.io/65ba1a7-addapplication.png)
4. Generate an API key.
![Create API Key](https://files.readme.io/c451f67-generatekey.png)

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

Create a new `AirMap` object and try the following code:

```CSharp
AirMap am = new AirMap(AIRMAP_API_KEY);

Manufacturers[] manus = await am.GetManufacturers();
```

If the code above does not produce an `AirMapException`, you're good to go!