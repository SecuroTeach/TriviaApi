namespace TriviaGame.UI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        GameForm gameForm = new GameForm();
        Hide();
        gameForm.Show();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
