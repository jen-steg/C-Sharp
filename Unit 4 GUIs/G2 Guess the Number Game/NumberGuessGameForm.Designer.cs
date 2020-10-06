﻿namespace NumberGuessGame
{
    partial class NumberGuessGameForm
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.guessInput = new System.Windows.Forms.TextBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(32, 21);
            this.instructionLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(198, 39);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "I have a number between 1 and 1000 -- can you guess my number? Please enter a gue" +
    "ss. [Whole numbers only]";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guessInput
            // 
            this.guessInput.AcceptsReturn = true;
            this.guessInput.Location = new System.Drawing.Point(35, 83);
            this.guessInput.Name = "guessInput";
            this.guessInput.Size = new System.Drawing.Size(84, 20);
            this.guessInput.TabIndex = 1;
            this.guessInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessInput_KeyDown);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(149, 80);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(81, 23);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Location = new System.Drawing.Point(35, 127);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(0, 13);
            this.notificationLabel.TabIndex = 3;
            this.notificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumberGuessGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.guessInput);
            this.Controls.Add(this.instructionLabel);
            this.Name = "NumberGuessGameForm";
            this.Text = "NumberGuessGameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox guessInput;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label notificationLabel;
    }
}

