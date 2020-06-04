﻿using HireHero.Shared.Models;
using Refit;
using System.Threading.Tasks;

namespace HireHero.Shared.Interfaces
{
    [Headers("Ocp-Apim-Subscription-Key: 53ab7699b93741139e8bc2a6831b1129")]
    public interface IHireHeroApi
    {
        [Post("/offers/request")]
        Task SubmitRequest([Body] OfferRequest request);
    }
}
