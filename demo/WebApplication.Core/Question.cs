using System.Collections.Generic;

namespace WebApplication.Core
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionContent { get; set; }
        public ICollection<PossibleAnswer> PossibleAnswers { get; set; }
    }

    public class PossibleAnswer
    {
        public int Id { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }
        public string Color { get; set; }
    }

    public class Answer
    {
        public int Id { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }
        public PossibleAnswer PossibleAnswer { get; set; }
        public int PossibleAnswerId { get; set; }
    }
}