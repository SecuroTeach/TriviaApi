using System.Text.Json;
using TriviaGame.Data;
using TriviaGame.Service.Mappers;
using TriviaGame.Service.Models;

namespace TriviaGame.Service;

public class TriviaApiService
{
    private static HttpClient _client = new HttpClient();
    private const string _url = "https://opentdb.com/api.php?amount=10";

    public async Task<List<Question>?> GetQuestionsAsync()
    {
        try
        {
            var response = await _client.GetAsync(_url);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<TriviaQuestionResponseModel>(content);

            // Response code

            if (result is null)
            {
                return null;
            }

            return result.Results.ToQuestionList();
        }
        catch
        {
            return null;
        }
    }
}
