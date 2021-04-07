using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Bicycles.Commands.DeleteBicycle
{
    public class DeleteBicycleCommandHandler : IRequestHandler<DeleteBicycleCommand>
    {
        private readonly IAsyncRepository<Bicycle> _bicycleRepository;
        

        public DeleteBicycleCommandHandler(IBicycleRepository bicycleRepository)
        {
            
            _bicycleRepository = bicycleRepository;
        }

        public async Task<Unit> Handle(DeleteBicycleCommand request, CancellationToken cancellationToken)
        {
            var bicycleToDelete = await _bicycleRepository.GetByIdAsync(request.BicycleID);

            await _bicycleRepository.DeleteAsync(bicycleToDelete);

            return Unit.Value;
        }
    }
}
