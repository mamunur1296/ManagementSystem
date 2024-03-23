using Project.Domail.Abstractions.CommandRepositories.Base;
using Project.Domail.Entities;

namespace Project.Domail.Abstractions.CommandRepositories
{
    public interface ICustomerCommandRepository : ICommandRepository<Customer>
    {
        // Extand for all if any
    }
}
