using MediatR;
using Microsoft.AspNetCore.Mvc;
using Quiz.Application.Features.Quiz.Queries;
using System.Threading.Tasks;

namespace Quiz.Api.Controllers
{
    [ApiController]
    [Route("api/quiz")]
    public class QuizController : ControllerBase
    {
        private readonly IMediator _mediator;

        public QuizController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{templateId}")]
        public async Task<IActionResult> GetQuiz(int templateId)
        {
            var result = await _mediator.Send(new GetQuizQuery(templateId));
            return Ok(result);
        }
    }
}
