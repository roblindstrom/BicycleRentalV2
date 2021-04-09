using AutoMapper;
using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BicycleRental.Application.Features.Seeds.Commands.CreateSeeds
{
    public class CreateSeedsHandler : IRequestHandler<CreateSeedCommand, CreateSeedCommandResponse>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IBicycleRepository _bicycleRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CreateSeedsHandler(IMapper mapper, IOrderRepository orderRepository, IBicycleRepository bicycleRepository, IAddressRepository addressRepository, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _bicycleRepository = bicycleRepository;
            _addressRepository = addressRepository;
            _customerRepository = customerRepository;
        }

        

        public async Task<CreateSeedCommandResponse> Handle(CreateSeedCommand request, CancellationToken cancellationToken)
        {

            

            var Bicycle1 = new Bicycle { BicycleId = 84753, PricePerDay = 100, BicycleBrand = (BicycleBrand)1, BicycleSize = (BicycleSize)3 };
            var Bicycle2 = new Bicycle { BicycleId = 53765, PricePerDay = 200, BicycleBrand = (BicycleBrand)4, BicycleSize = (BicycleSize)4 };
            var Bicycle3 = new Bicycle { BicycleId = 97532, PricePerDay = 125, BicycleBrand = (BicycleBrand)3, BicycleSize = (BicycleSize)5 };
            var Bicycle4 = new Bicycle { BicycleId = 15365, PricePerDay = 175, BicycleBrand = (BicycleBrand)2, BicycleSize = (BicycleSize)2 };
            var Bicycle5 = new Bicycle { BicycleId = 97564, PricePerDay = 50,  BicycleBrand = (BicycleBrand)6, BicycleSize = (BicycleSize)1 };
            var Bicycle6 = new Bicycle { BicycleId = 64823, PricePerDay = 300, BicycleBrand = (BicycleBrand)7, BicycleSize = (BicycleSize)3 };
            var Bicycle7 = new Bicycle { BicycleId = 29756, PricePerDay = 200, BicycleBrand = (BicycleBrand)8, BicycleSize = (BicycleSize)3 };
            var Bicycle8 = new Bicycle { BicycleId = 15672, PricePerDay = 150, BicycleBrand = (BicycleBrand)2, BicycleSize = (BicycleSize)4 };
            var Bicycle9 = new Bicycle { BicycleId = 34556, PricePerDay = 125, BicycleBrand = (BicycleBrand)9, BicycleSize = (BicycleSize)3 };

            var customer1 = new Customer { CustomerID = 199204271234, Firstname = "Robin", Lastname = "Lindström", CustomerAdressID = 1 };
            var customer2 = new Customer { CustomerID = 195006201234, Firstname = "Sven", Lastname = "Svensson", CustomerAdressID = 2 };
            var customer3 = new Customer { CustomerID = 192005121234, Firstname = "Lars", Lastname = "Larssson", CustomerAdressID = 3 };
            var customer4 = new Customer { CustomerID = 198012301234, Firstname = "Erik", Lastname = "Eriksson", CustomerAdressID = 4 };
            var customer5 = new Customer { CustomerID = 199505121234, Firstname = "Pontus", Lastname = "Pontusson", CustomerAdressID = 5 };
            var customer6 = new Customer { CustomerID = 198701031234, Firstname = "Rebecca", Lastname = "Rebeccasson", CustomerAdressID = 6 };
            var customer7 = new Customer { CustomerID = 199910251234, Firstname = "Vivi", Lastname = "Vivisson", CustomerAdressID = 7 };
            var customer8 = new Customer { CustomerID = 196008301234, Firstname = "Lisa", Lastname = "Lisasson", CustomerAdressID = 8 };
            var customer9 = new Customer { CustomerID = 195004221234, Firstname = "Arne", Lastname = "Arnesson", CustomerAdressID = 9 };

            var address1 = new Address { AddressName = "Pilegården", AddressID = 1, };
            var address2 = new Address { AddressName = "Näckrosvägen", AddressID = 2, };
            var address3 = new Address { AddressName = "Eketrägatan", AddressID = 3, };
            var address4 = new Address { AddressName = "Säterigatan", AddressID = 4, };
            var address5 = new Address { AddressName = "Avenyn", AddressID = 5, };
            var address6 = new Address { AddressName = "Danskavägen", AddressID = 6, };
            var address7 = new Address { AddressName = "Redbergsvägen", AddressID = 7, };
            var address8 = new Address { AddressName = "Kruthusgatan", AddressID = 8, };
            var address9 = new Address { AddressName = "Skånegatan", AddressID = 9, };



            var order1 = new Order { BicycleID = 84753, CustomerID = 199204271234, BookingStartDate = DateTime.Now, BookingEndDate = DateTime.Now, Bicycle = Bicycle1, Customer = customer1 };
            var order2 = new Order { BicycleID = 53765, CustomerID = 195006201234, BookingStartDate = DateTime.Now, BookingEndDate = DateTime.Now, Bicycle = Bicycle2, Customer = customer2 };
            var order3 = new Order { BicycleID = 97532, CustomerID = 192005121234, BookingStartDate = DateTime.Now, BookingEndDate = DateTime.Now, Bicycle = Bicycle3, Customer = customer3 };
            var order4 = new Order { BicycleID = 15365, CustomerID = 198012301234, BookingStartDate = DateTime.Now, BookingEndDate = DateTime.Now, Bicycle = Bicycle4, Customer = customer4 };
            var order5 = new Order { BicycleID = 97564, CustomerID = 199505121234, BookingStartDate = DateTime.Now, BookingEndDate = DateTime.Now, Bicycle = Bicycle5, Customer = customer5 };
            var order6 = new Order { BicycleID = 64823, CustomerID = 198701031234, BookingStartDate = DateTime.Now, BookingEndDate = DateTime.Now, Bicycle = Bicycle6, Customer = customer6 };
            var order7 = new Order { BicycleID = 29756, CustomerID = 199910251234, BookingStartDate = DateTime.Now, BookingEndDate = DateTime.Now, Bicycle = Bicycle7, Customer = customer7 };
            var order8 = new Order { BicycleID = 15672, CustomerID = 196008301234, BookingStartDate = DateTime.Now, BookingEndDate = DateTime.Now, Bicycle = Bicycle8, Customer = customer8 };
            var order9 = new Order { BicycleID = 34556, CustomerID = 199204271234, BookingStartDate = DateTime.Now, BookingEndDate = DateTime.Now, Bicycle = Bicycle9, Customer = customer9 };



            await _bicycleRepository.AddAsync(Bicycle1);
            await _bicycleRepository.AddAsync(Bicycle2);
            await _bicycleRepository.AddAsync(Bicycle3);
            await _bicycleRepository.AddAsync(Bicycle4);
            await _bicycleRepository.AddAsync(Bicycle5);
            await _bicycleRepository.AddAsync(Bicycle6);
            await _bicycleRepository.AddAsync(Bicycle7);
            await _bicycleRepository.AddAsync(Bicycle8);
            await _bicycleRepository.AddAsync(Bicycle9);

            await _customerRepository.AddAsync(customer1);
            await _customerRepository.AddAsync(customer2);
            await _customerRepository.AddAsync(customer3);
            await _customerRepository.AddAsync(customer4);
            await _customerRepository.AddAsync(customer5);
            await _customerRepository.AddAsync(customer6);
            await _customerRepository.AddAsync(customer7);
            await _customerRepository.AddAsync(customer8);
            await _customerRepository.AddAsync(customer9);

            await _orderRepository.AddAsync(order1);
            await _orderRepository.AddAsync(order2);
            await _orderRepository.AddAsync(order3);
            await _orderRepository.AddAsync(order4);
            await _orderRepository.AddAsync(order5);
            await _orderRepository.AddAsync(order6);
            await _orderRepository.AddAsync(order7);
            await _orderRepository.AddAsync(order8);
            await _orderRepository.AddAsync(order9);

            await _addressRepository.AddAsync(address1);
            await _addressRepository.AddAsync(address2);
            await _addressRepository.AddAsync(address3);
            await _addressRepository.AddAsync(address4);
            await _addressRepository.AddAsync(address5);
            await _addressRepository.AddAsync(address6);
            await _addressRepository.AddAsync(address7);
            await _addressRepository.AddAsync(address8);
            await _addressRepository.AddAsync(address9);






            var returnOk = new CreateSeedCommandResponse();

            return returnOk;

        }
        
    }
}

