using System;
using System.Linq;

namespace Nop.Plugin.Misc.Invoice.Models
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {

            CreateMap<Domain.InvoiceSell, Models.InvoiceSell>();
            CreateMap<Models.InvoiceSell, Domain.InvoiceSell>();
            CreateMap<Domain.InvoiceSellUnit, Models.InvoiceSellIUnit>();
            CreateMap<Models.InvoiceSellIUnit, Domain.InvoiceSellUnit>();
        }
    }
}
