namespace Quiz.Application.DTOs
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public int QuestionTemplateTypeId { get; set; }
        public string MediaType { get; set; }
        public string MediaUrl { get; set; }
        public List<AnswerDto> Answers { get; set; }
    }
   
    public class AnswerDto
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
    }
}