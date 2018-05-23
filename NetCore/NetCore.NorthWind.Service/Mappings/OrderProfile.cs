using AutoMapper;
using NetCore.NorthWind.Repository;
using System;

namespace NetCore.NorthWind.Service
{
    public class OrderProfile : Profile
    {
        public OrderProfile(){
            CreateMap<Orders, OrderListItemViewModel>()            
            .ForMember(x => x.CustomerName, y => y.MapFrom(z => z.Customer.CompanyName))
            .ForMember(x => x.OrderDate, y => y.MapFrom(z => z.OrderDate ?? DateTime.Now))
            .ForMember(x => x.RequireDate, y => y.MapFrom(z => z.RequiredDate ?? DateTime.Now))
            .ForMember(x => x.Shipper, y => y.MapFrom(z => z.ShipViaNavigation.CompanyName));
        }
    }
}