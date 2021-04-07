using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Bicycles.Commands.CreateBicycle
{
    public class CreateBicycleCommandHandler : IRequestHandler<CreateBicycleCommand, CreateBicycleCommandResponse>
    {
        private readonly IBicycleRepository _bicycleRepository;
        private readonly IMapper _mapper;

        public CreateBicycleCommandHandler(IMapper mapper, IBicycleRepository bicycleRepository)
        {
            _mapper = mapper;
            _bicycleRepository = bicycleRepository;
        }

        public async Task<CreateBicycleCommandResponse> Handle(CreateBicycleCommand request, CancellationToken cancellationToken)
        {
            var createBicycleCommandResponse = new CreateBicycleCommandResponse();

            var validator = new CreateBicycleCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createBicycleCommandResponse.Success = false;
                createBicycleCommandResponse.ValidationErrors = new List<string>();

                foreach (var error in validationResult.Errors)
                {
                    createBicycleCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }

            }
            if (createBicycleCommandResponse.Success)
            {
                var bicycle = new Bicycle() { 
                    BicycleId = request.BicycleID,
                    PricePerDay = request.PricePerDay
                
                };
                bicycle = await _bicycleRepository.AddAsync(bicycle);
                createBicycleCommandResponse.BicycleDto = _mapper.Map<CreateBicycleDto>(bicycle);
            }


            return createBicycleCommandResponse;
        }
    }
}
