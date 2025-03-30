using System.Text.Json.Serialization;

namespace TriviaGame.Service.Models;

public class TriviaQuestionModel
{
    [JsonPropertyName("question")]
    public string Question { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("correct_answer")]
    public string CorrectAnswer { get; set; }

    [JsonPropertyName("incorrect_answers")]
    public List<string> IncorrectAnswers { get; set; }
}
