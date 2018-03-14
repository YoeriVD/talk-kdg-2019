using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_demo.Models
{
    public partial class SentimentController : Controller
    {
        // GET: Sentiment
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}