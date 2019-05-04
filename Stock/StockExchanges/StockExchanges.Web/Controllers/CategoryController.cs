using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockExchanges.Service;
using StockExchanges.Web.ViewModels;

namespace StockExchanges.Web.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("[action]")]
        public IActionResult GetAllCategories()
        {
            var categories = _categoryService.GetAll();
            return View();
        }
        [HttpGet("[action]")]
        public JsonResult GetFeatures()
        {
            var features = _categoryService.GetAll()
                        .Take(4)
                        .Select(c => new FeatureModel
                        {
                            Id = c.Id,
                            Category = c.Name,
                            Content = c.Posts != null ? c.Posts.OrderByDescending(x => x.CreatedDate).FirstOrDefault().Content : "",
                        });
            return Json(features);
        }

        [HttpGet("[action]")]
        public JsonResult GetCategoryById(int id)
        {
            var category = _categoryService.GetById(id);
            var result = new CategoryViewModel
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Posts = category?.Posts.Select(x => new PostViewModel
                {
                    Id = x.Id,
                    Content = x.Content,
                    ShortDescription = x.ShortDescription,
                    Slug = x.Slug,
                    ThumbnailImage = x.ThumbnailImage,
                    TotalComment = x.Comments != null ? x.Comments.Count() : 0
                })
            };
            return Json(result);
        }
    }
}