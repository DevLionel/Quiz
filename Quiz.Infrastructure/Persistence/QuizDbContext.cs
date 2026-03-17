using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Entities;
using Quiz.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

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
                new Question { Id = 1, QuestionText = "The Earth is round.", QuestionTemplateId = 1, MediaType = MediaType.None },
                new Question { Id = 2, QuestionText = "What is the capital of France?", QuestionTemplateId = 2, MediaType = MediaType.None }
            );

            modelBuilder.Entity<Answer>().HasData(
                new Answer { Id = 1, QuestionId = 1, AnswerText = "True", IsCorrect = true },
                new Answer { Id = 2, QuestionId = 1, AnswerText = "False", IsCorrect = false },
                new Answer { Id = 3, QuestionId = 2, AnswerText = "Berlin", IsCorrect = false },
                new Answer { Id = 4, QuestionId = 2, AnswerText = "Paris", IsCorrect = true },
                new Answer { Id = 5, QuestionId = 2, AnswerText = "Madrid", IsCorrect = false }
            );

        }
    }
}
