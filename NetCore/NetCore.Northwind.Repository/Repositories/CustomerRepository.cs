using NetCore.Repository;

namespace NetCore.NorthWind.Repository
{
    public class CustomerRepository : RepositoryBase<NorthWindContext, Customers>, ICustomerRepository
    {
        public CustomerRepository(NorthWindContext context):base(context)
        {

        }
    }
}