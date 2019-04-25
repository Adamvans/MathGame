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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MathGame
{
    /// <summary>
    /// Interaction logic for ScoreWindow.xaml diplayes the backround and text depending on how well the user did. 
    /// </summary>
    public partial class ScoreWindow : Window
    {
        /// <summary>
        /// user for the score diplay. 
        /// </summary>
        private User player;

        /// <summary>
        /// constructor for the game window. this pulls the players and shows the score. 
        /// </summary>
        public ScoreWindow(User player)
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
                /// get player from last window   
                /// </summary>
                this.player = player;

                /// <summary>
                /// show the users score.    
                /// </summary
                ShowPlayerScore();
            }
            catch
            {
                /// <summary>
                /// send error if there is any problems in the constructor. 
                /// </summary>
                Console.Out.Write("score window constructor failed");
            }
        }

        /// <summary>
        /// create the text and backround to so we can see the score.  
        /// </summary>
        private void ShowPlayerScore()
        {
            /// <summary>
            /// test for errors dipaly.
            /// </summary>
            try
            {
                /// <summary>
                /// display total score. 
                /// </summary>
                ScoreLBL.Content = "You got: "+ player.getScore() +"/10 Questions Correct!!";

                /// <summary>
                /// display low score  
                /// </summary>
                if (player.getScore() < 5)
                {
                    GreetingLBL.Content = "Great Try " + player.getName(); 
                    ResopnceLbl.Content = "Try again, you can do better";
                    ImageBrush myBrush = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Images/sadpony.jpg")));
                    ScoreWin.Background = myBrush;
                }

                /// <summary>
                /// display medium score  
                /// </summary>
                else if (player.getScore() < 8)
                {
                    GreetingLBL.Content = "Good Job " + player.getName(); 
                    ResopnceLbl.Content = "Try again, practice makes perfect";
                    ImageBrush myBrush = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Images/Main_ponies_happy_for_Rainbow_S3E7.png")));
                    ScoreWin.Background = myBrush;
                }

                /// <summary>
                /// display high score  
                /// </summary>
                else if (player.getScore() < 10)
                {
                    GreetingLBL.Content = "Great Job " + player.getName(); 
                    ResopnceLbl.Content = "Try again, to get a perfect score";
                    ImageBrush myBrush = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Images/Main_cast_and_Starlight_Glimmer_jump_in_happiness_S5E26.png")));
                    ScoreWin.Background = myBrush;
                }

                /// <summary>
                /// display perfict score  
                /// </summary>
                else
                {
                    GreetingLBL.Content = "Congratulations " + player.getName() + "!!";
                }
            }
            catch
            {
                /// <summary>
                /// send error if there is any problems. 
                /// </summary>
                Console.Out.Write("score window diplay failed");
            }
        }

        /// <summary>
        /// close the window 
        /// </summary>
        private void Done(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// open main window on if closed via done or X
        /// </summary>
        private void OpenMain(object sender, System.ComponentModel.CancelEventArgs e)
        {
            player.setScore(0);
            App.Current.MainWindow.Show();
        }
    }
}
