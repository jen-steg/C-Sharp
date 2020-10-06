// NumberGuessGameForm.cs
// Write a program that plays “guess the number” as follows: 
// Your program chooses the number to be guessed by selecting an int at random in the range 1–1000.
// Jennifer Stegina

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessGame
{
    public partial class NumberGuessGameForm : Form
    {
        // declare and initialize variables
        int secret = 0;
        int lastGuess = 0;
        bool firstGuess = true;

        // default constructor
        public NumberGuessGameForm()
        {
            InitializeComponent();
            GenerateSecretNumber();
        } // end constructor

        // randomly generate a secret number between 1 and 1000
        private void GenerateSecretNumber()
        {
            // create new instance of Random
            Random randomNumber = new Random();

            // define secret number
            secret = randomNumber.Next(1000) + 1;
        } // end method GenerateSecretNumber

        // read the user guess and determine if it matches the 
        // secret random number created
        private int CheckGuess(int guess)
        {
            // take in the guess and determine if it is too high, 
            // too low, or correct
            if(guess > secret) // guess is higher
            {
                return 1; 
            } // end if
            if(guess < secret) // guess is lower
            {
                return -1;
            } // end if
            else // guess is correct
            {
                return 0;
            } // end else
        } // end method CheckGuess

        private void guessInput_KeyDown(object sender, KeyEventArgs e)
        {
            // allow the user to press the enter key in TextBox
            if(e.KeyCode == Keys.Enter)
            {
                // take user guess input and set as an int
                int guess = Convert.ToInt32(guessInput.Text);

                // use Math to determine if the guess is higher or lower
                if (!firstGuess)
                {
                    if(Math.Abs(guess - secret) < 
                        Math.Abs (lastGuess - secret))
                        BackColor = Color.Red; // too high
                   else
                        BackColor = Color.LightBlue; // too low
                    
                } // end if
                firstGuess = false;

                // CheckGuess method returns 0 if correct,
                // -1 if too low, or 1 if too high
                int rightOrWrong = CheckGuess(guess);

                // if guess is correct
                if (rightOrWrong == 0)
                {
                    // output to the label that it was correct
                    notificationLabel.Text = "Correct Guess!";

                    // unlock the New Game Button for use
                    newGameButton.Enabled = true;

                    // lock the answer in the TextBox until the button is pressed
                    guessInput.ReadOnly = true;
                    BackColor = Color.LightGreen; // correct background color is green
                    firstGuess = true;
                } // end if
                else if (rightOrWrong == -1)
                {
                    // output to the label that it was wrong
                    notificationLabel.Text = "You're Too Low!";
                } // end else if
                else
                {
                    notificationLabel.Text = "You're Too High!";
                } // end else

                // clear the incorrect guess from the TextBox
                guessInput.SelectAll();
                lastGuess = guess;
            } // end if
        } // end method guessInput_KeyDown

        private void newGameButton_Click(object sender, EventArgs e)
        {
            // output that a new game is started
            notificationLabel.Text = "New Game Started!";
            // call the method to generate a new secret number
            GenerateSecretNumber();
            // lock the new game button until the user guesses correctly
            newGameButton.Enabled = false;
            // keep the TextBox unlocked until the user guesses correctly
            guessInput.ReadOnly = false;
            BackColor = Color.FromName("Control");
        } // end method newGameButton_Click
    } // end class NumberGuessGameForm
} // end namespace NumberGuessGame
