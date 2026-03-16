using Quiz.Domain.Enums;

namespace Quiz.Domain.Entities
{
    public class QuizTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TemplateType TemplateType { get; set; }
    }
}
