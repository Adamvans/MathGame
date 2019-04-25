using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    /// <summary>
    /// object for the user that keeps track of the name, age and, score of the player.  
    /// </summary>
    public class User
    {
        /// <summary>
        /// string to hold the name of the user.   
        /// </summary>
        string name;

        /// <summary>
        /// number to hold the age of the user. 
        /// </summary>
        int age;

        /// <summary>
        /// number to keep track of the users score in the game.  
        /// </summary>
        int score;

        /// <summary>
        /// number to keep track of the users time in the game .  
        /// </summary>
        double time;

        /// <summary>
        /// constructor for the user object.   
        /// </summary>
        public User()
        {
            /// <summary>
            /// test to see if the constructor fails.   
            /// </summary>
            try
            {
                /// <summary>
                /// set default name to none  
                /// </summary>
                this.name = "None";

                /// <summary>
                /// set default age to zero  
                /// </summary>
                this.age = 0;

                /// <summary>
                /// set initial score to 0  
                /// </summary>
                this.score = 0;
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
        /// method to assign the name and age to the user. 
        /// </summary>
        internal void login(string name, string age) 
        {
            /// <summary>
            /// test to see if the login fails.   
            /// </summary>
            try
            {
                /// <summary>
                /// set name to what ever is in the name string sent from the window.    
                /// </summary>
                this.name = name;

                /// <summary>
                /// parse the number if sucessful then no error. 
                /// </summary>
                this.age = int.Parse(age);
            }
            catch(Exception ex)
            {
                /// <summary>
                /// send error up to the window so that it can display the error. in its try catch.    
                /// </summary>
                throw ex;
            }
        }

        internal string getName()
        {
            return name;
        }

        /// <summary>
        /// method to assign the score to the user.  
        /// </summary>
        public void setScore(int input)
        {
            try
            {
                /// <summary>
                /// set the current users score  
                /// </summary>
                score = input;
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
        /// method to assign the time to the user.  
        /// </summary>
        public void setTime(Double input)
        {
            try
            {
                /// <summary>
                /// set the current users time  
                /// </summary>
                time = input;
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
        /// method to pull the score to diplay it.  
        /// </summary>
        public int getScore()
        {
            /// <summary>
            /// test to make sure that there are no errors in the get.   
            /// </summary>
            try
            {
                /// <summary>
                /// send the score as a return.
                /// </summary>
                return score;
            }
            catch (Exception ex)
            {
                /// <summary>
                /// if there is an error send error up to the window so that it can display the error. in its try catch.    
                /// </summary>
                throw ex;
            }
        
        }

        /// <summary>
        /// method to pull the time to diplay it.  
        /// </summary>
        public Double gettime()
        {
            /// <summary>
            /// test to make sure that there are no errors in the get.   
            /// </summary>
            try
            {
                /// <summary>
                /// send the time as a return.
                /// </summary>
                return time;
            }
            catch (Exception ex)
            {
                /// <summary>
                /// if there is an error send error up to the window so that it can display the error. in its try catch.    
                /// </summary>
                throw ex;
            }

        }
    }
}
