using System.ComponentModel.DataAnnotations;

namespace CrudApi.Entity
{
    public class Product : Entity
    {
        [Required, MaxLength(150)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }

    }
}
