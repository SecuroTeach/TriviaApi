using System.Text.Json;
using TriviaGame.Service.Models;

namespace TriviaGame.Service;

public class TriviaApiService
{
    private static HttpClient _client = new HttpClient();
    private const string _url = "https://opentdb.com/api.php?amount=10";

    public async Task<List<TriviaQuestionModel>?> GetQuestions()
    {
        try
        {
            var response = await _client.GetAsync(_url);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<TriviaQuestionResponseModel>(content);

            // Response code

            return result?.Results;
        }
        catch
        {
            return null;
        }
    }
}
