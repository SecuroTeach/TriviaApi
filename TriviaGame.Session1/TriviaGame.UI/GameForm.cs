using TriviaGame.Service;
using TriviaGame.Service.Models;

namespace TriviaGame.UI;

public partial class GameForm : Form
{
    private List<TriviaQuestionModel> _questions = [];

    public GameForm()
    {
        InitializeComponent();
    }

    private async void GameForm_Load(object sender, EventArgs e)
    {
        TriviaApiService triviaApiService = new TriviaApiService();

        var questions = await triviaApiService.GetQuestions();

        if (questions is null)
        {
            MessageBox.Show("Failed to load questions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
            return;
        }

        _questions = questions;
    }
}
