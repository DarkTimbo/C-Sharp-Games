using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {

    /// <summary>
    /// Provides the logic for a GUI based solitaire game.
    /// Creates a deck of cards and contains the methods to correctly initialise the form.
    /// The rest of the game logic is found in this form.
    /// </summary>

    public static class Solitaire_Game {
     
        private static CardPile cardPile = new CardPile(true);
        
        private static Hand[] columns = new Hand[7] { new Hand(), new Hand(), new Hand(), new Hand(), new Hand(), new Hand(), new Hand() };
        
        private static CardPile drawPile = new CardPile();
        
        private static CardPile discardPile = new CardPile();


        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Reinitializes the private variables to equal 0 or their default state
        /// Generates a new deck of cards and shuffles it.
        /// An array is also created to store the cards that appear in each column in the GUI.
        /// </summary>

        public static void SetupGame() {
            //randomly generate a new cardPile at the beginning of each game
            CardPile cardPile = new CardPile(true);
            cardPile.Shuffle();
            discardPile = new CardPile();
            Hand[] columns = new Hand[7] { new Hand(), new Hand(), new Hand(), new Hand(), new Hand(), new Hand(), new Hand() };
        }//end SetupGame()

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        ///  This method allows for the cards in each column of the GUI to be initialised successfully.
        /// When this method is called, the parameter is passed here and the amount of cards that are drawn
        /// will be equal to the passed value + 1. Each time this method is called, the cards that are drawn
        /// will be stored in the columns array.
        /// </summary>
        /// <param name="columnNum"></param>
        /// <returns> a list of cards of a specified amount  </returns>

        public static List<Card> DealMultipleCardsTo(int columnNum) {
            List<Card> cards = new List<Card>();
            cards = cardPile.DealCards(columnNum + 1);
            const int column0 = 0, column1 = 1, column2 = 2, column3 = 3, column4 = 4, column5 = 5, column6 = 6;
            //shuffle the deck
            cardPile.Shuffle();
            //make the variable "card" equal to a newly drawn cards
            if (columnNum == column0) {
                columns[column0] = new Hand(cards);
            }//end if
            else if (columnNum == column1) {
                //if variable "who" equals player, add the card to the players hand
                columns[column1] = new Hand(cards);
            }//end else if
            else if (columnNum == column2) {
                //if variable "who" does not equal player, add the card to the dealers hand
                columns[column2] = new Hand(cards);
            }//end else if
            else if (columnNum == column3) {
                columns[column3] = new Hand(cards);
            }//end else if
            else if (columnNum == column4) {
                columns[column4] = new Hand(cards);
            }//end else if
            else if (columnNum == column5) {
                columns[column5] = new Hand(cards);
            }//end else if
            else if (columnNum == column6) {
                columns[column6] = new Hand(cards);
            }//end else if
           
            return cards;
        }//DealOneCardTo(who)

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Returns the selected Hand Class from the Array
        /// </summary>
        /// <param name="who"></param>
        /// <returns> The selected Hand </returns>
   
        public static Hand GetHand(int who) {
            const int column0 = 0, column1 = 1, column2 = 2, column3 = 3, column4 = 4, column5 = 5, column6 = 6;

            if (who == column0) {
                return columns[column0];
            }//end if
            else if (who == column1) {
                return columns[column1];
            }//end if
            else if (who == column2) {
                return columns[column2];
            }//end else if
            else if (who == column3) {
                return columns[column3];
            }//end else if
            else if (who == column4) {
                return columns[column4];
            }//end else if
            else if (who == column5) {
                return columns[column5];
            }//end else if
            else {
                return columns[column6];
            }//end else        
        }//end GetHand(who)
    }//end class
}//end namespace
