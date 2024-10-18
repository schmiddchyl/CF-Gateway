using CF_MCA_MESSAGE_Marshaller;
using Microsoft.AspNetCore.Mvc;

namespace CF_Gateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CFRequestRouter : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CFRequestRouter> _logger;

        public CFRequestRouter(ILogger<CFRequestRouter> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetConnectFromWebSocket")]
        public void Connect()
        {
                // to be determined handle Connect from AWS API gateway
        }

        [HttpGet(Name = "GetDisconnectConnectFromWebSocket")]
        public void GetDisconnect()
        {
            // to be determined handle DisConnect from AWS API gateway
        }


        [HttpPost(Name = "GetDisconnectConnectFromWebSocket")]
        public void ReceiveMessage()
        {
            // handles the receivemessage channel
            //
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
    }
}
