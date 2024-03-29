using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace learn_azd
{
    public class c5mTest
    {
        private readonly ILogger _logger;

        public c5mTest(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<c5mTest>();
        }

        [Function("c5mTest")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "api/c5mTest")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Bonjour Hi from Behind my cloud!");

            return response;
        }

    }
}
