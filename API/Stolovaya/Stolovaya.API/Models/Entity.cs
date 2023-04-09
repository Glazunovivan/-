using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stolovaya.API.Models
{
    public abstract class Entity
    {
        [Key]
        [Column("id")]
        public Guid Identity { get; set; }
    }
}
