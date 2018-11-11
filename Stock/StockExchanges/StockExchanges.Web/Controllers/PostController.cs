using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockExchanges.Service;

namespace StockExchanges.Web.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        public JsonResult GetAllPosts(int category)
        {
            var news = _postService.GetAll().Where(c => c.CategoryId == category);
            return Json(news);
        }
    }
}