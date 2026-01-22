namespace BackEndAwsome
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class CloudShape
    {
        public string? Summary { get; set; }
    }

    public class SunHours
    {
        public int? Summary { get; set; }
    }

    public class Outfit
    {
        public string? Summary { get; set; }
    }
}
