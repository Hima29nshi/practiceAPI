using Microsoft.AspNetCore.Mvc;

namespace practiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        [Route("PostFile")]
        public IActionResult GetFile(IFormFile file)
        {
            var obj = new
            {
                DocumentID = "DOC1231232CA",
                FileName = "asdagd.zip",
                Status = "success",
                message = "File Uploaded Successfully"
            };

            Request.Headers.TryGetValue("key1", out var hi);
            Request.Headers.TryGetValue("Authorization", out var token);

            return Ok(obj);
            //var keyValuePairs = new Dictionary<string, string>();
            //keyValuePairs.Add("surname","bhangre");
            //WeatherForecast obj = new WeatherForecast
            //{
            //    Date = DateTime.Now,
            //    TemperatureC = Random.Shared.Next(),
            //    keyValuePairs = keyValuePairs
            //};
        }

        [HttpPost]
        [Route("PostFileToVendor")]
        public IActionResult GetFileFromDms(IFormFile file)
        {
            var obj = new
            {
                Id = 761276712,
                Data = new[]
                {
                    new
                    {
                        page_no = 0,
                        range = "",
                        result = "21",
                        test_analytics = "",
                        test_name = "No of Employees (at policy inception)",
                        unit = ""
                    },
                    new
                    {
                        page_no = 0,
                        range = "",
                        result = "21",
                        test_analytics = "",
                        test_name = "Total lives (Emp + Dep at policy inception)",
                        unit = ""
                    },
                    new
                    {
                        page_no = 0,
                        range = "",
                        result = "127,351",
                        test_analytics = "",
                        test_name = "Premium Paid at Inception (Excluding GST)",
                        unit = ""
                    }
                }
            };

            Request.Headers.TryGetValue("key1", out var hi);
            Request.Headers.TryGetValue("Authorization", out var token);

            return Ok(obj);
            //var keyValuePairs = new Dictionary<string, string>();
            //keyValuePairs.Add("surname","bhangre");
            //WeatherForecast obj = new WeatherForecast
            //{
            //    Date = DateTime.Now,
            //    TemperatureC = Random.Shared.Next(),
            //    keyValuePairs = keyValuePairs
            //};
        }
    }
}