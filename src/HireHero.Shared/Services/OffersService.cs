using Ardalis.GuardClauses;
using HireHero.Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HireHero.Shared.Services
{
    public class OffersService : BaseService
    {
        public async Task SubmitRequest(OfferRequest request)
        {
            Guard.Against.Null(request, nameof(request));
            await _heroApi.SubmitRequest(request);
        }

        public async Task<IEnumerable<Request>> GetRequests() => await _heroApi.GetRequests();

        public async Task<Request> GetRequest(Guid id) => await _heroApi.GetRequest(id);

        public async Task ProposeOffer(OfferPropose offer)
        {
            Guard.Against.Null(offer, nameof(offer));
            await _heroApi.ProposeOffer(offer);
        }

        public async Task RefuseOffer(OfferRefuse refuse)
        {
            Guard.Against.Null(refuse, nameof(refuse));
            await _heroApi.RefuseOffer(refuse);
        }
    }
}
