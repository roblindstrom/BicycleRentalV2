using MediatR;
using System.Collections.Generic;

namespace BicycleRental.Application.Features.Bicycles.Queries.GetBicycleList
{
    public class GetBicyclesListQuery : IRequest<List<BicycleListVm>>
    {
    }
}
