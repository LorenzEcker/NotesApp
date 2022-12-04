using NotesApp.Domain;

namespace NotesApp.Service
{
	public interface IWeatherForecastService
	{
		Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
	}
}