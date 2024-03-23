# Project Architecture Overview

This project implements CRUD operations for managing delivery addresses using the CQRS (Command Query Responsibility Segregation) pattern along with MediatR and AutoMapper.

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
