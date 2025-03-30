using TriviaGame.Data;
using TriviaGame.Service.Models;

namespace TriviaGame.Service.Mappers;

public static class QuestionMapper
{
    public static List<Question> ToQuestionList(this List<TriviaQuestionModel> questions)
    {
        var result = new List<Question>();

        foreach (var question in questions)
        {
            var answers = new List<Answer>
            {
                new() { Title = question.CorrectAnswer, IsCorrect = true }
            };

            foreach (var a in question.IncorrectAnswers)
            {
                answers.Add(new Answer { Title = a, IsCorrect = false });
            }

            var type = question.Type switch
            {
                QuestionTypeModelConstants.Multiple => QuestionType.Multiple,
                QuestionTypeModelConstants.Boolean => QuestionType.Boolean,
                _ => throw new NotSupportedException($"This type {question.Type} is not supported."),
            };

            var q = new Question
            {
                Title = question.Question,
                Type = type,
                Answers = answers
            };

            result.Add(q);
        }

        return result;
    }
}
