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
    /// Interaction logic for MainWindow.xaml
    /// this adds the sound to the game and has buttions that go to two other windows 
    /// 1. the user window with the top buttion 
    /// 2. the game window wtih the other four buttions. 
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// this is the user object to track the name, age, and score of the player. 
        /// </summary>
        User player;
        /// <summary>
        /// this is the object that plays the music.
        /// </summary>
        System.Media.SoundPlayer music;

        /// <summary>
        /// constructor for the main window. this initlizes player, the music and the buttions. 
        /// </summary>
        public MainWindow()
        {
            /// <summary>
            /// test for errors in the constructor.
            /// </summary>
            try
            {
                /// <summary>
                /// initialize buttions and backround 
                /// </summary>
                InitializeComponent();

                /// <summary>
                /// initialise the player object.
                /// </summary>
                player = new User();

                /// <summary>
                /// initialise the music player object. 
                /// </summary>
                music = new System.Media.SoundPlayer("My_Little_Pony.wav");

                /// <summary>
                /// start the music and loop it so it dosent end. 
                /// </summary>
                music.PlayLooping();
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
        /// method for the login buttion on the main window. this opens the user window.
        /// the user can then login. 
        /// </summary>
        private void OpenUserWindow(object sender, RoutedEventArgs e)
        {
            /// <summary>
            /// test for errors when clicking on the login buttion.
            /// </summary>
            try
            {
                /// <summary>
                /// create login window object. 
                /// </summary>
                UserWindow login = new UserWindow(player);

                /// <summary>
                /// set the main window to the owner of login 
                /// this is so that we can run the fucntion to enable the buttions in the login window.  
                /// </summary>
                login.Owner = this;

                /// <summary>
                /// show the login window so the user can see it and interact with it. 
                /// </summary>
                login.Show();

                /// <summary>
                /// hide the main window to keep the music playing and reduce clutter. 
                /// </summary>
                this.Hide();
            }
            catch
            {
                /// <summary>
                /// send error if there is any problems opening the login window. 
                /// </summary>
                Console.Out.Write("opening the user window failed");
            }
        }

        /// <summary>
        /// method for the add, subtract, divide, and muliply buttions on the main window 
        /// all these buttions open the game window and start the game for the type clciked. 
        /// </summary>
        private void OpenGameWindow(object sender, RoutedEventArgs e)
        {
            /// <summary>
            /// send error if there is any problems opening the game window
            /// </summary>
            try
            {
                /// <summary>
                /// get the buttion pressed so that we can start the right type of game. 
                /// </summary>
                Button gametype = (Button)sender;

                /// <summary>
                /// open the game window and send the buttion to determan the game type
                /// also send the play to keep track of player info. 
                /// </summary>
                GameWindow game = new GameWindow(gametype, player);

                /// <summary>
                /// show the game window so the user can see it and interact with it. 
                /// </summary>
                game.Show();

                /// <summary>
                /// hide the main window to keep the music playing and reduce clutter. 
                /// </summary>
                this.Hide();
            }
            catch
            {
                /// <summary>
                /// send error if there is any problems opening the game window. 
                /// </summary>
                Console.Out.Write("opening the game window failed");
            }
        }

        /// <summary>
        /// method to enable the game buttions after the user logs into the program 
        /// after entering the user info this is called in the user window to enable the buttions. 
        /// </summary>
        public void EnableButtions()
        {
            /// <summary>
            /// send error if there is any problems enableing the buttions 
            /// </summary>
            try
            {
                /// <summary>
                /// enable the add buttion 
                /// </summary>
                AddBtn.IsEnabled = true;

                /// <summary>
                /// enable the subtraction buttion 
                /// </summary>
                SubBtn.IsEnabled = true;

                /// <summary>
                /// enable the multply buttion 
                /// </summary>
                MultiBtn.IsEnabled = true;

                /// <summary>
                /// enable the devide buttion 
                /// </summary>
                DivBtn.IsEnabled = true;
            }
            catch
            {
                /// <summary>
                /// send error if there is any problems enableing the buttions 
                /// </summary>
                Console.Out.Write("enableing the game buttions failed");
            }
        }
    }
}
