﻿namespace TriviaGame.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnStart = new Button();
            btnExit = new Button();
            label2 = new Label();
            lblScore = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 39);
            label1.Name = "label1";
            label1.Size = new Size(197, 45);
            label1.TabIndex = 0;
            label1.Text = "Trivia Game";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 15.75F);
            btnStart.Location = new Point(225, 157);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(326, 62);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15.75F);
            btnExit.Location = new Point(225, 234);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(326, 62);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(287, 108);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 3;
            label2.Text = "Best score:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblScore.Location = new Point(394, 108);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(45, 25);
            lblScore.TabIndex = 4;
            lblScore.Text = "XXX";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 236, 46);
            ClientSize = new Size(800, 450);
            Controls.Add(lblScore);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Trivia Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStart;
        private Button btnExit;
        private Label label2;
        private Label lblScore;
    }
}
