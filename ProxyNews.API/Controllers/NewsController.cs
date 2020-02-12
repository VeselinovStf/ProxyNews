using Microsoft.AspNetCore.Mvc;
using ProxyNews.API.Models;
using System.Threading.Tasks;
using Utility.RssReading.RssReader.Abstract;
using Utility.RssReading.RssReader.Model.Abstract;

namespace ProxyNews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IRssReaderRepository<IRssFeed> rssFeedRepo;

        public NewsController(IRssReaderRepository<IRssFeed> rssFeedRepo)
        {
            this.rssFeedRepo = rssFeedRepo;
        }

     
        [HttpGet]
        public async Task<ActionResult<RssFeedListModel>> GetAll()
        
        {
            try
            {
                var RSSFeedData = await this.rssFeedRepo.GetListedFeed("item");

                if (RSSFeedData == null)
                {
                    return NotFound("Rss Feed Is Down");
                }

                var model = new RssFeedListModel()
                {
                    RssList = RSSFeedData
                };

                return Ok(model);
            }
            catch (System.Exception)
            {
                return NotFound("Unable to create rss connection");
            }
        }
    }
}