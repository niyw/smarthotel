using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SmartHotel.Web.Data;
using SmartHotel.Web.Models;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace SmartHotel.Web.XIntegrationTests
{
    /*
  public  class HotelsControllerTest:IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly HttpClient _httpClient;
        public HotelsControllerTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _httpClient = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            }); ;
        }
        [Fact]
        public async Task TestGetAllMemberPhone()
        {
            var response = await _httpClient.GetAsync("/api/cities");
            response.EnsureSuccessStatusCode();
            var jsonStr = await response.Content.ReadAsStringAsync();
            var cityList = JsonConvert.DeserializeObject<List<City>>(jsonStr);
            Assert.NotNull(cityList);
        }
    }
    */
    public class HotelsControllerTest : IClassFixture<TestServerFixture>
    {
        private readonly TestServerFixture _fixture;
        private readonly HttpClient httpClient;
        public HotelsControllerTest(TestServerFixture fixture)
        {
            _fixture = fixture;
            httpClient = _fixture.httpClient;
        }
        [Fact]
        public async Task TestGetAllHotel()
        {
            var response = await httpClient.GetAsync("/api/hotels");
            response.EnsureSuccessStatusCode();
            var jsonStr = await response.Content.ReadAsStringAsync();
            var cityList = JsonConvert.DeserializeObject<List<City>>(jsonStr);
            Assert.NotNull(cityList);
        }
        [Fact]
        public async Task TestGetHotelById()
        {
            var response = await httpClient.GetAsync("/api/Hotels/1");
            response.EnsureSuccessStatusCode();
            var jsonStr = await response.Content.ReadAsStringAsync();
            var hotel = JsonConvert.DeserializeObject<Hotel>(jsonStr);
            Assert.Contains("Beijing Marriott", hotel.Name, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
