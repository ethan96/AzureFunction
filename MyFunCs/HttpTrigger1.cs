using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace Company.Function
{
    public class HttpTrigger1
    {
        private readonly ILogger _logger;

        public HttpTrigger1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HttpTrigger1>();
        }

        [Function("HttpTrigger1")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            StreamReader reader = new StreamReader(req.Body);
            string text = reader.ReadToEnd();

            JObject jo = JObject.Parse(text);
            string name = jo["name"].Value<string>() ?? string.Empty;
            int id = jo["id"].Value<int>();

            response.WriteString($"Welcome {name} to Azure Functions!");
            response.WriteString($"Id: {id}");
            return response;
        }
    }
}
