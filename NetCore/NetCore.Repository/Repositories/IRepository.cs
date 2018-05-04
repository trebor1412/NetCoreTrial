using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace NetCore.Repository {
    public interface IRepository<TDbContext, TModel> where TModel : class, new () where TDbContext : DbContext {
        IQueryable<TModel> GetAll ();
        void Add (TModel model);
        void Add (IEnumerable<TModel> models);
        void Delete (TModel model);
        void Delete (IEnumerable<TModel> models);        
        void Update (TModel model);
    }
}