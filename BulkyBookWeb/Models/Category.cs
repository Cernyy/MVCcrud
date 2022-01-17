using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Display(Name ="Display Order")]
        public int DisplayOrder { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
