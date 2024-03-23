using Project.Domail.Abstractions.CommandRepositories;
using Project.Domail.Abstractions.QueryRepositories;

namespace Project.Domail.Abstractions
{
    public interface IUnitOfWorkDb
    {
        ICustomerCommandRepository customerCommandRepository { get; }
        ICustomerQueryRepository customerQueryRepository { get; }
        IProductSizeCommandRepository productSizeCommandRepository { get; }
        IProductSizeQueryRepository productSizeQueryRepository { get; }
        Task SaveAsync();
    }
}
