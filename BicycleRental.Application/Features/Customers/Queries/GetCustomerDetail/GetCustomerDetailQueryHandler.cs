using AutoMapper;
using BicycleRental.Application.Features.Addresses.Queries.GetAddressDetail;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Customers.Queries.GetCustomerDetail
{
    public class GetCustomerDetailQueryHandler : IRequestHandler<GetCustomerDetailQuery, CustomerDetailVm>
    {
        private readonly IAsyncRepository<Address> _addressRepository;
        private readonly IAsyncRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomerDetailQueryHandler(IMapper mapper, IAsyncRepository<Customer> customerRepository, IAsyncRepository<Address> addressRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
            _addressRepository = addressRepository;
        }

        public async Task<CustomerDetailVm> Handle(GetCustomerDetailQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.CustomerID);
            var customerDetailVm = _mapper.Map<CustomerDetailVm>(customer);

            var address = await _addressRepository.GetByIdAsync(customer.CustomerAdressID);
            
            customerDetailVm.AddressVm = _mapper.Map<AddressDetailVm>(address);
            

            return customerDetailVm;
        }
    }
}
