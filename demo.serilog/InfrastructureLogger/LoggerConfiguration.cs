using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;


namespace InfrastructureLogger
{
    public static class LoggerConfiguration
    {
		public static ILoggerFactory AddLoggerFactory(this ILoggerFactory loggerFactory)
		{
			loggerFactory.AddSerilog();

			return loggerFactory;
		}

		/// <summary>
		/// CreateLogger
		/// </summary>
		/// <param name="configuration"></param>
		public static void CreateLogger(this IConfiguration configuration)
		{
			Log.Logger = new Serilog.LoggerConfiguration()
				.ReadFrom.Configuration(configuration)
				.CreateLogger();
		}
	}
}
