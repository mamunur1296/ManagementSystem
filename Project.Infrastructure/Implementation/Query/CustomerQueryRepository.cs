using Microsoft.EntityFrameworkCore;
using Project.Domail.Abstractions.QueryRepositories;
using Project.Domail.Entities;
using Project.Infrastructure.DataContext;
using Project.Infrastructure.Implementation.Query.Base;

namespace Project.Infrastructure.Implementation.Query
{
    public class CustomerQueryRepository : QueryRepository<Customer>, ICustomerQueryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CustomerQueryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) 
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Customer> GetCustomerByEmail(string email)
        {
            return await _applicationDbContext.Customers.FirstOrDefaultAsync(c => c.Email == email);
        }
        // Implement additional methods specific to CustomerQueryRepository here
    }
}
