using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCoreAlmohamdy.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(1, 1000000)]
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Display(Name = "Category")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? ImgPath { get; set; }
        [NotMapped]
        public IFormFile? FormFile { get; set; }

    }
}
