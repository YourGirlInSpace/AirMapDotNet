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

First, download the `airmap.config.json` file from your dashboard and place it in the project's working directory.

Then, load the file using `APIConfiguration.LoadFromFileAsync`.

Finally, create a new `AirMap` instance with the configuration and explore to your heart's content!

```CSharp
APIConfiguration config = await APIConfiguration.LoadFromFileAsync("airmap.config.json");
AirMap am = new AirMap(config);

Manufacturers[] manus = await am.GetManufacturers();
```

If the code above does not produce an `AirMapException`, you're good to go!