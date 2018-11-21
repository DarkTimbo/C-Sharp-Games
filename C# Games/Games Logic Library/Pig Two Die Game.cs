using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {

    /// <summary>
    /// Provides the logic for a GUI based two pig dice game.
    /// Creates the dice and rules for playing the game.
    /// Returns the results of each roll so that it can be displayed on GUI.
    /// </summary>

    public static class Pig_Two_Die_Game {
        //create two variables called die1 and die2 that can call from the functions within
        //the Low_Level_Objects_Library.Die method.
        private static Die die1, die2;
        //variable to store the value of the die roll
        private static int[] faceValue = new int [2] {0,0};
        //array to store the points of both players
        private static int[] pointsTotal = new int[4] { 0, 0, 0, 0 }; //first = playerone, secone = playertwo, three = what score can he held, four= current added up.
        //array to display which players turn it is
        private static string[] playersName = new string[3] { "player one", "player two", "player one" };

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Reinitializes the private variables of the two dice game to the default state.
        /// </summary>

        public static void SetupGame() {
            //create new die
            die1 = new Die();
            die2 = new Die();
            //reset stored values back to 0
            faceValue = new int[2] { 0, 0 };
            pointsTotal = new int[4] { 0, 0, 0, 0 };
            playersName = new string[3] { "player one", "player two", "player one" };
        }//end SetupGame()

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Rolls the two dice and obtains their faceValues. Depending of the face values, if one of them contains a one, it switches the current player and reverts their score.
        /// If the roll does not contain a one, it determines if they are the same. If so, they are awarded points accordingly and saved to the current players temporary points total.
        /// </summary>
        /// <returns> returns true is a one is rolled </returns>
            
        public static bool PlayGame() {
            //boolean variable to state whether a 1 has been rolled
            bool rolledOne = false;
            
            const int Die1 = 1, Die2 = 2;
            const int Die1FaceValue = 0, Die2FaceValue = 1;
            const int tempScore = 2, tempCurrentScore = 3;

            die1.RollDie();
            die2.RollDie();
            //this method returns the randomly generated value of faceValue
            faceValue[Die1FaceValue] = GetFaceValue(Die1);
            faceValue[Die2FaceValue] = GetFaceValue(Die2);

            rolledOne = checkForAOne();

            //if the state of skip is not set to true in the previous if statement, perform this section of code
            if (rolledOne == false) {
                //if both die roll the same value, add that number to the score times by 2
                if(faceValue[Die1FaceValue] == faceValue[Die2FaceValue]) {
                    if (faceValue[Die1FaceValue] == 1) {
                        pointsTotal[tempScore] += 25;
                    }
                    else {
                        pointsTotal[tempScore] += (faceValue[0] + faceValue[1]) * 2;
                    }
                }//end nested if
                else {
                    //add the rolled value of both die to "pointsTotal[2]"
                    pointsTotal[tempScore] += faceValue[Die1FaceValue] + faceValue[Die2FaceValue];
                }//end nested else
            }//end if
            //if the player does not roll a 1 and they press hold their score will become the value stored in "pointsTotal[3]"
            //add the value of "pointsTotal[2]" to "pointsTotal[3]"
            pointsTotal[tempCurrentScore] = pointsTotal[tempScore];
            //communicate with other methods by returning the value of rolledOne
            return rolledOne;
        }//end PlayGame()

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Checks if the heldValue of the player is greater than 100 (is the winning score). If it is, then they have won and returns true.
        /// Else they haven't won yet and return false
        /// </summary>
        /// <returns> returns true or false depending if the current players score is greater than 100 </returns>

        public static bool HasWon() {
            const int heldValue = 2;
            const int WinningScore = 100;

            if (pointsTotal[heldValue] >= WinningScore) {
                return true;
            }//end if
            else {
                return false;
            }//end else
        }//end HasWon()

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Gets the string in the first place of the playername array.
        /// </summary>
        /// <returns> the string of the first player </returns>

        public static string GetFirstPlayersName() {
            const int playerOne = 0;
            return playersName[playerOne];
        }//end GetFirstPlayersName()

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Gets the string in the second place of the playername array.
        /// </summary>
        /// <returns> the string of the second player</returns>

        public static string GetNextPlayersName() {
            const int playerTwo = 1;
            return playersName[playerTwo];
        }//end GetNextPlayersName()

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Depending on the string inputed. If nameOfPLayer is equal to "player one" or "player two", their respective scores are returned.
        /// If nameOfPlayer is equal to hold, it switches the playerName array and points total array so that it switches the current person space in their arrays.
        /// If nameOfPlayer is equal to "show current" then it returns the current score of the current player.
        /// </summary>
        /// <param name="nameOfPlayer"></param>
        /// <returns>The points of the selected person, if hold is the input, it saves that totalscore to the respective array of the person, if "show current" is the input, shows the total score being added up</returns>

        public static int GetPointsTotal(string nameOfPlayer) {
            const int playerOne = 0, playerTwo = 1, currentplayer=2, heldScore = 3; 
            
            if (nameOfPlayer == playersName[playerOne]) {               
                return pointsTotal[playerOne];
            }//end if
            else if (nameOfPlayer == playersName[playerTwo]) {              
                return pointsTotal[playerTwo];
            }//end else if
            else if (nameOfPlayer == "hold") {
                //if the player presses hold, rotate the stored values in "pointsTotal" 
                //and switch the "playerName"
                if (playersName[currentplayer] == playersName[playerOne]) {
                    pointsTotal[playerOne] = pointsTotal[currentplayer];
                    playersName[currentplayer] = "player two";
                    pointsTotal[currentplayer] = pointsTotal[playerTwo];
                    return pointsTotal[playerOne];
                }//end nested if
                else {
                    pointsTotal[playerTwo] = pointsTotal[currentplayer];
                    playersName[currentplayer] = "player one";
                    pointsTotal[currentplayer] = pointsTotal[playerOne];
                    return pointsTotal[playerTwo];
                }//end nested else
            }//end else if
            else if (nameOfPlayer == "show current") {
                return pointsTotal[heldScore];
            }//end else if
            else {
                return 0;
            }//end else
        }//end GetPointsTotal(nameOfPlayer)

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Depending of the value of whichDie, it gets the Current Face value of that die. That face value is then returned.
        /// If whichDie is equal to 1, it returns the current face value of die1.
        /// Else if returns the current face value of die2.
        /// </summary>
        /// <param name="whichDie"></param>
        /// <returns> The current face value of the selected die </returns>

        public static int GetFaceValue(int whichDie) {
            int CurrentFaceValue;
            const int Dice1 = 1;

            if (whichDie == Dice1) {
                CurrentFaceValue = die1.GetFaceValue();
            }//end if
            else {
                CurrentFaceValue = die2.GetFaceValue();
            }//end else
            return CurrentFaceValue;
        }//end getFaceValue(whichDie)


        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//


            /// <summary>
            /// Checks to see if only one dice has a facevalue of 1. If only one dice has a 1, it switches the current player and returns true.
            /// It then sets the new current players score to be added onto for when the next roll begins.
            /// </summary>
            /// <returns> true if there is only one dice that has a facevalue of 1 </returns>

        private static bool checkForAOne() {

            bool rolledOne = false;
            const int Die1FaceValue = 0, Die2FaceValue = 1;
            const int CurrentPLayer = 2;
            const int playerOne = 0, playerTwo = 1;

            //if one of the die roll a 1, execute this statement
            if ((faceValue[Die1FaceValue] == 1 || faceValue[Die2FaceValue] == 1) && (faceValue[Die1FaceValue] != faceValue[Die2FaceValue])) {
                //if the temporary variable in the array is "player one" do this
                if (playersName[CurrentPLayer] == "player one") {
                    //change the temp variable to "player two"
                    //this changes the value that appears in the label "WhoseTurnLabel"
                    playersName[CurrentPLayer] = "player two";
                    //state of variables are changed
                    rolledOne = true;

                    //"pointsTotal[2]" stores the score of the player at the beginning of their turn
                    //if they roll a 1 the following statement will revert their score back to the beginning value
                    pointsTotal[CurrentPLayer] = pointsTotal[playerTwo];
                }//end nested if
                //if "playersName[2] != "player one" this code will be executed
                else {
                    playersName[CurrentPLayer] = "player one";
                    rolledOne = true;

                    pointsTotal[2] = pointsTotal[playerOne];
                }//end nested else
            }//end if
            return rolledOne;

        }//end checkForAOne

    }//end class

}//end namespace