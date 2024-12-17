using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace SelectHealth.CmExportApi
{
    public class HttpTrigger
    {
        private readonly ILogger<HttpTrigger> _logger;

        public HttpTrigger(ILogger<HttpTrigger> logger)
        {
            _logger = logger;
        }

        [Function("HttpTrigger")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "hello/world")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}