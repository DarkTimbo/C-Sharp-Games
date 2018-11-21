using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4 {
    public partial class Games : Form {
        public Games() {
            InitializeComponent();
        }

        bool DiceSelected = false;

        private void GameGroupBox_Enter(object sender, EventArgs e) {

            if (DiceRadioButton.Checked) {

                DiceSelected = true;
               
            }

            else if (cardRadioButton.Checked) {

                DiceSelected = false;
                
            }

            StartButton.Enabled = true;

        }

        private void StartButton_Click(object sender, EventArgs e) {

            if (DiceSelected) {
                Dice_Games_Form DiceForm = new Dice_Games_Form();
                DiceForm.Show();

            }
            else {
                Which_Card_Game CardForm = new Which_Card_Game();
                CardForm.Show();
            }
            

        }

        private void ExitButton_Click(object sender, EventArgs e) {

            DialogResult result = MessageBox.Show("Do you really want to quit?",
                                                        "Quit?",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {

                this.Close();

            }

           

        }
    }
}
