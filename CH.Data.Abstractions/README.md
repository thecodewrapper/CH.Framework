# CH - Data.Abstractions

Abstractions for persistence-related operations (Repositories, Unit of Work, data entities).

## Description

The `CH - Data.Abstractions` project provides a set of abstractions to facilitate the implementation of persistence-related operations such as repositories, unit of work, and data entities. This library is designed to be used across multiple .NET platforms, ensuring compatibility and flexibility in various application environments.

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

To install the `CH - Data.Abstractions` package, you can use the following command in the .NET CLI:

```
dotnet add package CH.Data.Abstractions
```

Or via the NuGet Package Manager:

```
Install-Package CH.Data.Abstractions
```

## Usage

To use the abstractions provided by this library, include the necessary namespaces in your project and implement the interfaces as needed to fit your data persistence model.

### Included Files

- [AuditableEntity.cs](#auditableentity.cs-context): Provides an abstract base class for entities that need to track creation and modification metadata.
- [DataEntityBase.cs](#dataentitybase.cs-context): A base data entity class that inherits from `AuditableEntity` and implements `IDataEntity<TId>`.

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