using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StockExchanges.Web.Controllers
{
    [Route("api/[controller]")]
    public class CommentController : Controller
    {

        public JsonResult Index()
        {

            return Json(data: new object());
        }
    }
}