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
    public partial class Solitaire_Game_Form {
        //randomly generate a new cardPile at the beginning of each game
        private static CardPile cardPile = new CardPile(true);
        //generate an array that generates a hand for the dealer and player
        private static Hand[] hands = new Hand[2] { new Hand(), new Hand() };
        //array to store the points of both players
        private static int[] totalPoints = new int[2] { 0, 0 };
        //array to store the number of games won
        private static int[] numOfGamesWon = new int[2] { 0, 0 };
        //keep count if the player draws an ace and decides to make it a 1
        private static int numOfUserAcesWithValueOne = 0;

        public static void SetupGame()
        {
            //randomly generate a new cardPile at the beginning of each game
            CardPile cardPile = new CardPile(true);
            //generate an array that generates a hand for the dealer and player
            Hand[] hands = new Hand[2] { new Hand(), new Hand() };
            //array to store the points of both players
            totalPoints = new int[2] { 0, 0 };
            //array to store the number of games won
            numOfGamesWon = new int[2] { 0, 0 };
            //keep count if the player draws an ace and decides to make it a 1
            numOfUserAcesWithValueOne = 0;
        }//end SetupGame()
    }//end class
}//end namespace
