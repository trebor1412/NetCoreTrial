using System.Linq;
using System.Collections.Generic;
using NetCore.Core;

namespace NetCore.NorthWind.Service {
    public class OrderListViewModel {
        public List<OrderListItemViewModel> Orders { get; set; }

        public TimeIntervalFilterEnum TimeInterval { get; set; } = TimeIntervalFilterEnum.ThisMonth;

        public DropdownListViewModel Dropdown {
            get {
                var dropdown = new DropdownListViewModel {
                    Title = TimeInterval.ToString (),                    
                    Items = EnumHelper.GetList<TimeIntervalFilterEnum>()
                                      .Select(x => new DropdownListItemViewModel
                                      {
                                         Title = x.ToString(),
                                          Link = $"order?interval={x}"
                                      })
                                      .ToList()
                };
    
                return dropdown;
            }
        }
    }
}