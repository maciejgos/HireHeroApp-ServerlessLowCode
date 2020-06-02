using BackofficeWebBlazor.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackofficeWebBlazor.Interfaces
{
    [Headers("Ocp-Apim-Subscription-Key: 53ab7699b93741139e8bc2a6831b1129")]
    public interface IHireHeroApi
    {
        [Get("/requests")]
        Task<IEnumerable<HeroRequest>> GetRequests();
    }
}
