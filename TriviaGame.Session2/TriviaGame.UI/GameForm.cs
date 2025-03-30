using TriviaGame.Data;
using TriviaGame.Data.Extensions;
using TriviaGame.Service;
using TriviaGame.Service.Models;

namespace TriviaGame.UI;

public partial class GameForm : Form
{
    private List<Question> _questions = [];
    private int _currentQuestionIndex = 0;
    private int _score = 0;
    private const string _scoreText = "Score: {0}";
    private const string _questionText = "Question {0} of {1}";

    private readonly Form1 _form;

    public GameForm(Form1 form)
    {
        InitializeComponent();
        _form = form;
    }

    private async void GameForm_Load(object sender, EventArgs e)
    {
        TriviaApiService triviaApiService = new TriviaApiService();

        var questions = await triviaApiService.GetQuestionsAsync();

        if (questions is null)
        {
            MessageBox.Show("Failed to load questions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _form.Show();
            Close();
            return;
        }

        _questions = questions;
        ShowQuestion();
    }

    private void ShowQuestion()
    {
        if (_currentQuestionIndex >= _questions.Count)
        {
            MessageBox.Show($"Your score is {_score}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _form.Show();
            Close();
            return;
        }

        UpdateHeader();

        var question = _questions[_currentQuestionIndex];
        lblQuestionContent.Text = question.Title;

        switch (question.Type)
        {
            case QuestionType.Boolean:
                PrepareButtons(pnlTF, question);
                pnlMQ.Hide();
                pnlTF.Show();
                break;
            case QuestionType.Multiple:
                PrepareButtons(pnlMQ, question);
                pnlTF.Hide();
                pnlMQ.Show();
                break;
        }
    }

    private void UpdateHeader()
    {
        lblScore.Text = string.Format(_scoreText, _score);
        lblQuestionTitle.Text = string.Format(_questionText, _currentQuestionIndex + 1, _questions.Count);
    }

    private static void PrepareButtons(Panel panel, Question question)
    {
        List<Button> buttons = [];

        foreach (Control control in panel.Controls)
        {
            if (control is Button button)
            {
                buttons.Add(button);
            }
        }

        List<Answer> answers = question.Answers.Shuffle();

        for (var i = 0; i < buttons.Count; i++)
        {
            var answer = answers[i];
            var button = buttons[i];

            button.Text = answer.Title;
            button.Tag = answer;
        }
    }

    private void AnswerClicked(object sender, EventArgs e)
    {
        Answer a = (Answer)((Button)sender).Tag!;

        if (a.IsCorrect)
        {
            MessageBox.Show("Correct!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _score++;
        }
        else
        {
            MessageBox.Show("Incorrect!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        _currentQuestionIndex++;
        ShowQuestion();
    }
}
