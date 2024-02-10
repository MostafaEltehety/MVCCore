using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCoreAlmohamdy.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Item>? Items { get; set; }
        public byte[]? CatImage { get; set; }
        [NotMapped]
        public IFormFile? FormFile { get; set; }
        [NotMapped]
        public string? ImgStr
        {
            get
            {
                if (CatImage != null)
                {
                    string base64Img = Convert.ToBase64String(CatImage, 0, CatImage.Length);
                    return "data:image/jpg;base64," + base64Img;
                }
                return string.Empty;
            }
        }
    }
}