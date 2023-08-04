AgileCoding.Library.Interfaces NuGet Package
============================================

This package contains a set of standardized interfaces for use across various domains. It's ideal for creating standardized, modular, and easy-to-understand code.

Features
--------

This package offers the following interfaces:

1.  ILogger - An interface for logging functionalities.
2.  IServiceProxy - An interface representing service proxies.
3.  IServiceRequest - An interface representing service requests.
4.  IServiceResponse - An interface representing service responses.

How to Use
----------

To use these interfaces in your project, install the package and implement the interfaces as needed in your classes.

For example, to use the ILogger interface, you would do something like this:

```csharp
using AgileCoding.Library.Interfaces.Logging;
using AgileCoding.Library.Enums.Logging;
using System;
using System.Collections.Generic;

public class MyLogger : ILogger
{
    // Implement ILogger methods
    public bool WriteCore(LogTypeEnum eventType, int eventId, object state, Exception exception, Func<object, Exception, string> formatter)
    {
        // Implementation details
    }

    public bool WriteCore(LogTypeEnum eventType, int eventId, object state, Exception exception, Dictionary<string, string> parameters, Func<object, Exception, string> formatter)
    {
        // Implementation details
    }

    public void Dispose()
    {
        // Cleanup
    }
}
```

Installation
------------

You can install this NuGet package through the following ways:

-   Package Manager: "PM> Install-Package AgileCoding.Library.Interfaces -Version 2.0.5"
-   .NET CLI: "dotnet add package AgileCoding.Library.Interfaces --version 2.0.5"

Requirements
------------

.NET 6.0 or later

Contribute
----------

This is an open source project. We encourage you to contribute to it by submitting issues, or directly contributing code.

License
-------

This project is licensed under the terms of the MIT license.

Contact
-------

For questions or any other feedback, please open an issue in the GitHub repository.