# MicroNetCore

## Overview
A framework over AspNetCore for developing microservice-based solutions.

## Structure

### Gateway services
Gateway service is a proxy application for redirecting incoming requests to the appropriate business services.

#### Install
Package Manager
```
PM> Install-Package MicroNetCore.GatewayService -Version 0.0.1-alpha
```

#### Usage
Add "Settings" folder in your project root folder and a JSON file inside it with a "ProxyOptions" section:
```json
{
  "ProxyOptions": {
    "api/posts": "http://jsonplaceholder.typicode.com/posts",
    "api/comments": "http://jsonplaceholder.typicode.com/comments",
    "api/albums": "http://jsonplaceholder.typicode.com/albums",
    "api/photos": "http://jsonplaceholder.typicode.com/photos",
    "api/todos": "http://jsonplaceholder.typicode.com/todos",
    "api/users": "http://jsonplaceholder.typicode.com/users"
  }
}
```

Make your class with the Main method to inherit from the GatewayProgram class and call BuildGateway method to get the IWebHost for the Gateway service to run:
```csharp
public sealed class SampleGatewayProgram : GatewayProgram
{
    public static void Main(string[] args)
    {
        BuildGateway(args).Run();
    }
}
```

Also check samples/MicroNetCore.SampleGateway project for a working sample.

### Business services
Business service is an application containing the business logic.

### Data services
Data service is an application with RESTful API for managing a data source.
