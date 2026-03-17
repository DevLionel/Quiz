using MediatR;
using Quiz.Application.DTOs;
using Quiz.Application.Interfaces;

namespace Quiz.Application.Features.Quiz.Queries
{
    public class GetQuizQueryHandler : IRequestHandler<GetQuizQuery, List<QuestionDto>>
    {
        private readonly IQuizRepository _repository;

        public GetQuizQueryHandler(IQuizRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<QuestionDto>> Handle(GetQuizQuery request, CancellationToken cancellationToken)
        {
            var questions = await _repository.GetQuestionsByTemplateId(request.TemplateId);

            return questions.Select(q => new QuestionDto
            {
                Id = q.Id,
                QuestionText = q.QuestionText,
                TemplateTypeId = q.QuizTemplateId,
                MediaType = q.MediaType.ToString(),
                MediaUrl = q.MediaUrl,
                Answers = q.Answers.Select(a => new AnswerDto
                {
                    Id = a.Id,
                    AnswerText = a.AnswerText,
                    IsCorrect = a.IsCorrect
                }).ToList()
            }).ToList();
        }
    }
}
