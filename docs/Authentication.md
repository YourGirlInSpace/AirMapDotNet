Authentication
=========

Certain requests to the AirMap API requires authorization through the use of an `AuthenticationToken`.  That is, the user must have granted permission for an application to access the requested data.  To prove that the user has granted permission, the request header sent by the application must include a valid access token.

Authentication tokens may be acquired through the `AuthenticationService` class using the `LoginAsync` method, and providing an `AirMap` instance, a username and a password.

```CSharp
AuthenticationToken at = await AuthenticationService.LoginAsync(am, username, password);
```

A token may also be created using an `APIConfiguration` instance:

```CSharp
AuthenticationToken at = await AuthenticationService.LoginAsync(apiConfig, username, password);
```

Or, a token may be created with an ID token acquired through alternate means:

```CSharp
AuthenticationToken at = new AuthenticationToken(id_token);
```

This token may then be used in the `AirMap` instance by assigning it to the instance's `AuthenticationToken` property:

```CSharp
AirMap am = new AirMap(...);

am.AuthenticationToken = at;
```

To check whether the AuthenticationToken has expired, use the `IsValid` property:

```CSharp
if (!am.AuthenticationToken.IsValid)
   // Make the user log back in
```

### Authentication Errors

Authentication problems can arise in many AirMap endpoints.  All authentication errors are encapsulated with the `AuthenticationException` class, which contains information about the cause of the error.

The three causes of authentication errors during login are:
 - The client ID is unavailable
 - The user credentials were incorrect
 - A request for user information failed
 
The two main causes of authentication errors during runtime are:
 - The `AuthenticationToken` property on the `AirMap` instance has been unset
 - The token is no longer valid

### AuthenticationToken Properties

| Property  | Description                                                                  |
|-----------|------------------------------------------------------------------------------|
| Issuer    | The issuer of the authentication token.  Always `https://sso.airmap.io`      |
| Subject   | The user ID.                                                                 |
| Audience  | The client ID that the token is valid for.                                   |
| Expiry    | The time the authentication token expires.                                   |
| IssuedAt  | The time the authentication token was issued.                                |
| IsValid   | *true* if the current time is between `IssuedAt` and `Expiry`.               |
| Token     | The raw ID token.                                                            |
| User      | Details about the user account behind the `AuthenticationToken`              |