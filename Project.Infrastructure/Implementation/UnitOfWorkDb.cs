using Project.Domail.Abstractions;
using Project.Domail.Abstractions.CommandRepositories;
using Project.Domail.Abstractions.QueryRepositories;
using Project.Infrastructure.DataContext;
using Project.Infrastructure.Implementation.Command;
using Project.Infrastructure.Implementation.Query;

namespace Project.Infrastructure.Implementation
{
    public class UnitOfWorkDb : IUnitOfWorkDb
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ICustomerCommandRepository customerCommandRepository { get; private set; }
        public ICustomerQueryRepository customerQueryRepository { get; private set; }

        public IProductSizeCommandRepository productSizeCommandRepository { get; private set; }

        public IProductSizeQueryRepository productSizeQueryRepository { get; private set; }

        public UnitOfWorkDb(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            customerCommandRepository = new CustomerCommandRepository(applicationDbContext);
            customerQueryRepository = new CustomerQueryRepository(applicationDbContext);
            productSizeQueryRepository= new ProductSizeQueryRepository(applicationDbContext);
            productSizeCommandRepository = new ProductSizeCommandRepository(applicationDbContext);
        }



        public async Task SaveAsync()
        {
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
