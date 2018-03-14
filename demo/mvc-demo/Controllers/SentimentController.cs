using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using mvc_demo.core;
using mvc_demo.Models;

namespace mvc_demo.Controllers
{
    public partial class SentimentController : Controller
    {
        // GET: Sentiment
        public virtual ActionResult Index(Guid id)
        {
            using (var db = new TextSentimentDbContext())
            {
                var text = db.TextAnalyses.Include(m => m.Sentiments).FirstOrDefault(t => t.Id == id);
                if (text == null) return RedirectToAction(MVC.Home.Index());
                var selectedSentiments = text.Sentiments.Select(se => se.Id).ToArray();
                var model = new IndexSentimentViewModel
                {
                    Id = text.Id,
                    Text = text.TextContent,
                    Title = text.Title,
                    SelectedSentiments = new MultiSelectFormDto()
                    {
                        AvailableOptions =
                            db.Sentiments.Select(s => new Option() {Description = s.EmotionName, Id = s.Id, IsSelected = selectedSentiments.Contains(s.Id)}).ToList()
                    }
                };
                return View(model);
            }
        }
        [HttpPost]
        public virtual ActionResult Index(Guid Id, Guid[] selectedSentiments)
        {
            using (var db = new TextSentimentDbContext())
            {
                var text = db.TextAnalyses.Include(d => d.Sentiments).FirstOrDefault(t => t.Id == Id);
                if (text != null)
                {
                    text.Sentiments.Clear();
                    var sentiments = db.Sentiments.ToDictionary(s => s.Id);
                    foreach (var sentimentIds in selectedSentiments)
                    {
                        text.Sentiments.Add(sentiments[sentimentIds]);
                    }
                    db.SaveChanges();
                }
            }
            return RedirectToAction(MVC.Home.Index());
        }
    }
}