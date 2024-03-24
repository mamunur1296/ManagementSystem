﻿using AutoMapper;
using MediatR;
using Project.Application.DTOs;
using Project.Application.Features.TraderFeatures.Queries;
using Project.Domail.Abstractions;


namespace Project.Application.Features.TraderFeatures.Handlers.QueryHandlers
{
    public class GetTraderByIdHandler : IRequestHandler<GetTraderByIdQuery, TraderDTO>
    {
        private readonly IUnitOfWorkDb _unitOfWorkDb;
        private readonly IMapper _mapper;

        public GetTraderByIdHandler(IUnitOfWorkDb unitOfWorkDb, IMapper mapper)
        {
            _unitOfWorkDb = unitOfWorkDb;
            _mapper = mapper;
        }

        public async Task<TraderDTO> Handle(GetTraderByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWorkDb.traderQueryRepository.GetByIdAsync(request.Id);
            var newData = _mapper.Map<TraderDTO>(data);
            return newData;
        }
    }
}
