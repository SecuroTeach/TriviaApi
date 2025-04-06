using System.Text.Json.Serialization;

namespace TriviaGame.Service.Models;

public class TriviaQuestionResponseModel
{
    [JsonPropertyName("response_code")]
    public int ResponseCode { get; set; }

    [JsonPropertyName("results")]
    public List<TriviaQuestionModel> Results { get; set; }
}
