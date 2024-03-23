using AutoMapper;
using MediatR;
using Project.Application.DTOs;
using Project.Application.Features.CompanyFeatures.Queries;
using Project.Application.Features.RetailerFeatures.Queries;
using Project.Domail.Abstractions;

namespace Project.Application.Features.CompanyFeatures.Handlers.QueryHandlers
{
    public class GetAllCompanyHandler : IRequestHandler<GetAllCompanyQuery, IEnumerable<CompanyDTO>>
    {
        private readonly IUnitOfWorkDb _unitOfWorkDb;
        private readonly IMapper _mapper;
        public GetAllCompanyHandler(IUnitOfWorkDb unitOfWorkDb, IMapper mapper)
        {
            _unitOfWorkDb = unitOfWorkDb;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CompanyDTO>> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
        {
            var dataList = await _unitOfWorkDb.companyrQueryRepository.GetAllAsync();
            var data = dataList.Select(x => _mapper.Map<CompanyDTO>(x));
            return data;
        }
    }
}
