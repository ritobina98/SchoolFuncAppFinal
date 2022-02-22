using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SchoolFunctionApp.Services;

namespace SchoolFunctionApp
{
    public class UpdateData
    {
        private readonly ISchoolService _schoolService;

        public UpdateData(ISchoolService schoolService)
        {
            _schoolService = schoolService;

        }
        [FunctionName("UpdateData")]
        public void Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            int courseId = Convert.ToInt32(req.Query["courseId"]);
            int studentId = Convert.ToInt32(req.Query["studentId"]);
            _schoolService.ProcessRequest(courseId, studentId);

        

            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            //string responseMessage = string.IsNullOrEmpty(name)
            //    ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
            //    : $"Hello, {name}. This HTTP triggered function executed successfully.";

            // return new OkObjectResult(responseMessage);
           // return null;
        }
    }
}
