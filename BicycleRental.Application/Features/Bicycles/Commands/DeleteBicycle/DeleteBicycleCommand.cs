using MediatR;

namespace BicycleRental.Application.Features.Bicycles.Commands.DeleteBicycle
{
    public class DeleteBicycleCommand : IRequest
    {
        public double BicycleID { get; set; }
    }
}
