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
    public partial class Which_Card_Game : Form {
        public Which_Card_Game() {
            InitializeComponent();
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

        private void WhichGameComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            if(WhichGameComboBox.SelectedIndex == 1) {

                TwentyOne_Game_Form twentyOneForm = new TwentyOne_Game_Form();
                twentyOneForm.Show();
            }
            else {

                Solitaire_Form solitaireForm = new Solitaire_Form();
                solitaireForm.Show();
            }

        }
    }
}
