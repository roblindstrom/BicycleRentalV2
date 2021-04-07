using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Customers.Queries.GetCustomersList
{
    public class GetCustomersListQueryHandler : IRequestHandler<GetCustomersListQuery, List<CustomerListVm>>
    {
        private readonly IAsyncRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomersListQueryHandler(IMapper mapper, IAsyncRepository<Customer> customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }



        public async Task<List<CustomerListVm>> Handle(GetCustomersListQuery request, CancellationToken cancellationToken)
        {
            var allCustomers = (await _customerRepository.ListAllAsync()).OrderBy(x => x.CustomerID);
            return _mapper.Map<List<CustomerListVm>>(allCustomers);
        }
    }
}
