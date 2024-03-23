# Project Architecture Overview

This project implements CRUD operations for managing delivery addresses using the CQRS (Command Query Responsibility Segregation) pattern along with MediatR and AutoMapper.

## Description

This project follows a clean architecture pattern with clear separation of concerns. Here's a brief overview of each layer:

- **Domain Layer:** Contains the domain entities and abstractions such as repositories and unit of work.
- **Infrastructure Layer:** Implements the repositories and unit of work abstractions.
- **Application Layer:** Implements the application features including DTOs, models, commands, queries, and their respective handlers.
- **API Layer:** Contains controllers for handling HTTP requests and responses.



## Project Structure

Project/

├── Domain/

│   ├── Entities/

│   │   └── DeliveryAddress.cs

│   └── Abstractions/

│       ├── CommandRepositories/

│       │   ├── IDeliveryAddressCommandRepository.cs

│       │   └── ...

│       └── QueryRepositories/

│           ├── IDeliveryAddressQueryRepository.cs

│           └── ...
│   └── IUnitOfWorkDb.cs

├── Infrastructure/

│   ├── DataContext/

│   │   └── ApplicationDbContext.cs

│   └── Implementation/

│       ├── Command/

│       │   └── DeliveryAddressCommandRepository.cs

│       ├── Query/

│       │   └── DeliveryAddressQueryRepository.cs

│       └── UnitOfWorkDb.cs

├── Application/

│   ├── DTOs/

│   │   └── DeliveryAddressDTO.cs

│   ├── Models/

│   │   └── DeliveryAddressModels.cs

│   ├── Features/

│   │   └── DeliveryAddressFeatures/

│   │       ├── Commands/

│   │       │   ├── CreateDeliveryAddressCommand.cs

│   │       │   ├── DeleteDeliveryAddressCommand.cs

│   │       │   └── UpdateDeliveryAddressCommand.cs

│   │       ├── Queries/

│   │       │   ├── GetAllDeliveryAddressQuery.cs

│   │       │   └── GetDeliveryAddressByIdQuery.cs

│   │       └── Handlers/

│   │           ├── CommandHandlers/

│   │           │   ├── CreateDeliveryAddressHandler.cs

│   │           │   ├── DeleteDeliveryAddressHandler.cs

│   │           │   └── UpdateDeliveryAddressHandler.cs

│   │           └── QueryHandlers/

│   │               ├── GetAllDeliveryAddressHandler.cs

│   │               └── GetDeliveryAddressByIdHandler.cs

│   └── Mapper/

│       └── DeliveryAddressMappingProfile.cs

└── API/

    └── Controllers/

        └── DeliveryAddressController.cs


## Cline Architecture Table

| Layer         | Responsibility                                                                           |
|---------------|------------------------------------------------------------------------------------------|
| Domain        | Contains business entities and abstractions for repositories and unit of work            |
| Infrastructure| Implements data access logic and interacts with external resources like databases         |
| Application   | Implements business logic, features, handlers, DTOs, and mapping profiles                 |
| API           | Provides endpoints to interact with the application, including controllers and routes     |


## CRUD Operations using MediatR and AutoMapper

### Step 1: Entity for Domain/Entity folder

```csharp
public class DeliveryAddress
{
    public Guid Id { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Mobile { get; set; }
    public string CreatedBy { get; set; }
}


## Step 2: Abstractions for Domain/Abstraction folder

### 1. IDeliveryAddressCommandRepository.cs

```csharp
using Project.Domail.Abstractions.CommandRepositories.Base;
using Project.Domail.Entities;

namespace Project.Domail.Abstractions.CommandRepositories
{
    public interface IDeliveryAddressCommandRepository : ICommandRepository<DeliveryAddress>
    {
        // Add specific command methods here if needed
    }
}
### 2. IDeliveryAddressQueryRepository.cs

```csharp
using Project.Domail.Abstractions.QueryRepositories.Base;
using Project.Domail.Entities;

namespace Project.Domail.Abstractions.QueryRepositories
{
    public interface IDeliveryAddressQueryRepository : IQueryRepository<DeliveryAddress>
    {
        // Add specific Query methods here if needed
    }
}


### 3. IUnitOfWorkDb.cs

```csharp
using Project.Domail.Abstractions.CommandRepositories;
using Project.Domail.Abstractions.QueryRepositories;
using System.Threading.Tasks;

namespace Project.Domail.Abstractions
{
    public interface IUnitOfWorkDb
    {
        IDeliveryAddressQueryRepository DeliveryAddressQueryRepository { get; }
        IDeliveryAddressCommandRepository DeliveryAddressCommandRepository { get; }
        Task SaveAsync();
    }
}

