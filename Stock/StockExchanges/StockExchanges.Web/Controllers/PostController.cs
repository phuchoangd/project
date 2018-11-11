using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockExchanges.Service;

namespace StockExchanges.Web.Controllers
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpGet("[action]")]
        public JsonResult GetAllPosts()
        {
            var news = _postService.GetAll();
            return Json(news);
        }
    }
}