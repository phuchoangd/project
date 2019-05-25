using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockExchanges.Model;
using StockExchanges.Service;
using StockExchanges.Web.ViewModels;

namespace StockExchanges.Web.Controllers
{
    [Route("api/[controller]")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public JsonResult Index()
        {

            return Json(data: new object());
        }

        public JsonResult Add(CommentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Comment
                {
                    PostId = model.PostId,
                    Title = model.Title,
                    Description = model.Description
                };
                _commentService.Create(entity);
                var comments = _commentService.GetAll().Where(x => x.PostId == entity.PostId);
                return Json(comments);
            }
            
            return Json(false);
        }
    }
}