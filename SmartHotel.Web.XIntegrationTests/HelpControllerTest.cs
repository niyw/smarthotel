using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace SmartHotel.Web.XIntegrationTests
{
    public class HelpControllerTest
    {
        private readonly ITestOutputHelper _output;
        public HelpControllerTest(ITestOutputHelper output) {
            _output = output;
        }
        [Fact]
        public async Task TestGetMemberPhone()
        {
            var builder = WebHost.CreateDefaultBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>();
            using (var server=new TestServer(builder))
            {
                var httpClient = server.CreateClient();
                var response = await httpClient.GetAsync("/api/help/MemberPhone");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                Assert.NotEmpty(content);

            }
        }
        [Fact(Skip ="just for demo")]
        [Trait("Category","Controller")]
        public void TestDemo() {
            _output.WriteLine("output something to test output");
        }
    }
}
