using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace NetCore.Repository {
    public abstract class RepositoryBase<TDbContext, TModel> : IRepository<TDbContext, TModel> where TModel : class, new () where TDbContext : DbContext {
        protected DbSet<TModel> _dbSet;
        protected DbContext _context;

        private void SaveChanges () {
            _context?.SaveChanges ();
        }

        public RepositoryBase (TDbContext context) {
            _context = context;
            _dbSet = _context.Set<TModel> ();
        }

        public IQueryable<TModel> GetAll () {
            return _dbSet;
        }

        public void Add (TModel model) {
            _dbSet?.Add (model);
            SaveChanges ();
        }

        public void Add (IEnumerable<TModel> models) {
            _dbSet.AddRange (models);
            SaveChanges ();
        }

        public void Delete (TModel model) {
            _context.Entry (model).State = EntityState.Deleted;
            SaveChanges ();
        }

        public void Delete (IEnumerable<TModel> models) {
            _dbSet.RemoveRange (models);
            SaveChanges ();
        }

        public void Update (TModel model) {
            _context.Entry (model).State = EntityState.Modified;
            SaveChanges ();
        }
    }
}