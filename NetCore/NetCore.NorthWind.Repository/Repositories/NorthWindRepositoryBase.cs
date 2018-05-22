using NetCore.Repository;

namespace NetCore.NorthWind.Repository
{
    public abstract class NorthWindRepositoryBase<TModel>: RepositoryBase<NorthWindContext, TModel>, INorthWindRepositoryBase<TModel> where TModel : class, new ()
    {
        public NorthWindRepositoryBase(NorthWindContext context):base(context)
        {

        }
    }
}