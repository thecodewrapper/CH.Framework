[![NuGet-CH.Domain.Abstractions](https://img.shields.io/nuget/v/CH.Domain.Abstractions.svg?label=CH.Domain.Abstractions)](https://www.nuget.org/packages/CH.Domain.Abstractions/)
[![NuGet-CH.Messaging.Abstractions](https://img.shields.io/nuget/v/CH.Messaging.Abstractions.svg?label=CH.Messaging.Abstractions)](https://www.nuget.org/packages/CH.Messaging.Abstractions/)
[![NuGet-CH.Data.Abstractions](https://img.shields.io/nuget/v/CH.Data.Abstractions.svg?label=CH.Data.Abstractions)](https://www.nuget.org/packages/CH.Data.Abstractions/)
[![NuGet-CH.EventStore.Abstractions](https://img.shields.io/nuget/v/CH.EventStore.Abstractions.svg?label=CH.EventStore.Abstractions)](https://www.nuget.org/packages/CH.EventStore.Abstractions/)
[![NuGet-CH.EventStore.EntityFramework](https://img.shields.io/nuget/v/CH.EventStore.EntityFramework.svg?label=CH.EventStore.EntityFramework)](https://www.nuget.org/packages/CH.EventStore.EntityFramework/)
[![Donate](https://img.shields.io/badge/Donate-PayPal-red.svg)](https://www.paypal.com/donate?hosted_button_id=XSXQYY5KBMXYW)

# CH Framework

A collection of libraries and abstractions for building robust .NET applications.

## Description

The `CH Framework` repository provides a set of libraries and abstractions to facilitate the implementation of various design patterns and persistence mechanisms in .NET applications. This includes support for Domain-Driven Design (DDD), event sourcing, and Entity Framework Core for data persistence.

## Projects

### CH - Domain.Abstractions

Provides abstractions for implementing tactical Domain-Driven Design (DDD) patterns such as Entities, Value Objects, and Aggregates. These abstractions help enforce DDD principles and streamline the creation of domain models.

Available as a NuGet package: [CH.Domain.Abstractions](https://www.nuget.org/packages/CH.Domain.Abstractions)

### CH - Messaging.Abstractions

Offers abstractions for messaging patterns, including support for event-driven architectures. This project enables consistent handling of domain events, integration events, and other messaging workflows.

Available as a NuGet package: [CH.Messaging.Abstractions](https://www.nuget.org/packages/CH.Messaging.Abstractions)

### CH - Data.Abstractions

Contains abstractions for persistence-related operations, such as Repositories, Unit of Work, and data entities. These abstractions simplify the integration of persistence logic and promote separation of concerns.

Available as a NuGet package: [CH.Data.Abstractions](https://www.nuget.org/packages/CH.Data.Abstractions)

### CH - EventStore.Abstractions

Defines abstractions for an event store to support event sourcing. This project provides a foundation for implementing event storage and retrieval mechanisms across various persistence backends.

Available as a NuGet package: [CH.EventStore.Abstractions](https://www.nuget.org/packages/CH.EventStore.Abstractions)

### CH - EventStore.EntityFramework

Implements event store persistence using Entity Framework Core 7. This project supports both in-memory and SQL-based providers, offering flexibility for development and production environments.

Available as a NuGet package: [CH.EventStore.EntityFramework](https://www.nuget.org/packages/CH.EventStore.EntityFramework)

## Features

- **Domain-Driven Design (DDD):** Tools and abstractions for implementing DDD tactical patterns.
- **Event Sourcing:** Event store abstractions and implementations for managing domain events.
- **Messaging Patterns:** Abstractions to enable event-driven and message-based architectures.
- **EF Core Integration:** Out-of-the-box support for persistence with EF Core 7.
- **Extensibility:** Easily extend or customize components to fit specific application needs.

## Getting Started

### Prerequisites

- .NET 6 or later
- EF Core (for `CH - EventStore.EntityFramework`)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/ch-framework.git
   ```
2. Navigate to the project directory:
   ```bash
   cd ch-framework
   ```
3. Build the solution:
   ```bash
   dotnet build
   ```

### Usage

1. Add references to the required projects in your .NET application.
2. Configure services and dependencies in your DI container as needed.
3. Start leveraging the provided abstractions and libraries to implement your application logic.

## Contributing

Contributions are welcome! Please follow these steps to contribute:
