# CH - EventStore.EntityFramework

Event store persistence implementation using EFCore 8. Supports in-memory and SQL providers.

## Description

The `CH - EventStore.EntityFramework` project provides an implementation of an event store using Entity Framework Core 8. This library supports both in-memory and SQL providers, making it flexible for various application environments.

## Target Framework

This project targets the following framework:
- .NET 8.0

## Installation

To install the `CH - EventStore.EntityFramework` package, you can use the following command in the .NET CLI:

```
dotnet add package CH.EventStore.EntityFramework
```

Or via the NuGet Package Manager:

```
Install-Package CH.EventStore.EntityFramework
```

## Usage

To use the event store implementation provided by this library, include the necessary namespaces in your project and configure the Entity Framework Core context to use the desired provider (in-memory or SQL).

### Example

```csharp
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CH.EventStore.EntityFramework;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Configure EFCore to use In-Memory database
        services.AddDbContext<EventStoreDbContext>(options =>
            options.UseInMemoryDatabase("EventStore"));

        // Or configure EFCore to use SQL Server
        services.AddDbContext<EventStoreDbContext>(options =>
            options.UseSqlServer("YourConnectionString"));

        // Add other services here
    }
}
```

### Included Files

- [EFEventStore.cs](#efeventstore.cs-context): An implementation of `IEventStore` using Entity Framework.
- [EFEventStoreSnapshotProvider.cs](#efeventstoresnapshotprovider.cs-context): Implementation of `IEventStoreSnapshotProvider` using Entity Framework.
- [EFRetroactiveEventsService](#class:ch.eventstore.entityframework.efretroactiveeventsservice): Service to handle applying retroactive events to the event stream.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Repository

For more information, visit the [GitHub repository](https://github.com/thecodewrapper/CH.Framework).

## Authors

- Charalambos Hadjiantoniou

## Version

Current version: 1.1.0

## Package Icon

![Package Icon](logo-duck.png)