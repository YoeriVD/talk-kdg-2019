using System.Collections.Generic;
using System.Linq;
using WebApplication.Core;

namespace WebApplication.Models
{
    public static class QuestionExtensions
    {
        public static QuestionViewModel ToViewModel(this Question question)
        {
            var model = new QuestionViewModel
            {
                QuestionId= question.Id,
                Question = question.QuestionContent
            };
            model.Answers = question
                .PossibleAnswers
                .Select(pa =>
                    new AnswerViewModel
                    {
                        Answer = pa.Answer,
                        AnswerId = pa.Id,
                        Color = pa.Color
                    });
            return model;
        }
    }

    public class QuestionViewModel
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public IEnumerable<AnswerViewModel> Answers { get; set; }
        public bool IsAnswered => !string.IsNullOrWhiteSpace(Answer);

        public int QuestionId { get; internal set; }
    }

    public class AnswerViewModel
    {
        public string Color { get; set; }
        public string Answer { get; set; }
        public int AnswerId { get; set; }
    }

    public static class Color
    {
        public const string Green = "success";
        public const string Red = "warning";
    }
}