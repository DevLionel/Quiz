using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Entities;
using Quiz.Domain.Enums;


namespace Quiz.Infrastructure.Persistence
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options)
        : base(options)
        {
        }

        public DbSet<QuizTemplate> QuizTemplates { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<QuizTemplate>().HasData(
                new QuizTemplate { Id = 1, Name = "True or False", TemplateType = TemplateType.TrueFalse },
                new QuizTemplate { Id = 2, Name = "Multiple Choice", TemplateType = TemplateType.MultipleChoice },
                new QuizTemplate { Id = 3, Name = "More or Less", TemplateType = TemplateType.MoreOrLess }
            );

            modelBuilder.Entity<Question>().HasData(
                new Question { Id = 1, QuestionText = "Is de eiffeltoren hoger dan 300 meter?", QuizTemplateId = 1, MediaType = MediaType.None },
                new Question { Id = 2, QuestionText = "Heeft Nederland meer fietsen dan inwoners?", QuizTemplateId = 1, MediaType = MediaType.None },
                new Question { Id = 3, QuestionText = "Is de mens de snelste landzoogdier ter wereld?", QuizTemplateId = 1, MediaType = MediaType.None },
                new Question { Id = 4, QuestionText = "Ligt Australië op het zuidelijk halfrond?", QuizTemplateId = 1, MediaType = MediaType.None },
                new Question { Id = 5, QuestionText = "Heeft een octopus meer of minder dan 6 armen?", QuizTemplateId = 3, MediaType = MediaType.None },
                new Question { Id = 6, QuestionText = "Ligt de gemiddelde lichaamstemperatuur van een mens hoger of lager dan 38 graden Celsius?", QuizTemplateId = 3, MediaType = MediaType.None },
                new Question { Id = 7, QuestionText = "Heeft een jaar meer of minder dan 400 dagen?", QuizTemplateId = 3, MediaType = MediaType.None },
                new Question { Id = 8, QuestionText = "Is de afstand van Amsterdam naar Parijs meer of minder dan 500 kilometer?", QuizTemplateId = 3, MediaType = MediaType.None },
                new Question { Id = 9, QuestionText = "Welke planeet is het grootst in ons zonnestelsel?", QuizTemplateId = 2, MediaType = MediaType.None },
                new Question { Id = 10, QuestionText = "In welk jaar viel de Berlijnse Muur?", QuizTemplateId = 2, MediaType = MediaType.None },
                new Question { Id = 11, QuestionText = "Wie schreef het boek 'De Ontdekking van de Hemel'?", QuizTemplateId = 2, MediaType = MediaType.None },
                new Question { Id = 12, QuestionText = "Welk element heeft het chemische symbool 'Au'?", QuizTemplateId = 2, MediaType = MediaType.None },
                new Question { Id = 13, QuestionText = "Welke sport wordt gespeeld bij Wimbledon?", QuizTemplateId = 2, MediaType = MediaType.None },
                new Question { Id = 14, QuestionText = "Is de walvis een vis?", QuizTemplateId = 1, MediaType = MediaType.None },
                new Question { Id = 15, QuestionText = "Heeft een mens meer of minder dan 200 botten in zijn lichaam?", QuizTemplateId = 3, MediaType = MediaType.None }
            );

            modelBuilder.Entity<Answer>().HasData(
                new Answer { Id = 1, QuestionId = 1, AnswerText = "Waar", IsCorrect = true },
                new Answer { Id = 2, QuestionId = 1, AnswerText = "Niet Waar", IsCorrect = false },
                new Answer { Id = 3, QuestionId = 2, AnswerText = "Waar", IsCorrect = true },
                new Answer { Id = 4, QuestionId = 2, AnswerText = "Niet Waar", IsCorrect = false },
                new Answer { Id = 5, QuestionId = 3, AnswerText = "Waar", IsCorrect = false },
                new Answer { Id = 6, QuestionId = 3, AnswerText = "Niet Waar", IsCorrect = true },
                new Answer { Id = 7, QuestionId = 4, AnswerText = "Waar", IsCorrect = true },
                new Answer { Id = 8, QuestionId = 4, AnswerText = "Niet Waar", IsCorrect = false },
                new Answer { Id = 9, QuestionId = 5, AnswerText = "Meer", IsCorrect = true }, 
                new Answer { Id = 10, QuestionId = 5, AnswerText = "Minder", IsCorrect = false },
                new Answer { Id = 11, QuestionId = 6, AnswerText = "Hoger", IsCorrect = false },
                new Answer { Id = 12, QuestionId = 6, AnswerText = "Lager", IsCorrect = true },
                new Answer { Id = 13, QuestionId = 7, AnswerText = "Meer", IsCorrect = false },
                new Answer { Id = 14, QuestionId = 7, AnswerText = "Minder", IsCorrect = true },
                new Answer { Id = 15, QuestionId = 8, AnswerText = "Meer", IsCorrect = false },
                new Answer { Id = 16, QuestionId = 8, AnswerText = "Minder", IsCorrect = true },
                new Answer { Id = 17, QuestionId = 9, AnswerText = "A. Mars", IsCorrect = false },
                new Answer { Id = 18, QuestionId = 9, AnswerText = "B. Saturnus", IsCorrect = false },
                new Answer { Id = 19, QuestionId = 9, AnswerText = "C. Jupiter", IsCorrect = true },
                new Answer { Id = 20, QuestionId = 9, AnswerText = "D. Neptunus", IsCorrect = false },
                new Answer { Id = 21, QuestionId = 10, AnswerText = "A. 1985", IsCorrect = false },
                new Answer { Id = 22, QuestionId = 10, AnswerText = "B. 1989", IsCorrect = true },
                new Answer { Id = 23, QuestionId = 10, AnswerText = "C. 1991", IsCorrect = false },
                new Answer { Id = 24, QuestionId = 10, AnswerText = "D. 1993", IsCorrect = false },
                new Answer { Id = 25, QuestionId = 11, AnswerText = "A. Harry Mulisch", IsCorrect = true },
                new Answer { Id = 26, QuestionId = 11, AnswerText = "B. Maarten 't Hart", IsCorrect = false },
                new Answer { Id = 27, QuestionId = 11, AnswerText = "C. Cees Nooteboom", IsCorrect = false },
                new Answer { Id = 28, QuestionId = 11, AnswerText = "D. Gerard Reve", IsCorrect = false },
                new Answer { Id = 29, QuestionId = 12, AnswerText = "A. Harry Mulisch", IsCorrect = true },
                new Answer { Id = 30, QuestionId = 12, AnswerText = "B. Maarten 't Hart", IsCorrect = false },
                new Answer { Id = 31, QuestionId = 12, AnswerText = "C. Cees Nooteboom", IsCorrect = false },
                new Answer { Id = 32, QuestionId = 12, AnswerText = "D. Gerard Reve", IsCorrect = false },
                new Answer { Id = 33, QuestionId = 13, AnswerText = "A. Badminton", IsCorrect = false },
                new Answer { Id = 34, QuestionId = 13, AnswerText = "B. Tennis", IsCorrect = true },
                new Answer { Id = 35, QuestionId = 13, AnswerText = "C. Cricket", IsCorrect = false },
                new Answer { Id = 36, QuestionId = 13, AnswerText = "D. Squash", IsCorrect = false },
                new Answer { Id = 37, QuestionId = 14, AnswerText = "Waar", IsCorrect = false },
                new Answer { Id = 38, QuestionId = 14, AnswerText = "Niet Waar", IsCorrect = true },
                new Answer { Id = 39, QuestionId = 15, AnswerText = "Meer", IsCorrect = true },
                new Answer { Id = 40, QuestionId = 15, AnswerText = "Minder", IsCorrect = false }
            );
        }
    }
}
