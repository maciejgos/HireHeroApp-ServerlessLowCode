using Ardalis.GuardClauses;
using HireHero.Shared.Models;
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
    }
}
