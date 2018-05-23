using System.Collections.Generic;

namespace NetCore.Core
{
    public class DropdownListViewModel
    {
        public List<DropdownListItemViewModel> Items { get; set; }

        public string Title { get; set; }
    }
}