using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Core;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly VotingContext _db;

        public HomeController(VotingContext db)
        {
            _db = db;
        }

        public virtual IActionResult Index()
        {
            ViewBag.QuestionId = _db.Questions.OrderBy(q => q.Id).First().Id;
            return View();
        }

        public virtual async Task<IActionResult> Vote(int id = 1)
        {
            var question = await _db.Questions.Include(q => q.PossibleAnswers).FirstAsync(q => q.Id == id);
            var answer = await _db.Answers.FirstOrDefaultAsync(a => a.QuestionId == question.Id);
            var vModel = question.ToViewModel();
            vModel.Answer = answer?.PossibleAnswer.Answer;
            return View(vModel);
        }
        [HttpPost]
        public virtual async Task<IActionResult> Answer(int id, int answerId)
        {
            var question = await _db.Questions.Include(q => q.PossibleAnswers).FirstAsync(q => q.Id == id);
            var answer = question.PossibleAnswers.First(a => a.Id == answerId);
            _db.Answers.Add(new Core.Answer(){ PossibleAnswer = answer, Question = question });
            await _db.SaveChangesAsync();
            return RedirectToAction("Vote", new { id = question.Id + 1});
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public virtual IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}