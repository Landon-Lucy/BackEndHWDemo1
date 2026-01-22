using Microsoft.AspNetCore.Mvc;

namespace BackEndAwsome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }


    [ApiController]
    [Route("[controller]")]
    public class CloudShapeController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Duck", "Blob", "Spiky", "Streak", "Ball", "Dog", "Monkey", "Banana", "Dragon", "Smiley Face"
        ];

        [HttpGet(Name = "GetCloudShape")]
        public IEnumerable<CloudShape> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new CloudShape
            {
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class SunHoursController : ControllerBase
    {
        private static readonly int[] sunHoursValues =
        [
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
        ];
        [HttpGet(Name = "GetSunHours")]
        public IEnumerable<SunHours> Get()
        {
            return Enumerable.Range(1, 1).Select(index => new SunHours
            {
                Summary = sunHoursValues[Random.Shared.Next(sunHoursValues.Length)]
            })
            .ToArray();
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class OutfitController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Sunhat", "Parasol", "Jeans", "Shorts", "Sweats", "Baseball Cap", "TShirt", "Hoodie", "Tank Top", "Winter Coat"
        ];

        [HttpGet(Name = "GetOutfit")]
        public IEnumerable<Outfit> Get()
        {
            return Enumerable.Range(1, 7).Select(index => new Outfit
            {
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
