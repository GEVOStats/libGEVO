# Contributing

## Adding new Models
All models are to be generated from a valid JSON response.  You can use https://json2csharp.com/ with the following settings.
* Use Pascal Case
* Use JsonPropertyName (.NET Core)
* Use Record Types 

Each Model should exist in their corresponding Request/Response namespace. Additionally, organization for models is Tx.Route.Ty where Tx is Request/Response, Route is the route in the api (i.e. /Auth) and Ty is the model.