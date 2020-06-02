using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BackofficeApp
{
    public class GetHeroRequestsFunction
    {
        [FunctionName("GetHeroRequests")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "requests")] HttpRequest req,
            [CosmosDB(databaseName:"heroapp-db",
            collectionName:"requests",
            ConnectionStringSetting = "heroapp-cosmosdb_DOCUMENTDB",
            SqlQuery = "SELECT * FROM c")]IEnumerable<Request> requests,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            log.LogDebug($"Results from Cosmos DB: {JsonConvert.SerializeObject(requests)}");

            return new OkObjectResult(JsonConvert.SerializeObject(requests));
        }
    }

    public class Request
    {
        public string Id { get; set; }
        public string[] Powers { get; set; }
    }
}
