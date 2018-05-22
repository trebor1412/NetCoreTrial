using System.Collections.Generic;

namespace NetCore.NorthWind.Service.ViewModels
{
    public class OrderListViewModel
    {
        public List<OrderListItemViewModel> Orders { get; set; }
    }
}