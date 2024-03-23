using System.ComponentModel.DataAnnotations;

namespace Project.Domail.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; private set; }
        public BaseEntity() 
        {
            UpdateDate = DateTime.Now;
        }
    }
}
