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
            var posts = _postService.GetAll()
                        .Select(x => new PostViewModel
                        {
                            Id = x.Id,
                            Content = x.Content,
                            ShortDescription = x.ShortDescription,
                            Slug = x.Slug,
                            ThumbnailImage = x.ThumbnailImage,
                            TotalComment = x.Comments != null ? x.Comments.Count() : 0
                        });
            return Json(posts);
        }
    }
}