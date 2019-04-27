using AproxyNews.APIRequestService.ModelFactory;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProxyNews.APIRequestService.Abstract;
using ProxyNews.APIRequestService.DTOs;
using ProxyNews.APIRequestService.HttpClient;
using ProxyNews.APIRequestService.NewsList;
using ProxyNews.HttpClientFactoryWrapper.Abstract;
using ProxyNews.Json.ModelFactory;
using ProxyNews.Json.ModelFactory.Abstract;
using ProxyNews.Web.Models;

namespace ProxyNews.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
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

            services.AddHttpClient();
            // services.AddScoped<APICaller, APICaller>();
            services.AddScoped<INewsList<NewsListDTO>, NewsList>();
            services.AddScoped<IHttpClientFactoryWrapper, HttpClientFactory.HttpClientFactoryWrapper>();
            services.AddScoped<IJsonDeserializer, JsonModelFactory>();
            services.AddScoped<IViewModelFactory, ViewModelFactory>();
            services.AddScoped<IHttpClientService, HttpClientService>();
            services.AddScoped<IServiceModelFactory, ServiceModelFactory>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=News}/{action=Index}/{id?}");
            });
        }
    }
}