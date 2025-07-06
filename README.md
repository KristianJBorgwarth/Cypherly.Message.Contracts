# Cypherly.Message.Contracts

This project contains shared message contract definitions used across the Cypherly distributed system. These contracts define the structure of messages exchanged between services using asynchronous messaging (e.g., via RabbitMQ with MassTransit).

## Purpose

To provide a centralized and versioned set of strongly-typed message contracts for internal service communication.

## Features

- Clean C# records and classes for message passing
- Designed for use with [MassTransit](https://masstransit-project.com/)
- Versioned and distributed via internal NuGet feed

## Usage

1. Add the private NuGet feed to your `nuget.config` or via CLI:

    ```bash
    dotnet nuget add source "C:\NuGetPackages" --name PrivateLocal
    ```

2. Reference the package in your service project:

    ```xml
    <PackageReference Include="Cypherly.Message.Contracts" Version="1.0.0" />
    ```

3. Use the contracts in your consumers/producers:

    ```csharp
    public record UserRegistered(Guid UserId, string Email);
    ```

## Publishing

To create and publish a new version to the internal feed:

```bash
dotnet pack -c Release
copy .\bin\Release\Cypherly.Message.Contracts.*.nupkg C:\NuGetPackages
