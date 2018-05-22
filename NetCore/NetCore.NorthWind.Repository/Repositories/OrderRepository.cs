using NetCore.Repository;
using System.Linq;

namespace NetCore.NorthWind.Repository {

    public class OrderRepository : NorthWindRepositoryBase<Orders>, IOrderRepository {
        public OrderRepository (NorthWindContext context) : base (context) {

        }

        public IQueryable<Orders> GetOrderListByCustomer(string customerID){
            return GetAll().Where(x => x.CustomerId == customerID);
        }

        public IQueryable<Orders> GetOrderListByShipCountry(string shipCountry){
            return GetAll().Where(x => x.ShipCountry == shipCountry);
        }
    }
}