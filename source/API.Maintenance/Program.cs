namespace API.Maintenance
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;
    using NServiceBus;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseNServiceBus(_ =>
                {
                    var endpoint = new EndpointConfiguration("maintenance");
                    endpoint.EnableInstallers();
                    var transport = endpoint.UseTransport<AzureServiceBusTransport>();
                    transport.TopicName("main");
                    transport.ConnectionString("Endpoint=sb://paser-ariways.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=m0UTMqWLNA40EJTOJPBN0r22bZdKKqhlQjS5XhblHIs=");
                    return endpoint;
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
