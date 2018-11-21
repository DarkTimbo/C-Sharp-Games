using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {

    /// <summary>
    /// Provides the logic for a GUI based single pig dice game.
    /// Creates the dice and rules for playing the game.
    /// Returns the results of each roll so that it can be displayed on GUI.
    /// </summary>

    public static class Pig_Single_Die_Game {

        //create a variable called die that can call from the functions within
        //the Low_Level_Objects_Library.Die method.
        private static Die die;
        //variable to store the value of the die roll
        private static int faceValue;
        //array to store the points of both players
        private static int[] pointsTotal = new int[4] { 0, 0, 0, 0}; //first = playerone, secone = playertwo, three = what score can he held, four= current added up.
        //array to display which players turn it is
        private static string[] playersName = new string[3] { "player one", "player two", "player one" };

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Reinitializes the private variables of the single dice game to the default state.
        /// </summary>
        
        public static void SetupGame() {
            //create a new die
            die = new Die();
            //reset stored values back to 0
            pointsTotal = new int[4] {0, 0, 0, 0};
            playersName = new string[3] { "player one", "player two","player one" };
        }//end SetupGame()

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Rolls a dice and obtains its faceValue. If a 1 is rolled, the players score will revert back to what it was at the beginning of their turn and it will become the
        /// other players turn. Any other rolled value (2-6) will add to the players score.
        /// </summary>
        /// <returns> returns true is a one is rolled </returns>

        public static bool PlayGame() {
            //boolean variable to state whether a 1 has been rolled
            bool rolledOne = false;
            

            //calls the method "RollDie()" this gives the variable 'faceValue' 
            //a randomly generated value between 1 and 6
            die.RollDie();
            //this method returns the randomly generated value of faceValue
            GetFaceValue();

            rolledOne = checkIfRolledOne();
            

            //if the state of skip is not set to true in the previous if statement, perform this section of code
            if (rolledOne == false) {
                //add the rolled value to "pointsTotal[2]"
                pointsTotal[2] += die.GetFaceValue();       
            }//end if
            //if the player does not roll a 1 and they press hold their score will become the value stored in "pointsTotal[3]"
            //add the value of "pointsTotal[2]" to "pointsTotal[3]"
            pointsTotal[3] = pointsTotal[2];
            //communicate with other methods by returning the value of rolledOne
            return rolledOne;
        }//end PlayGame()

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Checks if the players score is greater than 30 (the winning score). If it is, then they have won and returns true.
        /// Otherwise they haven't won yet and it will return false.
        /// </summary>
        /// <returns> returns true or false depending if the current players score is greater than 100 </returns>

        public static bool HasWon() {
            //if the players total is greater than or equal to 30 return true
            if (pointsTotal[2] >= 30) {
                return true;
            }//end if
            //if the players total is less than 30 return false
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
            //return the name of whose turn it is
            return playersName[0];
        }//end GetFirstPlayersName()

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Gets the string in the second place of the playername array.
        /// </summary>
        /// <returns> the string of the second player</returns
       
        public static string GetNextPlayersName() {
            //return the name of whose turn it is next
            return playersName[1];
        }//end GetNextPlayersName()

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// If nameOfPLayer is equal to "player one" or "player two", their respective scores are returned.
        /// If nameOfPlayer is equal to hold, it switches the playerName array and points total array so that it switches the current person space in their arrays.
        /// If nameOfPlayer is equal to "show current" then it returns the current score of the current player.
        /// </summary>
        /// <param name="nameOfPlayer"></param>
        /// <returns>The points of the selected person, if hold is the input, it saves that totalscore to the respective array of the person, if "show current" is the input, shows the total score being added up</returns>

        public static int GetPointsTotal(string nameOfPlayer) {
            if (nameOfPlayer == playersName[0]) {
                //return the points of "playersName[0]" which is player one
                return pointsTotal[0];
            }//end if
            else if (nameOfPlayer == playersName[1]) {
                //return the points of "playersName[1]" which is player two
                return pointsTotal[1];
            }//end else if
            else if (nameOfPlayer == "hold") {
                //if the player presses hold, rotate the stored values in "pointsTotal" 
                //and switch the "playerName"
                if(playersName[2] == playersName[0]) {
                    pointsTotal[0] = pointsTotal[2];
                    playersName[2] = "player two";
                    pointsTotal[2] = pointsTotal[1];
                    return pointsTotal[0];
                }//end if
                else {
                    pointsTotal[1] = pointsTotal[2];
                    playersName[2] = "player one";
                    pointsTotal[2] = pointsTotal[0];
                    return pointsTotal[1];
                }//end else
            }//end else if
            else if(nameOfPlayer == "show current"){
                return pointsTotal[3];
            }//end else if
            else {
                return 0;
            }//end else
        }//end GetPointsTotal(nameOfPlayer)

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Gets the current face value of the die. That face value is then returned.
        /// </summary>
        /// <param name="whichDie"></param>
        /// <returns> The current face value of the die </returns>
        
        public static int GetFaceValue() {
            //get the face value of the die once its rolled
            faceValue = die.GetFaceValue();
            return faceValue;
        }//end GetFaceValue()


        /// <summary>
        /// Checks if the dice has rolled a one. If it has, it switches who the current player is and reverts
        /// their score back when they last saved it.
        /// </summary>
        /// <returns> returns true if the dice rolls a one </returns>

        private static bool checkIfRolledOne() {

            bool rolledOne = false;

            //if a 1 is rolled, execute this statement
            if (faceValue == 1) {
                //if the temporary variable in the array is "player one" do this
                if (playersName[2] == "player one") {
                    //change the temp variable to "player two"
                    //this changes the value that appears in the label "WhoseTurnLabel"
                    playersName[2] = "player two";
                    //state of variables are changed
                    rolledOne = true;
                    
                    //"pointsTotal[2]" stores the score of the player at the beginning of their turn
                    //if they roll a 1 the following statement will revert their score back to the beginning value
                    pointsTotal[2] = pointsTotal[1];
                }//end nested if
                //if "playersName[2] != "player one" this code will be executed
                else {
                    playersName[2] = "player one";
                    rolledOne = true;
                   
                    pointsTotal[2] = pointsTotal[0];
                }//end nested else
            }//end if

            return rolledOne;
        }


    }//end class
}//end namespace
