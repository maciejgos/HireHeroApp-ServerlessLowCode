using HireHero.Shared.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HireHero.Shared.Interfaces
{
    [Headers("Ocp-Apim-Subscription-Key: 53ab7699b93741139e8bc2a6831b1129")]
    public interface IHireHeroApi
    {
        [Post("/offers/request")]
        Task SubmitRequest([Body] OfferRequest request);

        [Get("/offers/requests")]
        Task<IEnumerable<Request>> GetRequests();

        [Get("/offers/requests/{id}")]
        Task<Request> GetRequest(Guid id);

        [Post("/offers/proposal")]
        Task ProposeOffer([Body] OfferPropose propose);

        [Post("/offers/refuse")]
        Task RefuseOffer([Body]OfferRefuse offerRefuse);

        [Post("/invoices/payment")]
        Task InvoicePayment([Body] Payment payment);
    }
}
