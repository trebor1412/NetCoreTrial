using System;
namespace NetCore.NorthWind.Service {
    public class OrderListItemViewModel {
        public int OrderId { get; set; }

        public string CustomerId { get; set; }

        public string CustomerName { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequireDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public string Shipper { get; set; }

        public string OrderedDate {
            get {
                return OrderDate.ToString ("yyyy/MM/dd");
            }
        }

        public string RequiredShipDate {
            get {
                return RequireDate.ToString ("yyyy/MM/dd");
            }
        }

        public string DepartureShipDate {
            get {
                return ShippedDate?.ToString ("yyyy/MM/dd") ?? string.Empty;
            }
        }
    }
}