using HireHero.Shared.Interfaces;
using Refit;

namespace HireHero.Shared.Services
{
    public abstract class BaseService
    {
        private const string HostUrl = "https://heroapp-apim.azure-api.net/api";
        protected readonly IHireHeroApi _heroApi;

        public BaseService()
        {
            _heroApi = RestService.For<IHireHeroApi>(HostUrl);
        }
    }
}