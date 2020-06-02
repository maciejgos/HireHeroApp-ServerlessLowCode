using System.ComponentModel.DataAnnotations;

namespace FrontWebBlazor.Models
{
    public class HeroRequest
    {
        [Required]
        public string Powers { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
