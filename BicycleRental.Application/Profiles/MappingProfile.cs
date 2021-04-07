using AutoMapper;
using BicycleRental.Application.Features.Addresses.Commands.CreateAddress;
using BicycleRental.Application.Features.Addresses.Commands.UpdateAddress;
using BicycleRental.Application.Features.Addresses.Queries.GetAddressDetail;
using BicycleRental.Application.Features.Addresses.Queries.GetAddressList;
using BicycleRental.Application.Features.Bicycles.Commands.CreateBicycle;
using BicycleRental.Application.Features.Bicycles.Commands.UpdateBicycle;
using BicycleRental.Application.Features.Bicycles.Queries.GetBicycleDetail;
using BicycleRental.Application.Features.Bicycles.Queries.GetBicycleList;
using BicycleRental.Application.Features.Customers.Commands.CreateCustomer;
using BicycleRental.Application.Features.Customers.Commands.UpdateCustomer;
using BicycleRental.Application.Features.Customers.Queries.GetCustomerDetail;
using BicycleRental.Application.Features.Customers.Queries.GetCustomersList;
using BicycleRental.Application.Features.Orders.Commands.CreateOrder;
using BicycleRental.Application.Features.Orders.Commands.UpdateOrder;
using BicycleRental.Application.Features.Orders.Queries.GetOrderDetail;
using BicycleRental.Application.Features.Orders.Queries.GetOrdersList;
using BicycleRental.Domain.Entities;
using System.Collections.Generic;

namespace BicycleRental.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to ViewmodelList
            CreateMap<Address, AddressListVm>();
            CreateMap<Bicycle, BicycleListVm>().ReverseMap();
            CreateMap<Customer, CustomerListVm>();
            CreateMap<Order, OrdersListVm>();

            //Domain to ViewmodelDetail
            CreateMap<Address, AddressDetailVm>();
            CreateMap<Bicycle, BicycleDetailVm>();
            CreateMap<Customer, CustomerDetailVm>();
            CreateMap<Address, CustomerDetailVm>();
            CreateMap<Order, OrderDetailVm>();


            //Domain to Dto
            
            CreateMap<Bicycle, BicycleDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<Order, OrderDto>();

            //Viewmodel to ListViewmodel
            CreateMap<AddressDetailVm, IEnumerable<AddressDetailVm>>();

            //Domain to ListViewmodel
            CreateMap<Address, IEnumerable<AddressDetailVm>>();


            //Domain to CreateDto
            CreateMap<Address, CreateAddressDto>();
            CreateMap<Bicycle, CreateBicycleDto>();
            CreateMap<Customer, CreateCustomerDto>();
            CreateMap<Order, CreateOrderDto>();
            
            

            //Domain to Command
            CreateMap<Address, CreateAddressCommand>();
            CreateMap<Address, UpdateAddressCommand>();
            CreateMap<Bicycle, CreateBicycleCommand>();
            CreateMap<Bicycle, UpdateBicycleCommand>();
            CreateMap<Customer, CreateCustomerCommand>();
            CreateMap<Customer, UpdateCustomerCommand>();
            CreateMap<Order, CreateOrderCommand>();
            CreateMap<Order, UpdateOrderCommand>();


            //Domain to Response
            CreateMap<Address, CreateAddressCommandResponse>();
            CreateMap<Bicycle, CreateBicycleCommandResponse>();
            CreateMap<Customer, CreateCustomerCommandResponse>();
            CreateMap<Order, CreateOrderCommandResponse>();


        }
    }
}
