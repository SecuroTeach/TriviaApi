using Microsoft.AspNetCore.Mvc;
using TriviaGame.Service;

namespace TriviaGame.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuestionsController : ControllerBase
{
    private readonly IQuestionsService _questionsService;

    public QuestionsController(IQuestionsService questionsService)
    {
        _questionsService = questionsService;
    }

    [HttpGet("")]
    public async Task<IActionResult> GetQuestions(Guid sessionId)
    {
        var result = await _questionsService.GetQuestionsAsync(sessionId);

        if (result is null)
        {
            return NotFound();
        }

        return Ok(result);
    }
}
