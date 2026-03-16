using Quiz.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }

        public string QuestionText { get; set; }

        public MediaType MediaType { get; set; }

        public string? MediaUrl { get; set; }

        public int QuizTemplateId { get; set; }

        public QuizTemplate QuizTemplate { get; set; }

        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
