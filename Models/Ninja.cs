using System.ComponentModel.DataAnnotations;
namespace MvcDojSurv
{

    public class Ninja
    {

        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string Language { get; set; }
        [MinLength(3)]
        [MaxLength(30)]
        public string Comment { get; set; }
    }
}