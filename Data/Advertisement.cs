using System.ComponentModel.DataAnnotations;

namespace Otthonbazar.Data
{
    public class Advertisement
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A cím mező kitöltése kötelező.")]
        [Display(Name = "Cím")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Az építés éve mező kitöltése kötelező.")]
        [Display(Name = "Építés éve")]
        public int BuildDate { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "A fél szobák száma mező kitöltése kötelező.")]
        [Display(Name = "Fél szobák száma")]
        public int HalfRoom { get; set; }

        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Az ár mező kitöltése kötelező.")]
        [Display(Name = "Ár")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "A szobák száma mező kitöltése kötelező.")]
        [Display(Name = "Szobák száma")]
        public int Room { get; set; }

        [Required(ErrorMessage = "A méret mező kitöltése kötelező.")]
        [Display(Name = "Méret")]
        public int Size { get; set; }

        [Required(ErrorMessage = "A típus mező kitöltése kötelező.")]
        [Display(Name = "Típus")]
        public AdvertisementType AdvertisementType { get; set; }

        [Required(ErrorMessage = "A város mező kitöltése kötelező.")]
        public int CityId { get; set; }

        public City City { get; set; }
    }
}
