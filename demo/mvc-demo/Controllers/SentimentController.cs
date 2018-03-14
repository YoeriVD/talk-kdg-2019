using System.Web.Mvc;

namespace mvc_demo.Controllers
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