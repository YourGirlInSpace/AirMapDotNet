Authentication
=========

Certain requests to the AirMap API requires authorization through the use of an `AuthenticationToken`.  That is, the user must have granted permission for an application to access the requested data.  To prove that the user has granted permission, the request header sent by the application must include a valid access token.

Authentication tokens may be acquired through an Auth0 library, or through the official [js-auth](https://github.com/airmap/js-auth) provided by the AirMap team.

An Authentication Token is a standard [JWT](https://jwt.io) with the following payload:

```JSON
{
  "iss": "https://sso.airmap.io/",
  "sub": "auth0|58...5c",
  "aud": "OP...xF",
  "exp": 1492151724,
  "iat": 1492115724
}
```

The parameters of the payload are as follows:

| Parameter | Name          | Description                                                                  |
|-----------|---------------|------------------------------------------------------------------------------|
| iss       | Issuer        | The issuer of the authentication token.  Always `https://sso.airmap.io`      |
| sub       | Subject       | The user ID.                                                                 |
| aud       | Audience      | The client ID that the token is valid for.                                   |
| exp       | Expiry Time   | The time the authentication token expires.                                   |
| iat       | Issuance Time | The time the authentication token was issued.                                |

Once you have acquired an AuthenticationToken through [Auth0](https://auth0.com/) or the [js-auth](https://github.com/airmap/js-auth) library, you may use it in the AirMapDotNet SDK:

```CSharp
AuthenticationToken at = new AuthenticationToken("eyJ...w28");

airmap_inst.AuthenticationToken = at;
```

To check whether the AuthenticationToken has expired, use the `IsValid` property.

### AuthenticationToken Properties

| Property  | Description                                                                  |
|-----------|------------------------------------------------------------------------------|
| Issuer    | The issuer of the authentication token.  Always `https://sso.airmap.io`      |
| Subject   | The user ID.                                                                 |
| Audience  | The client ID that the token is valid for.                                   |
| Expiry    | The time the authentication token expires.                                   |
| IssuedAt  | The time the authentication token was issued.                                |
| IsValid   | *true* if the current time is between IssuedAt and Expiry.                   |
| Token     | The raw ID token.                                                            |