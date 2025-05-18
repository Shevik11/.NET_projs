using System.ComponentModel.DataAnnotations;

namespace Proj.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayedOrder { get; set; }
    }
}
