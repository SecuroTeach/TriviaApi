namespace TriviaGame.Data;

public class Question
{
    public required string Title { get; set; }
    public required QuestionType Type { get; set; }
    public required List<Answer> Answers { get; set; }
}
