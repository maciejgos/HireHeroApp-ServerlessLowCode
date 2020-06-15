using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HireHero.FunctionApp
{
    public class GetHeroRequestFunction
    {
        [FunctionName("GetHeroRequestFunction")]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "offers/requests/{id}")] HttpRequest req,
            [CosmosDB(databaseName:"heroapp-db",
            collectionName:"requests",
            ConnectionStringSetting = "heroapp-cosmosdb_DOCUMENTDB",
            Id = "{id}",
            PartitionKey = "{id}")]Request request,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            log.LogDebug($"Results from Cosmos DB: {JsonConvert.SerializeObject(request)}");

            return new OkObjectResult(JsonConvert.SerializeObject(request));
        }
    }
}
