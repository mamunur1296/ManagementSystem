using AutoMapper;
using MediatR;
using Project.Application.Features.CompanyFeatures.Commands;
using Project.Application.Models;
using Project.Domail.Abstractions;
using Project.Domail.Entities;

namespace Project.Application.Features.CompanyFeatures.Handlers.CommandHandlers
{
    public class CreateCompanyHandler : IRequestHandler<CreateCompanyCommand, CompanyModels>
    {
        private readonly IUnitOfWorkDb _unitOfWorkDb;
        private readonly IMapper _mapper;

        public CreateCompanyHandler(IUnitOfWorkDb unitOfWorkDb, IMapper mapper)
        {
            _unitOfWorkDb = unitOfWorkDb;
            _mapper = mapper;
        }
        public async Task<CompanyModels> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            var productSizeEntity = _mapper.Map<Company>(request);
            await _unitOfWorkDb.companyCommandRepository.AddAsync(productSizeEntity);
            await _unitOfWorkDb.SaveAsync();
            var newResponse = _mapper.Map<CompanyModels>(productSizeEntity);
            return newResponse;
        }
    }
}
