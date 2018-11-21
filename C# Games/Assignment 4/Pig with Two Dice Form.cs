using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games_Logic_Library;

namespace Assignment_4 {
    public partial class Pig_with_Two_Dice_Form : Form {

        int currentPlayer = 0;
        int counter = 0;

        
      /// <summary>
      /// Initializes the form.
      /// Setsup the game logic class to equal the default values of the private variables within it so that the
      /// game can start from the beginning. The picture boxes are then given random pictures for the time being
      /// to show that the game is working. It also makes sure that the score boxes are turned to 0 and that the 
      /// turn label is equal to player one, so that the game runs properally.
      /// </summary>
      
        public Pig_with_Two_Dice_Form() {
            InitializeComponent();
            Pig_Two_Die_Game.SetupGame();
            updatePicture();           
            playerOneScoreTextBox.Text = "0";
            playerTwoScoreTextBox.Text = "0";
            WhoseTurnLabel.Text = Pig_Two_Die_Game.GetFirstPlayersName();

        }

        /// <summary>
        /// Starts the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void rollButton_Click(object sender, EventArgs e) {
            counter = 0;
            rollButton.Enabled = false;
            holdButton.Enabled = false;
            timer.Start();

        }//end RollButton_Click


        /// <summary>
        /// When the hold button is clicked, the current player is changed to the other player. It displays their score and tell the next player its
        /// their turn by changing the WhoseTurnLabel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void holdButton_Click(object sender, EventArgs e) {

            const int player1 = 0, player2 = 1;

            if (currentPlayer == player1) {
                currentPlayer = player2;
                playerOneScoreTextBox.Text =Pig_Two_Die_Game.GetPointsTotal("hold").ToString();
                WhoseTurnLabel.Text = Pig_Two_Die_Game.GetNextPlayersName();

            }
            else {
                currentPlayer = player1;
                playerTwoScoreTextBox.Text = Pig_Two_Die_Game.GetPointsTotal("hold").ToString();
                WhoseTurnLabel.Text = Pig_Two_Die_Game.GetFirstPlayersName();
            }

        }//end holdButton_Click


        /// <summary>
        /// Determines if the player wants to play another game. If they select the yesRadioButton, the game is setup again,
        /// reverting the score texts boxes back to zero and the whoseTrunLabel to player one. It then disables the anotherGameGroupBox
        /// and disables the hold button. If they select the noRadioButton, the form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void anotherGameGroupBox_Enter(object sender, EventArgs e) {

            const int player1 = 0;

            if (yesRadioButton.Checked == true) {
                Pig_Two_Die_Game.SetupGame();
                yesRadioButton.Checked = false;
                playerOneScoreTextBox.Text = "0";
                playerTwoScoreTextBox.Text = "0";
                WhoseTurnLabel.Text = Pig_Two_Die_Game.GetFirstPlayersName();
                anotherGameGroupBox.Enabled = false;
                currentPlayer = player1;
                holdButton.Enabled = false;
                rollButton.Enabled = true ;
            }
            if (noRadioButton.Checked == true) {

                this.Close();

            }

        }//end anotherGameGroupBox


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Updates the picturebox to the image of the dice just rolled
        /// </summary>

        void updatePicture() {

            const int Die1 = 1, Die2 = 2;

            pictureBox1.Image = Images.GetDieImage(Pig_Two_Die_Game.GetFaceValue(Die1));
            pictureBox2.Image = Images.GetDieImage(Pig_Two_Die_Game.GetFaceValue(Die2));

        }//end updatePicture


        /// <summary>
        /// Rolls both the dice from the game logic class. If either of the dice rolled a one, it swtiches the player
        /// and creates a message box telling them what their score will revert to. Depending on who is playing, it will
        /// keep updating that persons totalpoints textbox. It then determines weather or not either of the people have
        /// reached the winning state of 100, if so a message box shows who won and enables the anotherGameGroupBox.
        /// </summary>

        private void PlayRollDice() {

            bool rolledOne;
            const int player1 = 0;

            holdButton.Enabled = true;
            rollButton.Enabled = true;

            rolledOne = Pig_Two_Die_Game.PlayGame();
            updatePicture();

            if (rolledOne) {

                switchPlayer();

            }

            if (currentPlayer == player1) {
                playerOneScoreTextBox.Text = Pig_Two_Die_Game.GetPointsTotal("show current").ToString();

            }
            else {
                playerTwoScoreTextBox.Text = Pig_Two_Die_Game.GetPointsTotal("show current").ToString();
            }

            hasSomeoneWon();

        }//end PlayRollDice


        /// <summary>
        /// Checks to see if someone has won the game by checking the int value inside the players textbox
        /// If it is over 100 points, a message box is created and displays the person who won.
        /// </summary>

        private void hasSomeoneWon() {

            const int winningValue = 100;

            if (Pig_Two_Die_Game.HasWon()) {

                if (int.Parse(playerOneScoreTextBox.Text) >= winningValue) {
                    MessageBox.Show("Player One has won");
                    anotherGameGroupBox.Enabled = true;


                }
                else {
                    MessageBox.Show("Player two has won");
                    anotherGameGroupBox.Enabled = true;
                }
                holdButton.Enabled = false;
                rollButton.Enabled = false;
            }
            
        }//end hasSomeoneWon



        /// <summary>
        /// Everytime the counter ticks, a random picture a dice is shown on both the pictureBoxes.
        /// Once the timer reaches 11 ticks, the game is played for a roll, changing their pictures to what
        /// what actually rolled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timer_Tick(object sender, EventArgs e) {

            counter++;
            int die1, die2;
            Random roll = new Random();

            if (counter < 11) {
                die1 = roll.Next(1, 7);
                die2 = roll.Next(1, 7);
                pictureBox1.Image = Images.GetDieImage(die1);
                pictureBox2.Image = Images.GetDieImage(die2);

            }
            else {
                timer.Stop();
                PlayRollDice();
               
            }

        }//end timer_Tick


        /// <summary>
        /// If the current person is the first player, it tell them that they must have rolled a one and tells them what their score reverts to. 
        /// This is then changed to their scoreTextBox.
        /// The player is then swtiched and the next persons name is changed onto the WhoseTurnLabel.
        /// </summary>

        private void switchPlayer() {

            const int player1 = 0;

            if (currentPlayer == player1) {
                MessageBox.Show("Sorry you have thrown a 1 \nYour turn is over" + "\n your score reverts to " + Pig_Two_Die_Game.GetPointsTotal("player one").ToString());
                playerOneScoreTextBox.Text = Pig_Two_Die_Game.GetPointsTotal("player one").ToString();
                currentPlayer += 1;
                WhoseTurnLabel.Text = Pig_Two_Die_Game.GetNextPlayersName();

            }
            else {
                MessageBox.Show("Sorry you have thrown a 1 \nYour turn is over" + "\n your score reverts to " + Pig_Two_Die_Game.GetPointsTotal("player two").ToString());
                playerTwoScoreTextBox.Text = Pig_Two_Die_Game.GetPointsTotal("player two").ToString();
                currentPlayer -= 1;
                WhoseTurnLabel.Text = Pig_Two_Die_Game.GetFirstPlayersName();
            }

        }//end switchPlayer

    }//end class
    
}//end namespace
