using System;

namespace HireHero.Shared.Models
{
    public class OfferPropose
    {
        public string OfferId { get; private set; }
        public string Email { get; private set; }
        public Hero Hero { get; set; }

        public OfferPropose()
        {
            Hero = new Hero();
        }

        public void SetOfferId(string offerId)
        {
            OfferId = offerId;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}
