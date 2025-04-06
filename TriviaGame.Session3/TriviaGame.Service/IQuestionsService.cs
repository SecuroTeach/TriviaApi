using TriviaGame.Data;

namespace TriviaGame.Service;

public interface IQuestionsService
{
    Task<List<Question>?> GetQuestionsAsync(Guid sessionId);
}
