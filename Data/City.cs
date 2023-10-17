using System.ComponentModel.DataAnnotations;

namespace Otthonbazar.Data
{
    public class City
    {
        public int Id { get; set; }
        [Required, StringLength(4, MinimumLength = 4)]
        [Display(Name = "Irányítószám")]
        public string Zip { get; set; }
        [Required]
        [Display(Name = "Város")]
        public string Name { get; set; }
        public ICollection<Advertisement>? Advertisements { get; set; }
    }
}
