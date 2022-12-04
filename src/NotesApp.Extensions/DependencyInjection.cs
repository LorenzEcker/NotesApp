using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using NotesApp.Data;
using NotesApp.Service;

namespace NotesApp.Extensions
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInMemoryNotesDb(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddSingleton<INotesDb, NotesDb>();
			return serviceCollection;
		}

		public static IServiceCollection AddNotesAppServices(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddScoped<IWeatherForecastService, WeatherForecastService>();
			serviceCollection.AddScoped<INotesService, NotesService>();
			return serviceCollection;
		}
	}
}
