using System.ComponentModel.DataAnnotations;

namespace HireHero.Shared.Models
{
    public class OfferRequest
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
