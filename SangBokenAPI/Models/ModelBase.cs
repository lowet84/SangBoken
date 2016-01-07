using System.ComponentModel.DataAnnotations;

namespace SangBokenAPI.Models
{
    public abstract class ModelBase
    {
        [Key]
        public int Key { get; set; }

        public virtual void Update(object newObject)
        {
        }
    }
}
