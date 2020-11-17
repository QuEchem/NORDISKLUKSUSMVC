using System.ComponentModel.DataAnnotations;

namespace NordiskLuksusMVC.Models
{
    public class Mat
    {
        [Key]
        public int MatId { get; set; }


        [Required(ErrorMessage = "Fyll inn Navn")]
        public string Name { get; set; }

        public string ImgSrc { get; set; }
    }
}