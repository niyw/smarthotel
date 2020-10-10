using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using SmartHotel.Web.Data;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SmartHotel.Web.XIntegrationTests
{
    public class TestServerFixture : IDisposable
    {
        private readonly TestServer testServer;
        public HttpClient httpClient;
        public TestServerFixture() {
            var builder = WebHost.CreateDefaultBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>();
            testServer = new TestServer(builder);
            using (var scope = testServer.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetService<SmartHotelWebContext>();
                SmartHotelWebContextSeed.Seed(db);
            }

            httpClient = testServer.CreateClient();
        }
        public void Dispose()
        {
            httpClient.Dispose();
            testServer.Dispose();
        }
    }
}
