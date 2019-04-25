using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathGame
{
    /// <summary>
    /// create and score game. 
    /// </summary>
    class Game
    {
        /// <summary>
        /// player to set and get score  
        /// </summary>
        User player;

        /// <summary>
        /// numbers for the math in the game 
        /// </summary>
        int firstNum, secondNum, answer;

        /// <summary>
        /// randomizer for the game 
        /// </summary>
        Random random;

        /// <summary>
        /// constructor for the game object.   
        /// </summary>
        public Game(User play)
        {
            /// <summary>
            /// test to see if the constructor fails.   
            /// </summary>
            try
            {
                /// <summary>
                /// get the player   
                /// </summary>
                player = play;

                /// <summary>
                /// initialize the first operend. 
                /// </summary>
                firstNum = 0;

                /// <summary>
                /// initialize the second operend. 
                /// </summary>
                secondNum = 0;

                /// <summary>
                /// seed the ranomizer.  
                /// </summary>
                random = new Random();
            }
            catch
            {
                /// <summary>
                /// send error if there is any problems in the constructor. 
                /// </summary>
                Console.Out.Write("User constructor failed");
            }
        }

        /// <summary>
        /// method to ask the add question  
        /// </summary>
        internal void AskAddQ()
        {
            /// <summary>
            /// test to see if the quetion createtion fails.   
            /// </summary>
            try
            {
                /// <summary>
                /// set first oprend  
                /// </summary>
                firstNum = random.Next(0, 10);

                /// <summary>
                /// set second oprend  
                /// </summary>
                secondNum = random.Next(0, 10);

                /// <summary>
                /// get answer to compare.   
                /// </summary>
                answer = firstNum + secondNum;
            }
            catch (Exception ex)
            {
                /// <summary>
                /// send error up to the window so that it can display the error. in its try catch.    
                /// </summary>
                throw ex;
            }
        }

        /// <summary>
        /// method to ask the Subtract question  
        /// </summary>
        internal void AskSubtractQ()
        {
            /// <summary>
            /// test to see if the quetion createtion fails.   
            /// </summary>
            try
            {
                /// <summary>
                /// set first oprend  
                /// </summary>
                firstNum = random.Next(0, 10);

                /// <summary>
                /// set second oprend  
                /// </summary>
                secondNum = random.Next(0, 10);

                /// <summary>
                /// if first smaller than the second switch the numbers. 
                /// </summary>
                if (firstNum < secondNum)
                {
                    /// <summary>
                    ///  set first to temp
                    /// </summary>
                    int temp = firstNum;

                    /// <summary>
                    ///  set second to first
                    /// </summary>
                    firstNum = secondNum;

                    /// <summary>
                    ///  set temp to second 
                    /// </summary>
                    secondNum = temp;
                }

                /// <summary>
                /// get answer to compare.   
                /// </summary>
                answer = firstNum - secondNum;
            }
            catch (Exception ex)
            {
                /// <summary>
                /// send error up to the window so that it can display the error. in its try catch.    
                /// </summary>
                throw ex;
            }
        }

        /// <summary>
        /// method to ask the Divide question  
        /// </summary>
        internal void AskDivideQ()
        {
            /// <summary>
            /// test to see if the quetion createtion fails.   
            /// </summary>
            try
            {
                /// <summary>
                /// get answer to compare.   
                /// </summary>
                answer = random.Next(0, 10);

                /// <summary>
                /// set second oprend  
                /// </summary>
                secondNum = random.Next(1, 10);

                /// <summary>
                /// miltiply the answer and the second opernd to get the first operend 
                /// </summary>
                firstNum = answer * secondNum;
            }
            catch (Exception ex)
            {
                /// <summary>
                /// send error up to the window so that it can display the error. in its try catch.    
                /// </summary>
                throw ex;
            }
        }

        /// <summary>
        /// method to ask the Multiply question  
        /// </summary>
        internal void AskMultiplyQ()
        {
            /// <summary>
            /// test to see if the quetion createtion fails.   
            /// </summary>
            try
            {
                /// <summary>
                ///  set first oprend
                /// </summary>
                firstNum = random.Next(0, 10);

                /// <summary>
                /// set second oprend
                /// </summary>
                secondNum = random.Next(0, 10);

                /// <summary>
                /// get answer to compare.   
                /// </summary>
                answer = firstNum * secondNum;
            }
            catch (Exception ex)
            {
                /// <summary>
                /// send error up to the window so that it can display the error. in its try catch.    
                /// </summary>
                throw ex;
            }
        }

        /// <summary>
        /// GET method to diplay the first opend   
        /// </summary>
        public int getFirst() { return firstNum; }

        /// <summary>
        /// GET method to diplay the second opend   
        /// </summary>
        public int getSecond() { return secondNum; }

        /// <summary>
        /// methiod the check the answer.   
        /// </summary>
        public void CheckCorrect(int guess)
        {
            /// <summary>
            /// test to see if the checking the guess fails    
            /// </summary>
            try
            {
                /// <summary>
                /// if the gess is the same as the answer then it is coorect.    
                /// </summary>
                if (guess == answer)
                {
                    /// <summary>
                    /// correct answers add one to the score.     
                    /// </summary>
                    player.setScore(player.getScore() + 1);
                }
            }
            catch (Exception ex)
            {
                /// <summary>
                /// send error up to the window so that it can display the error. in its try catch.    
                /// </summary>
                throw ex;
            }
        }
    }
}
