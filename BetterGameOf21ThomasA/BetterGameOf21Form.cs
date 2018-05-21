﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        List<string> cCardDisplayed = new List<string>();
        List<string> pCardDisplayed = new List<string>();

        // Player score
        int pScore = 0;
        // Computer score
        int cScore = 0;

        // Create random number generator with min number
        Random randomNumberGenerator = new Random();

        // Create variable to hold random number
        int ranNumber;



        public frmBetterGameOf21()
        {
            InitializeComponent();
        }

        // Procedure for start button at beginning
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Hide start button
            btnStart.Hide();

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
                cScore += CardCounter(cCards[3]);
            }


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
            // Declare cardValue and set to -1000 (Error - Score will be very off)
            Image cardValue;

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
    }
}
