using MediatR;
using Microsoft.AspNetCore.Mvc;
using Quiz.Application.DTOs;

[Route("api/[controller]")]
[ApiController]
public class QuizController : ControllerBase
{
    private readonly IMediator _mediator;

    public QuizController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/quiz
    [HttpGet]
    public async Task<ActionResult<List<QuestionDto>>> GetAllQuestions()
    {
        var questions = await _mediator.Send(new GetAllQuestionsQuery());
        return Ok(questions);
    }

    // GET: api/quiz/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<QuestionDto>> GetQuestionById(int id)
    {
        var question = await _mediator.Send(new GetQuestionByIdQuery { QuestionId = id });
        if (question == null) return NotFound();
        return Ok(question);
    }
}