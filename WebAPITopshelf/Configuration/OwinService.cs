using Microsoft.Owin.Hosting;
using System;

namespace WebAPITopshelf.Configuration
{
    public class OwinService
    {
        private IDisposable _webApp;

        public void Start()
        {
            _webApp = WebApp.Start<ApiConfiguration>("http://+:9000");
        }

        public void Stop()
        {
            _webApp.Dispose();
        }
    }
}
