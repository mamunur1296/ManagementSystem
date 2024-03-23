using MediatR;
using Project.Application.Features.CompanyFeatures.Commands;
using Project.Domail.Abstractions;

namespace Project.Application.Features.CompanyFeatures.Handlers.CommandHandlers
{
    public class DeleteCompanyHandler : IRequestHandler<DeleteCompanyCommand, string>
    {
        private readonly IUnitOfWorkDb _unitOfWorkDb;

        public DeleteCompanyHandler(IUnitOfWorkDb unitOfWorkDb)
        {
            _unitOfWorkDb = unitOfWorkDb;
        }

        public async Task<string> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            var date = await _unitOfWorkDb.companyrQueryRepository.GetByIdAsync(request.Id);
            if (date == null)
            {
                return "Data not found";
            }
            await _unitOfWorkDb.companyCommandRepository.DeleteAsync(date);
            await _unitOfWorkDb.SaveAsync();
            return "Completed";
        }
    }
}
