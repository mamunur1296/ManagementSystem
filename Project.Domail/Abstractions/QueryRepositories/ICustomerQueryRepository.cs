using Project.Domail.Abstractions.QueryRepositories.Base;
using Project.Domail.Entities;

namespace Project.Domail.Abstractions.QueryRepositories
{
    public interface ICustomerQueryRepository : IQueryRepository<Customer>
    {
        Task<Customer> GetCustomerByEmail(string email);
    }
}
