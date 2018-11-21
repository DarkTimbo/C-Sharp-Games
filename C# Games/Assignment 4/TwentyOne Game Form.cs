using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Low_Level_Objects_Library;
using Games_Logic_Library;

namespace Assignment_4 {
    public partial class TwentyOne_Game_Form : Form {

        /// <summary>
        /// Initializes the form.
        /// Changes the private varibles in twentyOne game logic, changing them to the default so that the game
        /// can be played from the start.
        /// </summary>
        
        public TwentyOne_Game_Form() {
            InitializeComponent();       
            Twenty_One_Game.SetupGame();
        }

      
        /// <summary>
        /// Updates the tableLayoutPanel inputed, getting the corresponding card picture that is in the selected hand.
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="tableLayoutPanel"></param>
        
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Set the PictureBox to use all of its space
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Images.GetCardImage(card);
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand

      
        /// <summary>
        /// Deals the two cards to the player and the dealer. These cards are then displayed on the GUI. 
        /// If the player starts with aces, they are prompted by a message box to determine their values.
        /// It then enables the stand and hit buttons so that the game may be played.
        /// The player and dealer totals are calculated and shown onto the GUI.
        /// It also determines weather or not the computer has won or lost just from the two cards it starts with.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DealButton_Click(object sender, EventArgs e) {

            const int player = 0, computer = 1;

            playerPointsLabel.Visible = true;
            dealerPointsLabel.Visible = true;

            Reset();
       
            NumberOfAcesLabel.Text = Twenty_One_Game.GetNumOfUserAcesWithValueOne().ToString();        
           
            StartGame();

            displayHands();

            CheckStartWithAces();

            DealButton.Enabled = false;
            StandButton.Enabled = true;
            HitButton.Enabled = true;

            Twenty_One_Game.CalculateHandTotal(player);
            Twenty_One_Game.CalculateHandTotal(computer);

            WonOrLostAtStart();
       
            playerPointsLabel.Text = Twenty_One_Game.GetTotalPoints(player).ToString();
            dealerPointsLabel.Text = Twenty_One_Game.GetTotalPoints(computer).ToString();

        }//end DealButton_Click()

     
        /// <summary>
        /// Adds a card to the players hand. It stops the player from adding cards if it reachs to 8.
        /// It caluclates the total value of those cards and puts it into the playerPointsLabel.
        /// It also checks if the player has gone over the winning value of 21. If so, the player is busted, the playerBusted label
        /// becomes visible and the deal button is enable, allowing for a new round to start.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void HitButton_Click(object sender, EventArgs e) {

            const int maxNumberOfCards = 8;

            const int player = 0; 
                 

            if (Twenty_One_Game.GetHand(player).GetCount()-1 < maxNumberOfCards) {

                Twenty_One_Game.DealOneCardTo(player);

                displayHands();

                checkForAce();

            }
            else {
                MessageBox.Show("You can't have any more cards");
            }

            Twenty_One_Game.CalculateHandTotal(player);
            playerPointsLabel.Text = Twenty_One_Game.GetTotalPoints(player).ToString();

            isPlayerBusted();

        }//end HitButton_Click


        /// <summary>
        /// Once the player clicks the stand button, the dealer plays for himself. It stops the player adding cards or making the computer play more
        /// than once. The computer adds cards until it is either greater than 17, higher than the player or equal to 21. These cards and total of the card
        /// points are then shown onto the GUI. It checks if the previous conditions are met and decides if the dealer won or lost the game. The deal button
        /// is then enabled to start a new round.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void StandButton_Click(object sender, EventArgs e) {

            const int computer = 1;

            HitButton.Enabled = false;
            StandButton.Enabled = false;

            Twenty_One_Game.PlayForDealer();

            displayHands();
          
            Twenty_One_Game.CalculateHandTotal(computer);

            dealerPointsLabel.Text = Twenty_One_Game.GetTotalPoints(computer).ToString();

            DealerWinConditions();

            DealButton.Enabled = true;
           
        }//end StandButton_Click


       /// <summary>
       /// Decides if overall the dealer or player won the most amount of games. If the player won more total games it displays it in a message box for the user.
       /// Like wise if the dealer won more or if the total amount of wins is a draw. Once the user clicks ok, the form is closed so that they may change the game they
       /// want to play.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>

        private void CancelGameButton_Click(object sender, EventArgs e) {

            const int player = 0, computer = 1;

            if (Twenty_One_Game.GetNumOfGamesWon(player) > Twenty_One_Game.GetNumOfGamesWon(computer)) {

                DialogResult = MessageBox.Show("You won! Well done","Exit Message",MessageBoxButtons.OK);

                if(DialogResult == DialogResult.OK) {

                    this.Close();
                }
            }

            else if(Twenty_One_Game.GetNumOfGamesWon(player) < Twenty_One_Game.GetNumOfGamesWon(computer)) {

                DialogResult = MessageBox.Show("House won! Better luck next time", "Exit Message", MessageBoxButtons.OK);

                if (DialogResult == DialogResult.OK) {

                    this.Close();
                }
            }
            else {

                DialogResult = MessageBox.Show("It was a draw!", "Exit Message", MessageBoxButtons.OK);
                if (DialogResult == DialogResult.OK) {

                    this.Close();
                }
            }

        }//end CancelGameButton_Click


        //-----------------------------------------------------------------------------------------------------------------------------------------------------


            /// <summary>
            /// Deals the two cards to both the computer and the player at the start of a game.
            /// </summary>
  
        private static void StartGame() {

            const int player = 0, computer = 1;

            Twenty_One_Game.DealOneCardTo(player);
            Twenty_One_Game.DealOneCardTo(player);
            Twenty_One_Game.DealOneCardTo(computer);
            Twenty_One_Game.DealOneCardTo(computer);

        }//end StartGame()


        /// <summary>
        /// Checks the first two dealt cards at the beginning of a game if they are aces. If one of them is an Ace, a message box prompts them to decide the value of that Ace.
        /// If both of them are aces, Two messages boxs are created to decide their values. 
        /// These values are then recorded in the numberOfAcesWithValueOne label depending on their answer.
        /// </summary>
        
        private void CheckStartWithAces() {

            const int player = 0;
            const int firstCard = 0, secondCard = 1;

            if ((Twenty_One_Game.GetHand(player).GetCard(firstCard).GetFaceValue() == FaceValue.Ace) ||(Twenty_One_Game.GetHand(player).GetCard(secondCard).GetFaceValue() == FaceValue.Ace)) {
                DialogResult result = MessageBox.Show("Count Aces as 1?", "You got an Ace!",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    Twenty_One_Game.IncrementNumOfUserAcesWithValueOne();
                    NumberOfAcesLabel.Text = Twenty_One_Game.GetNumOfUserAcesWithValueOne().ToString();
                }
            }
            else if ((Twenty_One_Game.GetHand(player).GetCard(firstCard).GetFaceValue() == FaceValue.Ace) && (Twenty_One_Game.GetHand(player).GetCard(secondCard).GetFaceValue() == FaceValue.Ace)) {
                int repeat = 0;
                while (repeat != 2) {
                    DialogResult result = MessageBox.Show("Count Aces as 1?", "You got an Ace!",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) {
                        Twenty_One_Game.IncrementNumOfUserAcesWithValueOne();
                        NumberOfAcesLabel.Text = Twenty_One_Game.GetNumOfUserAcesWithValueOne().ToString();
                        repeat++;
                    }
                }
            }

        }// end CheckStartWithAces()


        /// <summary>
        /// Uses the DisplayGui Method, changing the the tableLayoutPanels to display the corresponding picture of the cards in the hands
        /// of the player and the dealer.
        /// </summary>

        private void displayHands() {

            const int player = 0, computer = 1;

            DisplayGuiHand(Twenty_One_Game.GetHand(computer), dealerTableLayoutPanel);
            DisplayGuiHand(Twenty_One_Game.GetHand(player), playerTableLayoutPanel);

        }//end displayHands()


        /// <summary>
        /// Resest the private variables in the twenty-one game logic.
        /// Changes the pointslabels back to 0 and removes makes the busted labels invisible. 
        /// </summary>

        private void Reset() {

            Twenty_One_Game.ResetTotals();
            dealerPointsLabel.Text = 0.ToString();
            playerPointsLabel.Text = 0.ToString();
            playerBustedLabel.Visible = false;
            dealerBustedLabel.Visible = false;

        }//end Reset()


        /// <summary>
        /// Determines if the playe or computer has won from the starting deal of cards. If the dealer goes over 21 on the dealing of cards,
        /// the player wins and changes the number of games won label. It then resets the buttons to when the game first starts up. IF the dealer
        /// gets 21 on its dealing of cards, it instantly wins, changing the amount of wins label for it and reseting the buttons.
        /// </summary>

        private void WonOrLostAtStart() {

            const int winningState = 21;
            const int player = 0, computer = 1;

            if (Twenty_One_Game.GetTotalPoints(computer) > winningState) {
                playerNumWinsLabel.Text = Twenty_One_Game.GetNumOfGamesWon(player).ToString();
                DealButton.Enabled = true;
                StandButton.Enabled = false;
                HitButton.Enabled = false;
            }
            else if (Twenty_One_Game.GetTotalPoints(computer) == winningState) {

                dealerNumWinsLabel.Text = Twenty_One_Game.GetNumOfGamesWon(computer).ToString();
                StandButton.Enabled = false;
                HitButton.Enabled = false;
                DealButton.Enabled = true;
            }

        }//end WonOrLostAtStart()


        /// <summary>
        /// Checks the newest card added to the hand and determines if it is an Ace. If it is an Ace, a message box is shown and asks if the player
        /// wants the ace to equal a 1. If the player says yes, the numberOfAcesWithValueOne is incremented and its new value is printed through
        /// the numberOfAcesLbel.
        /// </summary>

        private void checkForAce() {

            const int player = 0;
        
            if (Twenty_One_Game.GetHand(player).GetCard(Twenty_One_Game.GetHand(player).GetCount() - 1).GetFaceValue() == FaceValue.Ace) {


                DialogResult result = MessageBox.Show("Count Aces as 1?", "You got an Ace!",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {

                    Twenty_One_Game.IncrementNumOfUserAcesWithValueOne();
                    NumberOfAcesLabel.Text = Twenty_One_Game.GetNumOfUserAcesWithValueOne().ToString();

                }
            }

        }//end checkForAce()


        /// <summary>
        /// Checks to see if the totalpoints of the player is greater than 21. IF it is, it resets the button to the default and
        /// makes the busted label visible. It then adds a win to the computers label.
        /// </summary>

        private void isPlayerBusted() {

            const int player = 0, computer = 1;
            const int winningState = 21;

            if (Twenty_One_Game.GetTotalPoints(player) > winningState) {

                HitButton.Enabled = false;

                playerBustedLabel.Visible = true;

                DealButton.Enabled = true;

                StandButton.Enabled = false;

                dealerNumWinsLabel.Text = Twenty_One_Game.GetNumOfGamesWon(computer).ToString();

            }

        }//end isPLayerBusted()


        /// <summary>
        /// Checks to see if the dealer has won. If it is greater than the total points of the player and it hasen't gone over the winning state of 21, it changes the dealersNumWinsLabel
        /// to add one onto it. If it has gone over the winning state, it adds one onto the playerNumWinsLabel and shows the dealer busted through the dealerBustedLabel becoming visible.
        /// </summary>

        private void DealerWinConditions() {

            const int player = 0, computer = 1;
            const int winningState = 21;

            if (Twenty_One_Game.GetTotalPoints(computer) > Twenty_One_Game.GetTotalPoints(player) && (Twenty_One_Game.GetTotalPoints(computer) <= winningState)) {

                dealerNumWinsLabel.Text = Twenty_One_Game.GetNumOfGamesWon(computer).ToString();

            }

            else if (Twenty_One_Game.GetTotalPoints(computer) > winningState) {

                playerNumWinsLabel.Text = Twenty_One_Game.GetNumOfGamesWon(player).ToString();
                dealerBustedLabel.Visible = true;
            }

        }//end DealerWinConditions()

    }//end class

}//end namespace
