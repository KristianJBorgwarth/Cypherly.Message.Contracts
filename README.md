# Cypherly.Message.Contracts

This project contains shared message contract definitions used across the Cypherly distributed system. These contracts define the structure of messages exchanged between services using asynchronous messaging (e.g., via RabbitMQ with MassTransit).

## Purpose

To provide a centralized and versioned set of strongly-typed message contracts for internal service communication.

## Features

- Clean C# records and classes for message passing
- Designed for use with [MassTransit](https://masstransit-project.com/)
- Versioned and distributed via internal NuGet feed
