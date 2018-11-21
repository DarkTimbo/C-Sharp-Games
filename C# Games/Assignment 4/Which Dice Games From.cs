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
    public partial class Dice_Games_Form : Form {
        public Dice_Games_Form() {
            InitializeComponent();
        }

       
        private void WhichPigGroupBox_Enter(object sender, EventArgs e) {

            if (SingleDiePigRadioButton.Checked) {


                Pig_Game_Form SinglePig = new Pig_Game_Form();
                SinglePig.Show();


            }

            else if (TwoDicePigRadioButton.Checked) {


                Pig_with_Two_Dice_Form DoublePig = new Pig_with_Two_Dice_Form();
                DoublePig.Show();

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
