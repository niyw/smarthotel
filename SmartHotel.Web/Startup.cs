using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using SmartHotel.Web.Data;
using SmartHotel.Web.Services;
using Microsoft.Extensions.Logging;

namespace SmartHotel.Web
{
    public class Startup
    {
        private readonly IWebHostEnvironment env;
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            this.env = env;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSingleton<AppConfig>(new AppConfig(Configuration));
            services.AddRazorPages();
            services.AddControllers();

            //services.AddTransient<DiscountService>(sp =>
            //{
            //    var logger = sp.GetRequiredService<ILogger<DiscountService>>();
            //    return new DiscountService(logger);
            //});
            services.AddTransient<DiscountService>();
            // services.AddDbContext<SmartHotelWebContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("SmartHotelWebContext")));
            services.AddDbContext<SmartHotelWebContext>(options=>options.UseInMemoryDatabase("SmartHotelWebMBb"));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
