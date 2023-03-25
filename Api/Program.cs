using Microsoft.Extensions.Hosting;

namespace McNasGlass.Api;

public class Program
{
	public static void Main()
	{
		IHost host = new HostBuilder()
			.ConfigureFunctionsWorkerDefaults()
			.Build();

		host.Run();
	}
}