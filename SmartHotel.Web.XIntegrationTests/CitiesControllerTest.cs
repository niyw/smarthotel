using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SmartHotel.Web.Data;
using SmartHotel.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace SmartHotel.Web.XIntegrationTests
{
    public class CitiesControllerTest
    {
        [Fact]
        public async Task TestGetMemberPhoneById()
        {
            var builder = WebHost.CreateDefaultBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>();
            using (var server = new TestServer(builder))
            {
                using (var scope = server.Services.CreateScope())
                {
                    var db = scope.ServiceProvider.GetService<SmartHotelWebContext>();
                    SmartHotelWebContextSeed.Seed(db);
                }
                var httpClient = server.CreateClient();
                var response = await httpClient.GetAsync("/api/cities/1");
                response.EnsureSuccessStatusCode();
                var jsonStr = await response.Content.ReadAsStringAsync();
                var city = JsonConvert.DeserializeObject<City>(jsonStr);
                Assert.Equal("beijing",city.Name,ignoreCase:true);

            }
        }
        [Fact]
        public async Task TestGetAllMemberPhone()
        {
            var builder = WebHost.CreateDefaultBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>();
            using (var server = new TestServer(builder))
            {
                using (var scope = server.Services.CreateScope()) {
                    var db = scope.ServiceProvider.GetService<SmartHotelWebContext>();
                    SmartHotelWebContextSeed.Seed(db);
                }
                var httpClient = server.CreateClient();
                var response = await httpClient.GetAsync("/api/cities");
                response.EnsureSuccessStatusCode();
                var jsonStr = await response.Content.ReadAsStringAsync();
                var cityList = JsonConvert.DeserializeObject<List<City>>(jsonStr);
                Assert.NotNull(cityList);
            }
        }
    }
}
