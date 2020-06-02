using BackofficeWebBlazor.Interfaces;
using BackofficeWebBlazor.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackofficeWebBlazor.Services
{
    public class RequestsService
    {
        const string BaseUri = "https://heroapp-apim.azure-api.net/api";

        private readonly IHireHeroApi _heroApi;

        public RequestsService()
        {
            _heroApi = RestService.For<IHireHeroApi>(BaseUri);
        }

        public async Task<IEnumerable<HeroRequest>> GetRequests()
        {
            return await _heroApi.GetRequests();
        }
    }
}
