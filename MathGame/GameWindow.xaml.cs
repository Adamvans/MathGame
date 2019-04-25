using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MathGame
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// tha game window sets which game is type is played then calls the correct game methods
    /// </summary>
    public partial class GameWindow : Window
    {
        /// <summary>
        /// buttion clicked so we can determan the type of game we are playing.   
        /// </summary>
        Button gametype;

        /// <summary>
        /// create game object.    
        /// </summary>
        Game quiz;

        /// <summary>
        /// player object that is passed from the main window.    
        /// </summary>
        User player;

        /// <summary>
        /// this tells us if the user closes the window before 10 questions is done.     
        /// </summary>
        bool FisnishedGame;

        /// <summary>
        /// create the timer for the game to diplay. the time.      
        /// </summary>
        System.Windows.Threading.DispatcherTimer Time;

        /// <summary>
        /// start time of the timer  
        /// </summary>
        private DateTime TimerStart;

        /// <summary>
        /// constructor for the game window. this initlizes the game, nad the componests to the window
        /// </summary>
        public GameWindow(Button gtype, User play)
        {
            /// <summary>
            /// test for errors in the constructor.
            /// </summary>
            try
            {
                /// <summary>
                /// setup all componets to the window 
                /// </summary>
                InitializeComponent();

                /// <summary>
                /// get buttion from main window 
                /// </summary>
                this.gametype = gtype;

                /// <summary>
                /// initialize game  
                /// </summary>
                this.quiz = new Game(play);

                /// <summary>
                /// get player from main window   
                /// </summary>
                player = play;

                /// <summary>
                /// start quiz  
                /// </summary>
                NewQuestion();

                /// <summary>
                /// 10 questions are not done.     
                /// </summary>
                FisnishedGame = false;

                /// <summary>
                /// initialize timer    
                /// </summary>
                Time = new System.Windows.Threading.DispatcherTimer();

                /// <summary>
                /// set the action to ticking   
                /// </summary>
                Time.Tick += new EventHandler(Ticking);

                /// <summary>
                /// set the ticking interval to one second 
                /// </summary>
                Time.Interval = new TimeSpan(0, 0, 1);

                /// <summary>
                /// start the timer  
                /// </summary>
                Time.Start();

                /// <summary>
                /// get time start time  
                /// </summary>
                TimerStart = DateTime.Now;
            }
            catch
            {
                /// <summary>
                /// send error if there is any problems in the constructor. 
                /// </summary>
                Console.Out.Write("main window constructor failed");
            }
        }

        /// <summary>
        /// update the window to diplay the next question. 
        /// </summary>
        private void NewQuestion()
        {
            /// <summary>
            /// test for errors in the diplay for the next question.
            /// </summary>
            try
            {
                

                /// <summary>
                /// choose question to dispaly based on the lebel of the buttion that was pressed. 
                /// </summary>
                switch (gametype.Content)
                {
                    /// <summary>
                    /// add buttion case 
                    /// </summary>
                    case "Add":
                        AddQustion();
                        break;

                    /// <summary>
                    /// Subtract buttion case 
                    /// </summary>
                    case "Subtract":
                        SubtractQuestion();
                        break;

                    /// <summary>
                    /// Multiply buttion case 
                    /// </summary>
                    case "Multiply":
                        MultiplyQuestion();
                        break;

                    /// <summary>
                    /// Divide buttion case 
                    /// </summary>
                    case "Divide":
                        DivideQuestion();
                        break;

                    /// <summary>
                    /// required default case.  
                    /// </summary>
                    default:
                        break;
                }
            }
            catch
            {
                /// <summary>
                /// send error if there is any probleme setting the next dipaly. 
                /// </summary>
                Console.Out.Write("method to choose game type failed");
            }
        }
        /// <summary>
        /// method to ask divide question  
        /// </summary>
        private void DivideQuestion()
        {
            /// <summary>
            /// test for errors in the diplay for the next Divide question.
            /// </summary>
            try
            {
                /// <summary>
                /// set math symbol to divied symbol   
                /// </summary>
                LblSymbol.Content = "÷";

                /// <summary>
                /// have the game ask the question    
                /// </summary>
                quiz.AskDivideQ();

                /// <summary>
                /// diplay the numbers that the game is asking the answer for.     
                /// </summary>
                this.DiplayNumbers();
            }
            catch
            {
                /// <summary>
                /// send error if there is any probleme setting the next dipaly for divide question. 
                /// </summary>
                Console.Out.Write("method to ask divide question failed");
            }
        }

        /// <summary>
        /// method to ask Multiply question  
        /// </summary>
        private void MultiplyQuestion()
        {
            /// <summary>
            /// test for errors in the diplay for the next Multiply question.
            /// </summary>
            try
            {
                /// <summary>
                /// set math symbol to Multiply symbol   
                /// </summary>
                LblSymbol.Content = "X";

                /// <summary>
                /// have the game ask the question   
                /// </summary>
                quiz.AskMultiplyQ();

                /// <summary>
                /// diplay the numbers that the game is asking the answer for.     
                /// </summary>
                this.DiplayNumbers();
            }
            catch
            {
                /// <summary>
                /// send error if there is any probleme setting the next dipaly for Multiply question. 
                /// </summary>
                Console.Out.Write("method to ask Multiply question failed");
            }
        }

        /// <summary>
        /// method to ask Subtract question  
        /// </summary>
        private void SubtractQuestion()
        {
            /// <summary>
            /// test for errors in the diplay for the next Subtract question.
            /// </summary>
            try
            {
                /// <summary>
                /// set math symbol to Subtract symbol   
                /// </summary>
                LblSymbol.Content = "-";

                /// <summary>
                /// have the game ask the question   
                /// </summary>
                quiz.AskSubtractQ();

                /// <summary>
                /// diplay the numbers that the game is asking the answer for.     
                /// </summary>
                this.DiplayNumbers();
            }
            catch
            {
                /// <summary>
                /// send error if there is any probleme setting the next dipaly for Subtract question. 
                /// </summary>
                Console.Out.Write("method to ask Subtract question failed");
            }
        }

        /// <summary>
        /// method to ask Add question  
        /// </summary>
        private void AddQustion()
        {
            /// <summary>
            /// test for errors in the diplay for the next Add question.
            /// </summary>
            try
            {
                /// <summary>
                /// have the game ask the question   
                /// </summary>
                quiz.AskAddQ();

                /// <summary>
                /// set math symbol to Add symbol   
                /// </summary>
                LblSymbol.Content = "+";

                /// <summary>
                /// diplay the numbers that the game is asking the answer for.     
                /// </summary>
                this.DiplayNumbers();
            }
            catch
            {
                /// <summary>
                /// send error if there is any probleme setting the next dipaly for Add question. 
                /// </summary>
                Console.Out.Write("method to ask Add question failed");
            }
        }

        /// <summary>
        /// method to diplay all numbers that the quetsion is asking.  
        /// </summary>
        private void DiplayNumbers()
        {
            /// <summary>
            /// test for errors in the diplay for the numbers.
            /// </summary>
            try
            {
                /// <summary>
                /// diaply the first number 
                /// </summary>
                LblNum1.Content = quiz.getFirst();

                /// <summary>
                /// diaply the second number 
                /// </summary>
                LblNum2.Content = quiz.getSecond();

                /// <summary>
                /// empty the answer box.  
                /// </summary>
                AnswerBox.Text = "";
            }
            catch
            {
                /// <summary>
                /// send error if there is any probleme setting the dipaly for numbers. 
                /// </summary>
                Console.Out.Write("method to diplay numbers failed");
            }
        }

        /// <summary>
        /// have the game check the answer of the question 
        /// </summary>
        private void CheckAnswer(object sender, RoutedEventArgs e)
        {
            /// <summary>
            /// test for errors in the diplay for the next Add question.
            /// </summary>
            try
            {
                /// <summary>
                /// if the answer box is blank set the answer to zero. 
                /// </summary>
                if (AnswerBox.Text.ToString() != "")
                {
                    /// <summary>
                    /// request game to check if correct. 
                    /// </summary>
                    quiz.CheckCorrect(int.Parse(AnswerBox.Text.ToString()));
                }
                else
                {
                    /// <summary>
                    /// set the answer to zero 
                    /// </summary>
                    quiz.CheckCorrect(0);
                }

                /// <summary>
                /// get the players score. 
                /// </summary>
                LblScore.Content = player.getScore();

                /// <summary>
                /// add one to the question number  
                /// </summary>
                QuestionNumLbl.Content = int.Parse(QuestionNumLbl.Content.ToString()) + 1;

                /// <summary>
                /// ask another question if under 11  
                /// </summary>
                if (int.Parse(QuestionNumLbl.Content.ToString()) <= 10)
                {
                    /// <summary>
                    /// ask another question 
                    /// </summary>
                    NewQuestion();
                }
                else
                {
                    /// <summary>
                    /// end the game 
                    /// </summary>
                    EndGame();
                }
            }
            catch
            {
                /// <summary>
                /// send error if it cant check. 
                /// </summary>
                Console.Out.Write("method to request answer check failed");
            }
        }

        /// <summary>
        /// end the game and tally the score. 
        /// </summary>
        private void EndGame()
        {
            /// <summary>
            /// test for errors in endgame
            /// </summary>
            try
            {
                /// <summary>
                /// create the scoreWindow 
                /// </summary>
                ScoreWindow ShowScores = new ScoreWindow(player);

                /// <summary>
                /// show the scoreWindow 
                /// </summary>
                ShowScores.Show();

                /// <summary>
                /// game is finished. 
                /// </summary>
                FisnishedGame = true;

                /// <summary>
                /// set the team the player played. 
                /// </summary>
                player.setTime((DateTime.Now - this.TimerStart).TotalSeconds);

                /// <summary>
                /// close the game window 
                /// </summary>
                this.Close();
            }
            catch
            {
                /// <summary>
                /// send error if it cant check. 
                /// </summary>
                Console.Out.Write("method to end the game failed");
            }
        }

        /// <summary>
        /// make sure the anser box only has numbers in it. 
        /// </summary>
        private void TestInput(object sender, TextChangedEventArgs e)
        {
            /// <summary>
            /// test for numbers via int parse  
            /// </summary>
            try
            {
                /// <summary>
                /// testing for blank is done in the submit  
                /// </summary>
                if (AnswerBox.Text.ToString() != "")
                {
                    /// <summary>
                    /// parse the int if it fails it is not a number. 
                    /// </summary>
                    int.Parse(AnswerBox.Text.ToString());

                    /// <summary>
                    /// hide error on sucess. 
                    /// </summary>
                    ErrorLbl.Visibility = Visibility.Hidden;
                }
            }
            catch
            {
                /// <summary>
                /// remove incorect symbol on error  
                /// </summary>
                AnswerBox.Text = AnswerBox.Text.Remove(AnswerBox.Text.Length - 1);

                /// <summary>
                /// show error on error. 
                /// </summary>
                ErrorLbl.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// opem the main window if the user closes the game window without finshing the game
        /// </summary>
        private void OpenMain(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /// <summary>
            /// test for errors in window close method.   
            /// </summary>
            try
            {
                /// <summary>
                /// if the game is not finshed open the main wnidow reather than the score window.    
                /// </summary>
                if (!FisnishedGame)
                {
                    /// <summary>
                    /// if the game is not finshed reset the game if the window is closed
                    /// set the score to zero. 
                    /// </summary>
                    player.setScore(0);

                    /// <summary>
                    /// open the main wnidow    
                    /// </summary>
                    App.Current.MainWindow.Show();
                }
            }
            catch
            {
                /// <summary>
                /// send error if it fails.  
                /// </summary>
                Console.Out.Write("close window method failed");
            }
        }

        /// <summary>
        /// update time every tick  
        /// </summary>
        private void Ticking(object sender, EventArgs e)
        {
            TimerLbl.Content = "Timer:" + (int) (DateTime.Now - this.TimerStart).TotalSeconds;
        }
    }
}
