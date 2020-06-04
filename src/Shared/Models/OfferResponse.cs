namespace HireHero.Shared.Models
{
    public class OfferResponse
    {
        public string Id { get; set; }
        public OfferStatus Status { get; set; }
        public Hero Hero { get; set; }
    }

    public enum OfferStatus
    {
        Paid, NotPaid, Refused
    }
}