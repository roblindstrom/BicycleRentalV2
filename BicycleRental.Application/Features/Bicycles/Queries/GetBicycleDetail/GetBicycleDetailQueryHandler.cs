using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Bicycles.Queries.GetBicycleDetail
{
    public class GetBicycleDetailQueryHandler : IRequestHandler<GetBicycleDetailQuery, BicycleDetailVm>
    {
        private readonly IAsyncRepository<Bicycle> _bicycleRepository;
        private readonly IAsyncRepository<Order> _orderRepository;
        private readonly IMapper _mapper;

        public GetBicycleDetailQueryHandler(IMapper mapper, IAsyncRepository<Bicycle> bicycleRepository, IAsyncRepository<Order> orderRepository)
        {
            _mapper = mapper;
            _bicycleRepository = bicycleRepository;
            _orderRepository = orderRepository;
        }

        public async Task<BicycleDetailVm> Handle(GetBicycleDetailQuery request, CancellationToken cancellationToken)
        {
            var bicycle = await _bicycleRepository.GetByIdAsync(request.BicycleID);
            var biycleDetailDTO = _mapper.Map<BicycleDetailVm>(bicycle);

            var order = await _orderRepository.GetByIdAsync(bicycle.BicycleId);

            biycleDetailDTO.OrderDto = _mapper.Map<OrderDto>(order);

            return biycleDetailDTO;
        }
    }
}
