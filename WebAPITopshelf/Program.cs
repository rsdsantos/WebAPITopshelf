using Topshelf;
using WebAPITopshelf.Configuration;

namespace WebAPITopshelf
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<OwinService>(s =>
                {
                    s.ConstructUsing(() => new OwinService());
                    s.WhenStarted(service => service.Start());
                    s.WhenStopped(service => service.Stop());
                });

                x.RunAsLocalSystem();
                x.StartAutomatically();

                x.SetDescription("Serviço de testes do Web API Self-Host com Topshelf.");
                x.SetDisplayName("WebAPISelfHost");
                x.SetServiceName("WebAPISelfHost");
            });
        }
    }
}
