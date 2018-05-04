using NetCore.Repository;

namespace NetCore.NorthWind.Repository
{
    public interface ICustomerRepository: IRepository<NorthWindContext, Customers>
    {
        
    }
}