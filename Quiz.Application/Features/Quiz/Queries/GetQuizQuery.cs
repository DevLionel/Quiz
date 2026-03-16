using MediatR;
using Quiz.Application.DTOs;
using System.Collections.Generic;

namespace Quiz.Application.Features.Quiz.Queries
{
    public record GetQuizQuery(int TemplateId) : IRequest<List<QuestionDto>>;
}
