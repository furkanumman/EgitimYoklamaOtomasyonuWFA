using DATA.Base;

namespace BLL.Interfaces.Base
{
    public interface IBaseService<TEntity, TKey> where TEntity : Entity<TKey>
    {

        public TEntity Insert(TEntity entity);

        public void Update(TEntity entity);

        public TEntity Delete(TEntity entity);

        public TEntity GetByID(TEntity entity);

        public List<TEntity> GetAll();

        public List<TEntity> Where(Func<TEntity, bool> filter);

        public bool CheckControl(Func<TEntity, bool> filter);

    }
}
