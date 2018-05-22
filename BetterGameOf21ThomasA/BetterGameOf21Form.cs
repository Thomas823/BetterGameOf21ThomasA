/*
 * Created by: Thomas Aubin
 * Created on: 21 May, 2018
 * Created for: ICS3U Programming
 * Assignment #6b - A Better Game Of 21
 * This program plays blackjack with the player (computer operator), versus the computer
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Add Sound Library
using System.Media;

namespace BetterGameOf21ThomasA
{
    public partial class frmBetterGameOf21 : Form
    {

        // Constant min number for generator
        const int MIN_VALUE = 0;

        // Create full deck of cards (Constant)
        List<string> FULLDECK = new List<string>()
            {"SA","S2","S3","S4","S5","S6","S7","S8","S9","S10","SJ","SQ","SK",
            "HA", "H2","H3","H4","H5","H6","H7","H8","H9","H10","HJ","HQ","HK",
            "DA","D2","D3","D4","D5","D6","D7","D8","D9","D10","DJ","DQ","DK",
            "CA","C2","C3","C4","C5","C6","C7","C8","C9","C10","CJ","CQ","CK"};
        // Create empty list to hold cards in game
        List<string> gameCards = new List<string>();

        // Player's cards list
        List<string> pCards = new List<string>();
        // Computer's cards list
        List<string> cCards = new List<string>();

        // Create list to hold image of cards for player and computer
        List<Image> cCardDisplayed = new List<Image>() { Properties.Resources.red_back, Properties.Resources.red_back, Properties.Resources.red_back };
        List<Image> pCardDisplayed = new List<Image>() { Properties.Resources.blue_back, Properties.Resources.blue_back, Properties.Resources.blue_back };

        // Player score
        int pScore = 0;
        // Computer score
        int cScore = 0;

        // if a third card has been created already for player
        bool alreadyGenerated = false;

        // Create random number generator with min number
        Random randomNumberGenerator = new Random();

        // Create variable to hold random number
        int ranNumber;

        // Load Sounds
        SoundPlayer cheering = new SoundPlayer(Properties.Resources.Cheering);
        SoundPlayer whaWha = new SoundPlayer(Properties.Resources.Wha_Wha);
        SoundPlayer ooh = new SoundPlayer(Properties.Resources.Ooh);



        public frmBetterGameOf21()
        {
            InitializeComponent();

            // Hide score text, winner text, and new game button
            lblComTotal.Hide();
            lblPlyTotal.Hide();
            lblResults.Hide();
            btnNewGame.Hide();
        }

        // Procedure for start button at beginning
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Hide start button
            btnResults.Hide();

            // Change background to play the game
            picBackground.Image = Properties.Resources.GameBackground;

            // Setup new deck
            RestartCards();

            // Start game
            Game();
        }

        // Procedure for start menu item 'Exit'
        private void mniExit_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }

        // Procedure to restart cards
        private void RestartCards()
        {
            gameCards.AddRange(FULLDECK);
        }

        // Start blackjack
        private void Game()
        {
            // Generate first card for computer (0 to all cards in gameCards), save index(random number), and then add card chosen from gameCards to cCards
            cCards.Add(gameCards[ranNumber = randomNumberGenerator.Next(MIN_VALUE, gameCards.Count() - 1)]);
            // Remove card from gameCards
            gameCards.RemoveAt(ranNumber);

            // Generate second card for computer (0 to all cards in gameCards), save index(random number), and then add card chosen from gameCards to cCards
            cCards.Add(gameCards[ranNumber = randomNumberGenerator.Next(MIN_VALUE, gameCards.Count() - 1)]);
            // Remove card from gameCards
            gameCards.RemoveAt(ranNumber);

            // Find card score of new cards and add to cScore
            cScore += CardCounter(cCards[0]);
            cScore += CardCounter(cCards[1]);

            // If the computer has a score les then 17 (Probability of not busting)
            if (cScore < 17)
            {
                // Generate third card for computer (0 to all cards in gameCards), save index(random number), and then add card chosen from gameCards to cCards
                cCards.Add(gameCards[ranNumber = randomNumberGenerator.Next(MIN_VALUE, gameCards.Count() - 1)]);
                // Remove card from gameCards
                gameCards.RemoveAt(ranNumber);

                // Find card score of new cards and add to cScore
                cScore += CardCounter(cCards[2]);

                // Get images of card by calling CardDisplayed function, sending string of card, returning image and storing in list for computer
                cCardDisplayed[2] = CardDisplayed(cCards[2]);

                // Set image to be displayed
                picCom3.Image = cCardDisplayed[2];

                // Show third card for computer
                picCom3.Show();
            }
            else
            {
                // Hide third card if not needed
                picCom3.Hide();
            }

            // Get images of card by calling CardDisplayed function, sending string of card, returning image and storing in list for computer
            cCardDisplayed[0] = CardDisplayed(cCards[0]);
            cCardDisplayed[1] = CardDisplayed(cCards[1]);

            // Set image to be displayed for computer
            picCom1.Image = cCardDisplayed[0];
            picCom2.Image = cCardDisplayed[1];

            // Show first and second card for computer
            picCom1.Show();
            picCom2.Show();


            // Generate first card for player (0 to all cards in gameCards), save index(random number), and then add card chosen from gameCards to pCards
            pCards.Add(gameCards[ranNumber = randomNumberGenerator.Next(MIN_VALUE, gameCards.Count() - 1)]);
            // Remove card from gameCards
            gameCards.RemoveAt(ranNumber);

            // Generate second card for player (0 to all cards in gameCards), save index(random number), and then add card chosen from gameCards to pCards
            pCards.Add(gameCards[ranNumber = randomNumberGenerator.Next(MIN_VALUE, gameCards.Count() - 1)]);
            // Remove card from gameCards
            gameCards.RemoveAt(ranNumber);

            // Find card score of new cards and add to pScore
            pScore += CardCounter(pCards[0]);
            pScore += CardCounter(pCards[1]);

            // Get images of card by calling CardDisplayed function, sending string of card, returning image and storing in list for player
            pCardDisplayed[0] = CardDisplayed(pCards[0]);
            pCardDisplayed[1] = CardDisplayed(pCards[1]);

            // Set image to be displayed for computer
            picPly1.Image = pCardDisplayed[0];
            picPly2.Image = pCardDisplayed[1];
            picPly3.Image = Properties.Resources.blue_back;

            // Show first, second, and third card for player
            picPly1.Show();
            picPly2.Show();
            picPly3.Show();

            // Show hit prompt
            lblHitPrompt.Show();
            // Show stay button
            btnStay.Show();
        }

        // Function to calculate value of cards
        private int CardCounter(string cardInput)
        {
            // Declare cardValue and set to -1000 (Error - Score will be very off)
            int cardValue = -1000;

            // Switch statement to determine value of card
            switch (cardInput)
            {
                // Cycle through all posibilities. If .. set value...
                case "SA":
                    // Ace of spades has a value of 1
                    cardValue = 1;
                    // End switch statement
                    break;
                case "S2":
                    cardValue = 2;
                    break;
                case "S3":
                    cardValue = 3;
                    break;
                case "S4":
                    cardValue = 4;
                    break;
                case "S5":
                    cardValue = 5;
                    break;
                case "S6":
                    cardValue = 6;
                    break;
                case "S7":
                    cardValue = 7;
                    break;
                case "S8":
                    cardValue = 8;
                    break;
                case "S9":
                    cardValue = 9;
                    break;
                case "S10":
                    cardValue = 10;
                    break;
                case "SJ":
                    cardValue = 10;
                    break;
                case "SQ":
                    cardValue = 10;
                    break;
                case "SK":
                    cardValue = 10;
                    break;
                case "HA":
                    cardValue = 1;
                    break;
                case "H2":
                    cardValue = 2;
                    break;
                case "H3":
                    cardValue = 3;
                    break;
                case "H4":
                    cardValue = 4;
                    break;
                case "H5":
                    cardValue = 5;
                    break;
                case "H6":
                    cardValue = 6;
                    break;
                case "H7":
                    cardValue = 7;
                    break;
                case "H8":
                    cardValue = 8;
                    break;
                case "H9":
                    cardValue = 9;
                    break;
                case "H10":
                    cardValue = 10;
                    break;
                case "HJ":
                    cardValue = 10;
                    break;
                case "HQ":
                    cardValue = 10;
                    break;
                case "HK":
                    cardValue = 10;
                    break;
                case "DA":
                    cardValue = 1;
                    break;
                case "D2":
                    cardValue = 2;
                    break;
                case "D3":
                    cardValue = 3;
                    break;
                case "D4":
                    cardValue = 4;
                    break;
                case "D5":
                    cardValue = 5;
                    break;
                case "D6":
                    cardValue = 6;
                    break;
                case "D7":
                    cardValue = 7;
                    break;
                case "D8":
                    cardValue = 8;
                    break;
                case "D9":
                    cardValue = 9;
                    break;
                case "D10":
                    cardValue = 10;
                    break;
                case "DJ":
                    cardValue = 10;
                    break;
                case "DQ":
                    cardValue = 10;
                    break;
                case "DK":
                    cardValue = 10;
                    break;
                case "CA":
                    cardValue = 1;
                    break;
                case "C2":
                    cardValue = 2;
                    break;
                case "C3":
                    cardValue = 3;
                    break;
                case "C4":
                    cardValue = 4;
                    break;
                case "C5":
                    cardValue = 5;
                    break;
                case "C6":
                    cardValue = 6;
                    break;
                case "C7":
                    cardValue = 7;
                    break;
                case "C8":
                    cardValue = 8;
                    break;
                case "C9":
                    cardValue = 9;
                    break;
                case "C10":
                    cardValue = 10;
                    break;
                case "CJ":
                    cardValue = 10;
                    break;
                case "CQ":
                    cardValue = 10;
                    break;
                case "CK":
                    cardValue = 10;
                    break;
                // If none happen
                default:
                    // End switch statement
                    break;
            }
           
            // Return value of card
            return cardValue;
        }

        // Function to calculate value of cards
        private Image CardDisplayed(string cardInput)
        {
            // Declare cardImage to store image of card to return
            Image cardImage = Properties.Resources.gray_back;

            // Switch statement to determine image of card
            switch (cardInput)
            {
                // Cycle through all posibilities. If .. set value...
                case "SA":
                    // Ace of spades to picture of ace of spades (AS)
                    cardImage = Properties.Resources.AS;
                    // End switch statement
                    break;
                case "S2":
                    cardImage = Properties.Resources._2S;
                    break;
                case "S3":
                    cardImage = Properties.Resources._3S;
                    break;
                case "S4":
                    cardImage = Properties.Resources._4S;
                    break;
                case "S5":
                    cardImage = Properties.Resources._5S;
                    break;
                case "S6":
                    cardImage = Properties.Resources._6S;
                    break;
                case "S7":
                    cardImage = Properties.Resources._7S;
                    break;
                case "S8":
                    cardImage = Properties.Resources._8S;
                    break;
                case "S9":
                    cardImage = Properties.Resources._9S;
                    break;
                case "S10":
                    cardImage = Properties.Resources._10S;
                    break;
                case "SJ":
                    cardImage = Properties.Resources.JS;
                    break;
                case "SQ":
                    cardImage = Properties.Resources.QS;
                    break;
                case "SK":
                    cardImage = Properties.Resources.KS;
                    break;
                case "HA":
                    cardImage = Properties.Resources.AH;
                    break;
                case "H2":
                    cardImage = Properties.Resources._2H;
                    break;
                case "H3":
                    cardImage = Properties.Resources._3H;
                    break;
                case "H4":
                    cardImage = Properties.Resources._4H;
                    break;
                case "H5":
                    cardImage = Properties.Resources._5H;
                    break;
                case "H6":
                    cardImage = Properties.Resources._6H;
                    break;
                case "H7":
                    cardImage = Properties.Resources._7H;
                    break;
                case "H8":
                    cardImage = Properties.Resources._8H;
                    break;
                case "H9":
                    cardImage = Properties.Resources._9H;
                    break;
                case "H10":
                    cardImage = Properties.Resources._10H;
                    break;
                case "HJ":
                    cardImage = Properties.Resources.JH;
                    break;
                case "HQ":
                    cardImage = Properties.Resources.QH;
                    break;
                case "HK":
                    cardImage = Properties.Resources.KH;
                    break;
                case "DA":
                    cardImage = Properties.Resources.AD;
                    break;
                case "D2":
                    cardImage = Properties.Resources._2D;
                    break;
                case "D3":
                    cardImage = Properties.Resources._3D;
                    break;
                case "D4":
                    cardImage = Properties.Resources._4D;
                    break;
                case "D5":
                    cardImage = Properties.Resources._5D;
                    break;
                case "D6":
                    cardImage = Properties.Resources._6D;
                    break;
                case "D7":
                    cardImage = Properties.Resources._7D;
                    break;
                case "D8":
                    cardImage = Properties.Resources._8D;
                    break;
                case "D9":
                    cardImage = Properties.Resources._9D;
                    break;
                case "D10":
                    cardImage = Properties.Resources._10D;
                    break;
                case "DJ":
                    cardImage = Properties.Resources.JD;
                    break;
                case "DQ":
                    cardImage = Properties.Resources.QD;
                    break;
                case "DK":
                    cardImage = Properties.Resources.KD;
                    break;
                case "CA":
                    cardImage = Properties.Resources.AC;
                    break;
                case "C2":
                    cardImage = Properties.Resources._2C;
                    break;
                case "C3":
                    cardImage = Properties.Resources._3C;
                    break;
                case "C4":
                    cardImage = Properties.Resources._4C;
                    break;
                case "C5":
                    cardImage = Properties.Resources._5C;
                    break;
                case "C6":
                    cardImage = Properties.Resources._6C;
                    break;
                case "C7":
                    cardImage = Properties.Resources._7C;
                    break;
                case "C8":
                    cardImage = Properties.Resources._8C;
                    break;
                case "C9":
                    cardImage = Properties.Resources._9C;
                    break;
                case "C10":
                    cardImage = Properties.Resources._10C;
                    break;
                case "CJ":
                    cardImage = Properties.Resources.JC;
                    break;
                case "CQ":
                    cardImage = Properties.Resources.QC;
                    break;
                case "CK":
                    cardImage = Properties.Resources.KC;
                    break;
                // If none happen
                default:
                    // End switch statement
                    break;
            }

            // Return value of card
            return cardImage;
        }

        // Procedure to hit for another card (player)
        private void picPly3_Click(object sender, EventArgs e)
        {
            if (alreadyGenerated == false)
            {
                // Generate third card for player (0 to all cards in gameCards), save index(random number), and then add card chosen from gameCards to pCards
                pCards.Add(gameCards[ranNumber = randomNumberGenerator.Next(MIN_VALUE, gameCards.Count() - 1)]);
                // Remove card from gameCards
                gameCards.RemoveAt(ranNumber);

                // Find card score of new cards and add to pScore
                pScore += CardCounter(pCards[2]);

                // Get images of card by calling CardDisplayed function, sending string of card, returning image and storing in list for player
                pCardDisplayed[2] = CardDisplayed(pCards[2]);

                // Set image to be displayed
                picPly3.Image = pCardDisplayed[2];

                // Make sure another card is not generated
                alreadyGenerated = true;
            }

            // Hide stay button
            btnStay.Hide();

            // Continue game
            ContinueGame();
        }

        // Procedure if player wants to stay
        private void btnStay_Click(object sender, EventArgs e)
        {
            // Hide third card and stay button
            picPly3.Hide();
            btnStay.Hide();

            // Continue game
            ContinueGame();
        }

        private void ContinueGame()
        {
            // Hide card hit reminder
            lblHitPrompt.Hide();

            // Set player and computer's total to display
            lblPlyTotal.Text = "Player's Total: " + pScore;
            lblComTotal.Text = "Computer's Total: " + cScore;

            // Show scores
            lblPlyTotal.Show();
            lblComTotal.Show();

            // Find who won. Either Bust, Tie, Blackjack, or who has greater
            if (cScore > 21 && pScore > 21)
            {
                // Both Bust and Dealer wins
                lblResults.Text = "You Both Busted! The Computer Wins!";

                // Play OMG lose sound
                ooh.Play();

                // Increase win count to who won
                //computerWinCount++;
            }
            else if (pScore > 21)
            {
                // Set player to bust and computer to winner
                lblResults.Text = "The Player Busted! The Computer Wins!";

                //Play lose sound
                whaWha.Play();

                // Increase win count to who won
                //computerWinCount++;
            }
            else if (cScore > 21)
            {
                // Set computer to bust and player to winner
                lblResults.Text = "The Computer Busted! The Player Wins!";

                // Play win sound
                cheering.Play();

                // Increase win count to who won
                //playerWinCount++;
            }
            else if (pScore == cScore)
            {
                // Set a tie
                lblResults.Text = "It's a Tie! No One Wins!";

                // Play OMG lose sound
                ooh.Play();
            }
            else if (pScore == 21)
            {
                // Player has blackjack!
                lblResults.Text = "The Player Got BlackJack! The Player Wins!";

                // Play win sound
                cheering.Play();

                // Increase win count to who won
                //playerWinCount++;
            }
            else if (cScore == 21)
            {
                // Computer has blackjack!
                lblResults.Text = "The Computer Got BlackJack! The Computer Wins!";

                // Play lose sound
                whaWha.Play();

                // Increase win count to who won
                //computerWinCount++;
            }
            else if (pScore > cScore)
            {
                // Player won!
                lblResults.Text = "The Player Got A Higher Number. The Player Wins!";

                // Play win sound
                cheering.Play();

                // Increase win count to who won
                //playerWinCount++;
            }
            else
            {
                // Computer won!
                lblResults.Text = "The Computer Got A Higher Number. The Computer Wins!";

                // Play lose sound
                whaWha.Play();

                // Increase win count to who won
                //computerWinCount++;
            }

            // Show results text
            lblResults.Show();

            // Show new game button
            btnNewGame.Show();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Call new game procedure to restart
            NewGame();
        }

        // Menu button for a new game
        private void mniNewGame_Click(object sender, EventArgs e)
        {
            // Call new game procedure to restart
            NewGame();
        }

        // To restart the game
        private void NewGame()
        {
            // Hide new button, scores, and winner
            btnNewGame.Hide();
            lblComTotal.Hide();
            lblPlyTotal.Hide();
            lblResults.Hide();

            // Clear player's and computer's card list
            cCards.Clear();
            pCards.Clear();

            // Reset scores
            cScore = 0;
            pScore = 0;

            // Allow for a third card again
            alreadyGenerated = false;

            // If there is less then 6 cards in the deck
            if (gameCards.Count < 6)
            {
                // Tell the user a new deck is served
                MessageBox.Show("You ran out of cards, a new deck is served");

                // Clear gamecards
                gameCards.Clear();

                // Grab a new deck
                RestartCards();
            }

            Game();
        }
    }
}
