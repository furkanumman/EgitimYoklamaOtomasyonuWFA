using DAL;
using DATA;
using DATA.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces.Base
{
    public interface IUserBaseService<TEntity, TKey> where TEntity : Entity<TKey>
    {
        public TEntity GetByEmailAddress(string emailAddress);

        public List<TEntity> GetByNameSurname(string nameSurname);
    }
}
