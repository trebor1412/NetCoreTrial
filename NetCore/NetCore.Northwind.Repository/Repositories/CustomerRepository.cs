using NetCore.Repository;

namespace NetCore.NorthWind.Repository
{
    public class CustomerRepository : NorthWindRepositoryBase<Customers>, ICustomerRepository
    {
        public CustomerRepository(NorthWindContext context):base(context)
        {

        }
    }
}