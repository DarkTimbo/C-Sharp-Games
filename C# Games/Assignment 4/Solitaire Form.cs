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

namespace Assignment_4
{
    public partial class Solitaire_Form : Form
    {
        TableLayoutPanel[] tableLayoutPanels;
        const int NUM_OF_COLUMNS = 7;
        const int maxNumberOfCards = 8;
    

        public Solitaire_Form()
        {
            InitializeComponent();
            ConstructVariables();
            Solitaire_Game.SetupGame();
            
            Solitaire_Game.DealMultipleCardsTo(0);
            Solitaire_Game.DealMultipleCardsTo(1);
            Solitaire_Game.DealMultipleCardsTo(2);
            Solitaire_Game.DealMultipleCardsTo(3);
            Solitaire_Game.DealMultipleCardsTo(4);
            Solitaire_Game.DealMultipleCardsTo(5);
            Solitaire_Game.DealMultipleCardsTo(6);

            Hand col1 = Solitaire_Game.GetHand(0);
            DisplayGuiHand(col1, tableLayoutPanel1,0);

            Hand col2 = Solitaire_Game.GetHand(1);
            DisplayGuiHand(col2, tableLayoutPanel2,1);
            Hand col3 = Solitaire_Game.GetHand(2);
            DisplayGuiHand(col3, tableLayoutPanel3,2);


            Hand col4 = Solitaire_Game.GetHand(3);
            DisplayGuiHand(col4, tableLayoutPanel4,3);
            Hand col5 = Solitaire_Game.GetHand(4);
            DisplayGuiHand(col5, tableLayoutPanel5,4);
            Hand col6 = Solitaire_Game.GetHand(5);
            DisplayGuiHand(col6, tableLayoutPanel6,5);
            Hand col7 = Solitaire_Game.GetHand(6);
            DisplayGuiHand(col7, tableLayoutPanel7,6);

            picDrawPile.Image = Images.GetBackOfCardImage();
        }

        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel, int numberOfCardsInColumnFacedDown)
        {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand)
            {
                if (numberOfCardsInColumnFacedDown > 0) {
                    // Construct a PictureBox object.
                    PictureBox pictureBox = new PictureBox();
                    // Set the PictureBox to use all of its space
                    pictureBox.Dock = DockStyle.Fill;
                    // Remove spacing around the PictureBox. (Default is 3 pixels.)
                    pictureBox.Margin = new Padding(0);
                    pictureBox.Image = Images.GetBackOfCardImage();
                    // Add the PictureBox object to the tableLayoutPanel.
                    tableLayoutPanel.Controls.Add(pictureBox);
                    numberOfCardsInColumnFacedDown--;
                }
                else {
                    
                    // Construct a PictureBox object.
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Images.GetCardImage(card);
                    // set event-handler for Click on this PictureBox.
                    pictureBox.Click += new EventHandler(pictureBox_Click);
                    // tell the PictureBox which Card object it has the picture of.
                    pictureBox.Tag = card;
                    pictureBox.Image = Images.GetBackOfCardImage();
                    pictureBox.Tag = card;
                    // Set the PictureBox to use all of its space
                    pictureBox.Dock = DockStyle.Fill;
                    // Remove spacing around the PictureBox. (Default is 3 pixels.)
                    pictureBox.Margin = new Padding(0);
                    pictureBox.Image = Images.GetCardImage(card);
                    // Add the PictureBox object to the tableLayoutPanel.
                    tableLayoutPanel.Controls.Add(pictureBox);
                   
                }
            }
        }// End DisplayGuiHand

        private void ConstructVariables()
        {
            tableLayoutPanels = new TableLayoutPanel[NUM_OF_COLUMNS] { tableLayoutPanel1, tableLayoutPanel2, tableLayoutPanel3, tableLayoutPanel4, tableLayoutPanel5, tableLayoutPanel6, tableLayoutPanel7 };
        }//end ConstructVariables()

        private void pictureBox_Click(object sender, EventArgs e) {


            // which card was clicked?
            PictureBox clickedPictureBox = (PictureBox)sender;
            // get a reference to the card
            Card clickedCard = (Card)clickedPictureBox.Tag;
            TryToPlayCard(clickedCard);

        }

        private void TryToPlayCard(Card clickedCard) {
            // This MessageBox.Show is for debugging purposes only.
            // comment out line, once sure you can click on a card in a tableau
            MessageBox.Show(clickedCard.ToString(false, true), "Clicked");
            // Add code to do something with the clicked card.
        }

        private void picDrawPile_Click(object sender, EventArgs e) {


       

        }
    }
}
