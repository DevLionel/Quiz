using MediatR;
using Quiz.Application.DTOs;
using Quiz.Application.Interfaces;


public class GetQuestionByIdQuery : IRequest<QuestionDto>
{
    public int QuestionId { get; set; }
}

public class GetQuestionByIdQueryHandler : IRequestHandler<GetQuestionByIdQuery, QuestionDto>
{
    private readonly IQuizRepository _repository;

    public GetQuestionByIdQueryHandler(IQuizRepository repository)
    {
        _repository = repository;
    }

    public async Task<QuestionDto> Handle(GetQuestionByIdQuery request, CancellationToken cancellationToken)
    {
        var q = await _repository.GetQuestionById(request.QuestionId); // repo method
        if (q == null) return null;

        return new QuestionDto
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
        };
    }
}
