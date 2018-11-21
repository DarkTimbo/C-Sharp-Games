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
    public partial class Pig_Game_Form : Form {

        int currentPlayer = 0;
       
        public Pig_Game_Form() {
            InitializeComponent();
            Pig_Single_Die_Game.SetupGame();
            updatePicture();
            playerOneScoreTextBox.Text = "0";
            playerTwoScoreTextBox.Text = "0";
            WhoseTurnLabel.Text = Pig_Single_Die_Game.GetFirstPlayersName(); 
        }

        private void updatePicture() {
            pictureBox1.Image = Images.GetDieImage(Pig_Single_Die_Game.GetFaceValue());
        }

        private void rollButton_Click(object sender, EventArgs e) {
            bool rolledOne;
            holdButton.Enabled = true;
            rolledOne = Pig_Single_Die_Game.PlayGame();
            updatePicture();
            if (rolledOne) {

                RolledOneMessages();

            }
            if (currentPlayer == 0) {
                playerOneScoreTextBox.Text = Pig_Single_Die_Game.GetPointsTotal("show current").ToString();
            }
            else  {
                playerTwoScoreTextBox.Text = Pig_Single_Die_Game.GetPointsTotal("show current").ToString();
            }
            if (Pig_Single_Die_Game.HasWon()){
                rollButton.Enabled = false;
                holdButton.Enabled = false;

                if (int.Parse(playerOneScoreTextBox.Text) >= 30){
                    MessageBox.Show("Player One has won");
                    anotherGameGroupBox.Enabled = true;
                    
                }
                else {
                    MessageBox.Show("Player two has won");
                    anotherGameGroupBox.Enabled = true;
                }
            }    
        }
   
        private void holdButton_Click(object sender, EventArgs e) {
            if (currentPlayer == 0) {
                currentPlayer = 1;
                playerOneScoreTextBox.Text = Pig_Single_Die_Game.GetPointsTotal("hold").ToString();
                WhoseTurnLabel.Text = Pig_Single_Die_Game.GetNextPlayersName();
            }//end if
            else {
                currentPlayer = 0;
                playerTwoScoreTextBox.Text = Pig_Single_Die_Game.GetPointsTotal("hold").ToString();
                WhoseTurnLabel.Text = Pig_Single_Die_Game.GetFirstPlayersName();
            }//end else       
        }//end holdButton_Click()

        private void anotherGameGroupBox_Enter(object sender, EventArgs e) {

            if (yesRadioButton.Checked == true)
            {
                Pig_Single_Die_Game.SetupGame();
                yesRadioButton.Checked = false;
                playerOneScoreTextBox.Text = "0";
                playerTwoScoreTextBox.Text = "0";
                WhoseTurnLabel.Text = Pig_Single_Die_Game.GetFirstPlayersName();
                anotherGameGroupBox.Enabled = false;
                currentPlayer = 0;
                holdButton.Enabled = false;
                rollButton.Enabled = true;
            }
            if (noRadioButton.Checked == true) {

                this.Close();
            }
        }

        private void RolledOneMessages() {

            if (currentPlayer == 0) {
                MessageBox.Show("Sorry you have thrown a " + Pig_Single_Die_Game.GetFaceValue() + "\nYour turn is over" + "\n your score reverts to " + Pig_Single_Die_Game.GetPointsTotal("player one").ToString());
                playerOneScoreTextBox.Text = Pig_Single_Die_Game.GetPointsTotal("player one").ToString();
                currentPlayer += 1;
                WhoseTurnLabel.Text = Pig_Single_Die_Game.GetNextPlayersName();
            }
            else {
                MessageBox.Show("Sorry you have thrown a " + Pig_Single_Die_Game.GetFaceValue() + "\nYour turn is over" + "\n your score reverts to " + Pig_Single_Die_Game.GetPointsTotal("player two").ToString());
                playerTwoScoreTextBox.Text = Pig_Single_Die_Game.GetPointsTotal("player two").ToString();
                currentPlayer -= 1;
                WhoseTurnLabel.Text = Pig_Single_Die_Game.GetFirstPlayersName();
            }
        }
    }
}
