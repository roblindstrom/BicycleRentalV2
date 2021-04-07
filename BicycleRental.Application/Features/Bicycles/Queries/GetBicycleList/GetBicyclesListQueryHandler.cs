using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Bicycles.Queries.GetBicycleList
{
    public class GetBicyclesListQueryHandler : IRequestHandler<GetBicyclesListQuery, List<BicycleListVm>>
    {
        private readonly IAsyncRepository<Bicycle> _bicycleRepository;
        private readonly IMapper _mapper;

        public GetBicyclesListQueryHandler(IMapper mapper, IAsyncRepository<Bicycle> bicycleRepository)
        {
            _mapper = mapper;
            _bicycleRepository = bicycleRepository;
        }

        public async Task<List<BicycleListVm>> Handle(GetBicyclesListQuery request, CancellationToken cancellationToken)
        {
            var allBicycles = (await _bicycleRepository.ListAllAsync()).OrderBy(x => x.BicycleId);
            return _mapper.Map<List<BicycleListVm>>(allBicycles);
        }




    }
}
