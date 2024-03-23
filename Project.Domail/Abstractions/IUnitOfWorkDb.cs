using Project.Domail.Abstractions.CommandRepositories;
using Project.Domail.Abstractions.QueryRepositories;

namespace Project.Domail.Abstractions
{
    public interface IUnitOfWorkDb
    {
        IProductSizeCommandRepository productSizeCommandRepository { get; }
        IProductSizeQueryRepository productSizeQueryRepository { get; }
        IRetailerCommandRepository retailerCommandRepository { get; }
        IRetailerQueryRepository retailerQueryRepository { get; }
        ICompanyCommandRepository companyCommandRepository { get; }
        ICompanyrQueryRepository companyrQueryRepository { get; }
        IDeliveryAddressQueryRepository deliveryAddressQueryRepository { get; }
        IDeliveryAddressCommandRepository deliveryAddressCommandRepository { get; }
        Task SaveAsync();
    }
}
