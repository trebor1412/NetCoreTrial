using NetCore.Repository;

namespace NetCore.NorthWind.Repository
{
    public interface INorthWindRepositoryBase<TModel>: IRepository<NorthWindContext, TModel> where TModel : class, new ()
    {
        
    }
}