using System.Text.Json;
using TriviaGame.Data;
using TriviaGame.Service.Mappers;
using TriviaGame.Service.Models;

namespace TriviaGame.Service;

public class TriviaApiService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private const string _url = "https://opentdb.com/api.php?amount=3&difficulty=easy";
    private const int _maxRetryCount = 3;

    public TriviaApiService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<List<Question>?> GetQuestionsAsync()
    {
        int retryCount = 0;

        using var client = _httpClientFactory.CreateClient();

        do
        {
            if (retryCount >= _maxRetryCount)
            {
                return null;
            }

            if (retryCount > 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
            }

            try
            {
                var response = await client.GetAsync(_url);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<TriviaQuestionResponseModel>(content);

                if (result is null)
                {
                    continue;
                }

                if (result.ResponseCode == (int)TriviaQuestionResponseCodes.RateLimit)
                {
                    continue;
                }

                if (result.ResponseCode != (int)TriviaQuestionResponseCodes.Success)
                {
                    return null;
                }

                return result.Results.ToQuestionList();
            }
            catch
            {
                // ignore
            }
            finally
            {
                retryCount++;
            }

        } while(true);
    }
}
