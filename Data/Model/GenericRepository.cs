using System.Linq.Expressions;
using API_Restaurant.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API_Restaurant.Data.Model
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        T Get(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetMany(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private AppDbContext _appDbContext;
        private DbSet<T> _dbSet;

        public GenericRepository(AppDbContext _context)
        {
            _appDbContext = _context;
            _dbSet = _context.Set<T>();
        }
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _appDbContext.SaveChanges();
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<T> GetMany(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Save()
        {
            _appDbContext?.SaveChanges();
        }

        public void Update(T entity)
        {
            _appDbContext.Entry(entity).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }
    }

}
