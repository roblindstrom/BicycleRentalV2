using AutoMapper;
using BicycleRental.Application.Exceptions;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Bicycles.Commands.UpdateBicycle
{
    public class UpdateBicycleCommandHandler : IRequestHandler<UpdateBicycleCommand>
    {
        private readonly IBicycleRepository _bicycleRepository;
        private readonly IMapper _mapper;

        public UpdateBicycleCommandHandler(IMapper mapper, IBicycleRepository bicycleRepository)
        {
            _mapper = mapper;
            _bicycleRepository = bicycleRepository;
        }

        public async Task<Unit> Handle(UpdateBicycleCommand request, CancellationToken cancellationToken)
        {

            var bicycleToUpdate = await _bicycleRepository.GetByIdAsync(request.BicycleId);

            if (bicycleToUpdate == null)
            {
                throw new NotFoundException(nameof(Address), request.BicycleId);
            }

            var validator = new UpdateBicycleCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            bicycleToUpdate.BicycleId = request.BicycleId;
            bicycleToUpdate.PricePerDay = request.PricePerDay;

            await _bicycleRepository.UpdateAsync(bicycleToUpdate);

            return Unit.Value;
        }
    }
}
