using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ProxyNews.APIRequestService.Abstract;
using ProxyNews.APIRequestService.DTOs;
using ProxyNews.Web.Models;
using ProxyNews.Web.Models.NewsModels;

namespace ProxyNews.Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsList<NewsListDTO> newsList;
        private readonly IConfiguration configuration;
        private readonly IViewModelFactory modelFactory;
        private readonly ILogger<NewsController> logger;

        public NewsController(
            INewsList<NewsListDTO> newsList,
            IConfiguration configuration,
            IViewModelFactory modelFactory,
            ILogger<NewsController> logger
            )
        {
            this.newsList = newsList;
            this.configuration = configuration;
            this.modelFactory = modelFactory;
            this.logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var serviceModel = await this.newsList.GetAll(
                     this.configuration.GetSection("API_Connection:HomePage").Get<string>());

                if (serviceModel == null)
                {
                    this.logger.LogWarning("Service model return null");
                }
                else
                {
                    var model = this.modelFactory.Create(serviceModel);

                    if (model != null)
                    {
                        this.logger.LogInformation("Call done, displaying to view.");

                        return View(model);
                    }
                    else
                    {
                        this.logger.LogWarning("Service model parsing to view model fails");
                    }
                }
            }
            catch (System.Exception ex)
            {
                this.logger.LogError(ex.Message);
            }

            return RedirectToAction("Error", "News");
        }

        //[HttpPost]
        //public ActionResult Index(NewsModel model)
        //{
        //    if (model.URL == null)
        //    {
        //        throw new ArgumentException("Model state was invalid");
        //    }

        //    var RSSFeedData = this.rssFeedRepository.GetSpecificFeed(model.URL, "item");

        //    var viewModel = new NewsModel()
        //    {
        //        RssFeed = RSSFeedData,
        //        URL = model.URL
        //    };

        //    return View(viewModel);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}