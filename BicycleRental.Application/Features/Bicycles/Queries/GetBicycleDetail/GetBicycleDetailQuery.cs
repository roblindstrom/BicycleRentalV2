using MediatR;

namespace BicycleRental.Application.Features.Bicycles.Queries.GetBicycleDetail
{
    public class GetBicycleDetailQuery : IRequest<BicycleDetailVm>
    {
        public double BicycleID { get; set; }

    }
}
