using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {

    /// <summary>
    /// Provides the logic behind a GUI based Twenty-One card game.
    /// Creates the rules and objects which can be called upon to begin playing the game.
    /// </summary>

    public static class Twenty_One_Game {
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

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Reinitializes the private variables to equal 0 or their default state
        /// </summary>

        public static void SetupGame() {
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

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Grabs a card from the pile. This card, depending on whose turn it is, will add the card
        /// to their hand. If who = 0, it will add the card to the players hand. Else it adds the card to the dealers hand.
        /// </summary>
        /// <param name="who"></param>
        /// <returns> The card that is drawn and given to either the player or dealer </returns>

        public static Card DealOneCardTo(int who) {
            Card card = new Card();
            const int player = 0, computer = 1; ;

            //shuffle the deck
            cardPile.Shuffle();
            //make the variable "card" equal to a newly drawn card
            card = cardPile.DealOneCard();
            if (who == player) {
                //if variable "who" equals player, add the card to the players hand
                hands[player].Add(card);
            }//end if
            else {
                //if variable "who" does not equal player, add the card to the dealers hand
                hands[computer].Add(card);
            }//end else
            //return the card that was drawn
            return card;
        }//DealOneCardTo(who)

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Depending on the value of parameter who, the method goes through all the cards in a hand and gets their integer values.
        /// These values are then combined and returned to the corresponding persons total score. 
        /// It who = 0, it counts how many cards are in the hand, then adds their values to the total. If the player has Aces with value 1, it subtracts the High Ace value
        /// and replaces it with the Low Ace value. It is then added to their total score. The same goes for if who = 1, however the value of Aces in the dealers hand
        /// will always be equal to 11.
        /// </summary>
        /// <param name="who"></param>
        /// <returns> The total amount of Values in a Hand, changing if the player has aces with or without values of 1 </returns>

        public static int CalculateHandTotal(int who) {
            int count = 0, total = 0, NoAcesWithValueOne = 0;
            const int player = 0, computer = 1;
            const int HighAce = 11, LowAce = 1;

            if (who == player) {
                count = hands[player].GetCount();
                for (int i = 0; i < count; i++) {
                    total += (int)(hands[player].GetCard(i).GetFaceValue());
                }//end nested for loop
                if (numOfUserAcesWithValueOne > NoAcesWithValueOne) {
                    total = (total - HighAce * numOfUserAcesWithValueOne) + LowAce * numOfUserAcesWithValueOne;
                    totalPoints[player] = total;
                }//end nested if
                totalPoints[player] = total;
                return totalPoints[player];
            }//end if
            else {
                count = hands[computer].GetCount();
                for (int i = 0; i < count; i++) {
                    total += (int)(hands[computer].GetCard(i).GetFaceValue());
                }//end nested for loop
                totalPoints[computer] = total;
                return totalPoints[computer];
            }//end else     
        }//end CalculateHandTotal(who)

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Plays for the dealer. If the dealer is below the total score of the player or its total score is less then 17 it will keep drawing cards.
        /// It calculates its hand everytime in order to check if it still needs to draw.
        /// </summary>

        public static void PlayForDealer() {
            const int player = 0, computer = 1, computerRule = 17;

            CalculateHandTotal(computer);
            if (totalPoints[computer] < totalPoints[player]) {
                while ((totalPoints[computer] < totalPoints[player]) || (totalPoints[computer] < computerRule)) {
                    //deal the dealers new card
                    DealOneCardTo(computer);
                    //calculate the new hand total
                    CalculateHandTotal(computer);

                }//end while 
            }//end PlayForDealer()
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// If the parameter 'who' is equal to the player (0), it returns the hand of the player.
        /// Otherwise it returns the hand of the dealer.
        /// </summary>
        /// <param name="who"></param>
        /// <returns> the Hand from the corresponding hands array of the integer who </returns>

        public static Hand GetHand(int who) {
            const int player = 0, computer = 1;

            if (who == player) {
                return hands[player];
            }//end if
            else {
                return hands[computer];
            }//end else
        }//end GetHand(who)

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// If the parameter 'who' is equal to player (0), then the total is equal to its corresponding totalPoints array.
        /// Likewise, if 'who' is equal to computer (1), then the total is equal to its corresponding totalPoints array.
        /// </summary>
        /// <param name="who"></param>
        /// <returns> Returns the value of the totalPoints array of either the computer or player </returns>

        public static int GetTotalPoints(int who) {
            int total = 0;
            const int player = 0, computer = 1;

            //return the total points of the dealer and the player
            if (who == player) {
                total = totalPoints[player];
            }//end if
            else {
                total = totalPoints[computer];
            }//end else
            return total;
        }//end GetTotalPoints(who)

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Depending on the integer value of who. If who is equal to player (0), it adds 1 to the value of the numOfGamesWon[player].
        /// If who is equal to the computer (1), it adds 1 to the value of the numOfGamesWon[computer].
        /// </summary>
        /// <param name="who"></param>
        /// <returns> The number of games won depending on the value of who </returns>

        public static int GetNumOfGamesWon(int who) {
            int won;
            const int player = 0, computer = 1;

            //add 1 to either the dealer or the players number of wins
            if (who == player) {
                won = numOfGamesWon[player] += 1;
            }//end if
            else {
                won = numOfGamesWon[computer] += 1;
            }//end else
            return won;
        }//end GetNumOfGamesWon(who)

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Gets the the value of numOfUserAcesWithValueOne.
        /// </summary>
        /// <returns> numOfUserAcesWithValueOne </returns>

        public static int GetNumOfUserAcesWithValueOne() {
            //return the number of aces with the value of 1
            return numOfUserAcesWithValueOne;
        }//end GetNumOfUserAcesWithValueOne()

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Adds 1 to the numOfUSersAcesWithValueOne if called.
        /// </summary>

        public static void IncrementNumOfUserAcesWithValueOne() {
            numOfUserAcesWithValueOne++;
        }//end IncrementNumOfUserAcesWithValueOne()

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Resets the private static values used throughout the class.
        /// Makes them equal to zero or their original state.
        /// </summary>

        public static void ResetTotals() {
            const int player = 0, computer = 1, original = 0;

            hands[player] = new Hand();
            hands[computer] = new Hand();
            totalPoints[player] = original;
            totalPoints[computer] = original;
            numOfUserAcesWithValueOne = original;
            cardPile = new CardPile(true);

        }//end ResetTotals()
    }//end class
}//end namespace
