using Microsoft.AspNetCore.Mvc;

namespace vo2webapi.Controllers
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
        private vo2context _companyContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, vo2context companyContext)
        {
            _logger = logger;
            _companyContext = companyContext;
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

        //[Route("GetActors")]
        //public IEnumerable<tblActors> GetActors()
        //{
        //    return _companyContext.tblActors.ToList();
        //}

        //[Route("GetActorsFees")]
        //public IEnumerable<tblMovies> GetActorsFees()
        //{
        //    return _companyContext.tblMovies.ToList();
        //}

        //[Route("GetActorsFeesCondition")]
        //public IEnumerable<tblActors> GetActorsFeesCondition()
        //{
        //    return _companyContext.tblActors.ToList();
        //}
    }
}