using Microsoft.EntityFrameworkCore;

namespace WebApplication.Core
{
    public class VotingContext : DbContext
    {
        public VotingContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<PossibleAnswer> PossibleAnswers { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    QuestionContent = "Wegversmallingen vervangen door bloembakken?"
                });
            modelBuilder.Entity<PossibleAnswer>().HasData(
                new PossibleAnswer
                {
                    Id = 1,
                    QuestionId = 1,
                    Answer = "ja",
                    Color = "success"
                },
                new PossibleAnswer
                {
                    Id = 2,
                    QuestionId = 1,
                    Answer = "nee",
                    Color = "warning"
                }
            );
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 2,
                    QuestionContent = "Zone 30 afschaffen?"
                }
            );

            modelBuilder.Entity<PossibleAnswer>().HasData(
                new PossibleAnswer
                {
                    Id= 3,
                    QuestionId = 2,
                    Answer = "absoluut!",
                    Color = "success"
                },
                new PossibleAnswer
                {
                    Id = 4,
                    QuestionId = 2,
                    Answer = "Gij zijt zot zeker?",
                    Color = "warning"
                });
        }
    }
}