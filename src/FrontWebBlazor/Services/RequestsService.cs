using Ardalis.GuardClauses;
using FrontWebBlazor.Interfaces;
using FrontWebBlazor.Models;
using Refit;
using System.Threading.Tasks;

namespace FrontWebBlazor.Services
{
    public class RequestsService
    {
        const string BaseUri = "https://heroapp-apim.azure-api.net/api";
        
        private readonly IHireHeroApi _heroApi;

        public RequestsService()
        {
            _heroApi = RestService.For<IHireHeroApi>(BaseUri);
        }

        public async Task SubmitRequest(HeroRequest request)
        {
            Guard.Against.Null(request, nameof(request));
            await _heroApi.SubmitRequest(request);
        }
    }
}
