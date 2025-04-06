using Microsoft.Extensions.Caching.Memory;
using TriviaGame.Data;

namespace TriviaGame.Service;

public class QuestionsService : IQuestionsService
{
    private readonly TriviaApiService _triviaApiService;
    private readonly IMemoryCache _cache;
    private const string _cacheKeyPattern = "questions-{0}";

    public QuestionsService(TriviaApiService triviaApiService, IMemoryCache cache)
    {
        _triviaApiService = triviaApiService;
        _cache = cache;
    }

    public async Task<List<Question>?> GetQuestionsAsync(Guid sessionId)
    {
        var cacheKey = string.Format(_cacheKeyPattern, sessionId);

        var questions = await _cache.GetOrCreateAsync(cacheKey, async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5);
            var result = await _triviaApiService.GetQuestionsAsync();
                
            return result;
        });

        return questions;
    }
}
