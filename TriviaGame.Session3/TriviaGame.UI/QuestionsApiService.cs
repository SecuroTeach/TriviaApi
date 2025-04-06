using System.Text.Json;
using System.Text.Json.Serialization;
using TriviaGame.Data;

namespace TriviaGame.UI;

public static class QuestionsApiService
{
    private const string _url = "https://localhost:7288/api/questions?sessionId={0}";
    private readonly static HttpClient _httpClient = new HttpClient();
    private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true,
        Converters =
        {
             new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
        }
    };


    public static async Task<List<Question>?> GetQuestionsAsync(Guid sessionId)
    {
        try
        {
            var url = string.Format(_url, sessionId);
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<List<Question>>(content, _jsonSerializerOptions);

            return result;
        }
        catch
        {
            return null;
        }
    }
}
