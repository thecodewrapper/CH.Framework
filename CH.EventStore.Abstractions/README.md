# CH - EventStore.Abstractions

Abstractions for an event store.

## Description

The `CH - EventStore.Abstractions` project provides a set of abstractions to facilitate the implementation of event store patterns. This library is designed to be used across multiple .NET platforms, ensuring compatibility and flexibility in various application environments.

## Target Frameworks

This project targets the following frameworks:
- .NET 9.0
- .NET 8.0
- .NET 7.0
- .NET 6.0
- .NET 5.0
- .NET Standard 2.1
- .NET Core 3.1

## Installation

To install the `CH - EventStore.Abstractions` package, you can use the following command in the .NET CLI:

```
dotnet add package CH.EventStore.Abstractions
```

Or via the NuGet Package Manager:

```
Install-Package CH.EventStore.Abstractions
```

## Usage

To use the abstractions provided by this library, include the necessary namespaces in your project and implement the interfaces as needed to fit your event store model.

### Included Interfaces

- [IEventStore](#ch.eventstore.abstractions.ieventstore): Interface containing load/save methods for an event store.
- [IEventStoreSnapshotProvider](#ch.eventstore.abstractions.ieventstoresnapshotprovider): Interface for fetching/saving snapshot aggregates.
- [IRetroactiveEventsService](#ch.eventstore.abstractions.iretroactiveeventsservice): Interface for applying retroactive events to the event stream.

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