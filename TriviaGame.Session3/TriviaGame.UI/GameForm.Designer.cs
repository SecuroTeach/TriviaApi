namespace TriviaGame.UI
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuestionTitle = new Label();
            lblQuestionContent = new Label();
            lblQuestionTime = new Label();
            lblScore = new Label();
            pictureBox1 = new PictureBox();
            pnlTF = new Panel();
            btnTF2 = new Button();
            btnTF1 = new Button();
            pnlMQ = new Panel();
            btnMQ4 = new Button();
            btnMQ3 = new Button();
            btnMQ2 = new Button();
            btnMQ1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTF.SuspendLayout();
            pnlMQ.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestionTitle
            // 
            lblQuestionTitle.AutoSize = true;
            lblQuestionTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblQuestionTitle.Location = new Point(313, 9);
            lblQuestionTitle.Name = "lblQuestionTitle";
            lblQuestionTitle.Size = new Size(166, 32);
            lblQuestionTitle.TabIndex = 0;
            lblQuestionTitle.Text = "Question 1/10";
            // 
            // lblQuestionContent
            // 
            lblQuestionContent.BorderStyle = BorderStyle.FixedSingle;
            lblQuestionContent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblQuestionContent.Location = new Point(25, 63);
            lblQuestionContent.Name = "lblQuestionContent";
            lblQuestionContent.Size = new Size(746, 85);
            lblQuestionContent.TabIndex = 1;
            // 
            // lblQuestionTime
            // 
            lblQuestionTime.AutoSize = true;
            lblQuestionTime.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblQuestionTime.Location = new Point(717, 9);
            lblQuestionTime.Name = "lblQuestionTime";
            lblQuestionTime.Size = new Size(71, 32);
            lblQuestionTime.TabIndex = 2;
            lblQuestionTime.Text = "00:00";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblScore.Location = new Point(12, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(113, 32);
            lblScore.TabIndex = 3;
            lblScore.Text = "Score: XX";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(12, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 4);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pnlTF
            // 
            pnlTF.Controls.Add(btnTF2);
            pnlTF.Controls.Add(btnTF1);
            pnlTF.Location = new Point(12, 162);
            pnlTF.Name = "pnlTF";
            pnlTF.Size = new Size(776, 276);
            pnlTF.TabIndex = 5;
            pnlTF.Visible = false;
            // 
            // btnTF2
            // 
            btnTF2.Font = new Font("Segoe UI", 20.25F);
            btnTF2.Location = new Point(449, 80);
            btnTF2.Name = "btnTF2";
            btnTF2.Size = new Size(200, 150);
            btnTF2.TabIndex = 1;
            btnTF2.Text = "False";
            btnTF2.UseVisualStyleBackColor = true;
            btnTF2.Click += AnswerClicked;
            // 
            // btnTF1
            // 
            btnTF1.Font = new Font("Segoe UI", 20.25F);
            btnTF1.Location = new Point(142, 80);
            btnTF1.Name = "btnTF1";
            btnTF1.Size = new Size(200, 150);
            btnTF1.TabIndex = 0;
            btnTF1.Text = "True";
            btnTF1.UseVisualStyleBackColor = true;
            btnTF1.Click += AnswerClicked;
            // 
            // pnlMQ
            // 
            pnlMQ.Controls.Add(btnMQ4);
            pnlMQ.Controls.Add(btnMQ3);
            pnlMQ.Controls.Add(btnMQ2);
            pnlMQ.Controls.Add(btnMQ1);
            pnlMQ.Location = new Point(12, 162);
            pnlMQ.Name = "pnlMQ";
            pnlMQ.Size = new Size(776, 276);
            pnlMQ.TabIndex = 6;
            pnlMQ.Visible = false;
            // 
            // btnMQ4
            // 
            btnMQ4.Location = new Point(416, 155);
            btnMQ4.Name = "btnMQ4";
            btnMQ4.Size = new Size(275, 75);
            btnMQ4.TabIndex = 3;
            btnMQ4.Text = "button4";
            btnMQ4.UseVisualStyleBackColor = true;
            btnMQ4.Click += AnswerClicked;
            // 
            // btnMQ3
            // 
            btnMQ3.Location = new Point(416, 51);
            btnMQ3.Name = "btnMQ3";
            btnMQ3.Size = new Size(275, 75);
            btnMQ3.TabIndex = 2;
            btnMQ3.Text = "button3";
            btnMQ3.UseVisualStyleBackColor = true;
            btnMQ3.Click += AnswerClicked;
            // 
            // btnMQ2
            // 
            btnMQ2.Location = new Point(81, 155);
            btnMQ2.Name = "btnMQ2";
            btnMQ2.Size = new Size(275, 75);
            btnMQ2.TabIndex = 1;
            btnMQ2.Text = "button2";
            btnMQ2.UseVisualStyleBackColor = true;
            btnMQ2.Click += AnswerClicked;
            // 
            // btnMQ1
            // 
            btnMQ1.Location = new Point(81, 51);
            btnMQ1.Name = "btnMQ1";
            btnMQ1.Size = new Size(275, 75);
            btnMQ1.TabIndex = 0;
            btnMQ1.Text = "button1";
            btnMQ1.UseVisualStyleBackColor = true;
            btnMQ1.Click += AnswerClicked;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 234, 34);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlTF);
            Controls.Add(pnlMQ);
            Controls.Add(pictureBox1);
            Controls.Add(lblScore);
            Controls.Add(lblQuestionTime);
            Controls.Add(lblQuestionContent);
            Controls.Add(lblQuestionTitle);
            Name = "GameForm";
            Text = "Game";
            Load += GameForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTF.ResumeLayout(false);
            pnlMQ.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestionTitle;
        private Label lblQuestionContent;
        private Label lblQuestionTime;
        private Label lblScore;
        private PictureBox pictureBox1;
        private Panel pnlTF;
        private Button btnTF1;
        private Button btnTF2;
        private Panel pnlMQ;
        private Button btnMQ4;
        private Button btnMQ3;
        private Button btnMQ2;
        private Button btnMQ1;
    }
}