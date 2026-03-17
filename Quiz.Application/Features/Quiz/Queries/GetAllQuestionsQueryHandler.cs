using MediatR;
using Quiz.Application.DTOs;
using Quiz.Application.Interfaces;

public class GetAllQuestionsQuery : IRequest<List<QuestionDto>> { }

public class GetAllQuestionsQueryHandler : IRequestHandler<GetAllQuestionsQuery, List<QuestionDto>>
{
    private readonly IQuizRepository _repository;

    public GetAllQuestionsQueryHandler(IQuizRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<QuestionDto>> Handle(GetAllQuestionsQuery request, CancellationToken cancellationToken)
    {
        var questions = await _repository.GetAllQuestionsAsync(); // new repo method
        return questions.Select(q => new QuestionDto
        {
            Id = q.Id,
            QuestionText = q.QuestionText,
            QuestionTemplateTypeId = q.QuestionTemplateId,
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