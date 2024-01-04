using DATA.Base;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Base
{
    public class BaseRepository<TEntity, TKey> where TEntity : Entity<TKey> // 
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository()
        {
            _context = new AppDbContext();
            _dbSet = _context.Set<TEntity>();
        }

        public virtual TEntity Insert(TEntity entity)
        {
            _ = _dbSet.Add(entity);
            _ = _context.SaveChanges();
            return entity;
        }

        public virtual TEntity Delete(TEntity entity)
        {
            TEntity? resultEntity = _dbSet.Find(entity.ID);
            if (resultEntity == null)
                throw new Exception("Kayıt bulunamadı!");
            resultEntity.IsActive = false;
            _context.SaveChanges();
            return resultEntity;
        }

        public virtual TEntity GetByID(TEntity entity)
        {
            TEntity? result = _dbSet.Find(entity.ID);
            return result;
        }

        public virtual List<TEntity> GetAll()
        {
            List<TEntity>? list = _dbSet.ToList();
            return list;
        }

        public virtual List<TEntity> Where(Func<TEntity, bool> filter)
        {
            List<TEntity> list = _dbSet.Where(filter).ToList();
            return list;
        }

        public bool CheckControl(Func<TEntity, bool> filter)
        {
            List<TEntity> list = _dbSet.Where(filter).ToList();
            if(list.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}

