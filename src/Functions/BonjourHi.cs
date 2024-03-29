using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace learn_azd
{
    public class BonjourHi
    {
        private readonly ILogger _logger;

        public BonjourHi(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<BonjourHi>();
        }

        [Function("BonjourHi")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "{person}")] HttpRequestData req, string person)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
            string responseMsg = string.Empty;

            if (string.IsNullOrWhiteSpace(person))
            {
                responseMsg = $"Bonjour Hi 'you' from Behind my cloud!";
            }
            else{
                responseMsg = $"Bonjour Hi {person} from Behind my cloud!";
            }

            response.WriteString(responseMsg);

            return response;
        }
    }
}
