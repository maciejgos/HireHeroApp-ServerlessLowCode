using FrontWebBlazor.Models;
using Refit;
using System.Threading.Tasks;

namespace FrontWebBlazor.Interfaces
{
    [Headers("Ocp-Apim-Subscription-Key: 53ab7699b93741139e8bc2a6831b1129")]
    public interface IHireHeroApi
    {
        [Post("/hero/request")]
        Task SubmitRequest([Body]HeroRequest request);
    }
}
