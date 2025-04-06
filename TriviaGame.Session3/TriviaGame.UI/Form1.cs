namespace TriviaGame.UI;

public partial class Form1 : Form
{
    private int _bestScore = 0;
    private const string _bestScoreText = "Best Score: {0}";
    private Guid _sessionId = Guid.NewGuid();

    public Form1()
    {
        InitializeComponent();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        GameForm gameForm = new GameForm(this, _sessionId);
        Hide();
        gameForm.Show();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    public void SetScore(int score)
    {
        if (score > _bestScore)
        {
            _bestScore = score;
            lblBestScore.Text = string.Format(_bestScoreText, _bestScore);
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
