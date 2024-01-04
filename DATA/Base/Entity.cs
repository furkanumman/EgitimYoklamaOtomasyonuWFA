using DATA.Interface;
using System.ComponentModel.DataAnnotations;

namespace DATA.Base
{
    public abstract class Entity
    {

    }
    public class Entity<T> : Entity, IActive
    {
        [Key]
        public T ID { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
