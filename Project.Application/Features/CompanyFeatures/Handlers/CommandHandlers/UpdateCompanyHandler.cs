using AutoMapper;
using MediatR;
using Project.Application.Features.CompanyFeatures.Commands;
using Project.Application.Models;
using Project.Domail.Abstractions;

namespace Project.Application.Features.CompanyFeatures.Handlers.CommandHandlers
{
    public class UpdateCompanyHandler : IRequestHandler<UpdateCompanyCommand, CompanyModels>
    {
        private readonly IUnitOfWorkDb _unitOfWorkDb;
        private readonly IMapper _mapper;
        public UpdateCompanyHandler(IUnitOfWorkDb unitOfWorkDb, IMapper mapper)
        {
            _unitOfWorkDb = unitOfWorkDb;
            _mapper = mapper;
        }
       
        public async Task<CompanyModels> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWorkDb.companyrQueryRepository.GetByIdAsync(request.Id);
            if (data == null) return default;
            else
            {
                data.BIN = request.BIN;
                data.Name = request.Name;
                data.ContactPerNum = request.ContactPerNum;
                data.ContactNumber = request.ContactNumber;
                data.ContactPerNum = request.ContactPerNum;
                data.DeactiveBy = request.DeactiveBy;
            }
            await _unitOfWorkDb.companyCommandRepository.UpdateAsync(data);
            await _unitOfWorkDb.SaveAsync();
            var customerRes = _mapper.Map<CompanyModels>(data);
            return customerRes;
        }
    }
}
//          