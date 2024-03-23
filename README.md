# Project Architecture Overview

This project implements CRUD operations for managing delivery addresses using the CQRS (Command Query Responsibility Segregation) pattern along with MediatR and AutoMapper.

## Description

This project follows a clean architecture pattern with clear separation of concerns. Here's a brief overview of each layer:

- **Domain Layer:** Contains the domain entities and abstractions such as repositories and unit of work.
- **Infrastructure Layer:** Implements the repositories and unit of work abstractions.
- **Application Layer:** Implements the application features including DTOs, models, commands, queries, and their respective handlers.
- **API Layer:** Contains controllers for handling HTTP requests and responses.

## Usage

The project provides endpoints for creating, updating, deleting, and retrieving delivery addresses. These endpoints are exposed through the API layer's controllers.

## Installation

1. Clone the repository:

    ```
    git clone <repository_url>
    ```

2. Build the solution:

    ```
    dotnet build
    ```

3. Run the application:

    ```
    dotnet run
    ```

## Contributing

Contributions are welcome! Feel free to submit issues and pull requests.

## License

This project is licensed under the [MIT License](LICENSE).

## Project Structure

Project/
├── Domain/
│ ├── Entities/
│ │ └── DeliveryAddress.cs
│ └── Abstractions/
│ ├── CommandRepositories/
│ │ ├── IDeliveryAddressCommandRepository.cs
│ │ └── ...
│ ├── QueryRepositories/
│ │ ├── IDeliveryAddressQueryRepository.cs
│ │ └── ...
│ └── IUnitOfWorkDb.cs
├── Infrastructure/
│ ├── DataContext/
│ │ └── ApplicationDbContext.cs
│ └── Implementation/
│ ├── Command/
│ │ └── DeliveryAddressCommandRepository.cs
│ ├── Query/
│ │ └── DeliveryAddressQueryRepository.cs
│ └── UnitOfWorkDb.cs
├── Application/
│ ├── DTOs/
│ │ └── DeliveryAddressDTO.cs
│ ├── Models/
│ │ └── DeliveryAddressModels.cs
│ ├── Features/
│ │ └── DeliveryAddressFeatures/
│ │ ├── Commands/
│ │ │ ├── CreateDeliveryAddressCommand.cs
│ │ │ ├── DeleteDeliveryAddressCommand.cs
│ │ │ └── UpdateDeliveryAddressCommand.cs
│ │ ├── Queries/
│ │ │ ├── GetAllDeliveryAddressQuery.cs
│ │ │ └── GetDeliveryAddressByIdQuery.cs
│ │ └── Handlers/
│ │ ├── CommandHandlers/
│ │ │ ├── CreateDeliveryAddressHandler.cs
│ │ │ ├── DeleteDeliveryAddressHandler.cs
│ │ │ └── UpdateDeliveryAddressHandler.cs
│ │ └── QueryHandlers/
│ │ ├── GetAllDeliveryAddressHandler.cs
│ │ └── GetDeliveryAddressByIdHandler.cs
│ └── Mapper/
│ └── DeliveryAddressMappingProfile.cs
└── API/
└── Controllers/
└── DeliveryAddressController.cs
