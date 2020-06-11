namespace HireHero.Shared.Models
{
    public class OfferRefuse
    {
        public string OfferId { get; set; }
        public ProposalStatus Status { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
    }
}
