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
    /// Interaction logic for the UserWindow.xaml 
    /// this window asks for the name and age of the user. 
    /// it then sets the name and age of the user.
    /// </summary>
    public partial class UserWindow : Window
    {
        /// <summary>
        /// object for the user that we are getting the name and age of. 
        /// </summary>
        User player;

        /// <summary>
        /// constructor for the user window 
        /// initializes the text boxs, the buttion and the backround 
        /// initializes the player. 
        /// </summary>
        public UserWindow(User play)
        {
            try
            {
                /// <summary>
                /// initializes the text boxs, the buttion and the backround  
                /// </summary>
                InitializeComponent();

                /// <summary>
                /// initializes the player.  
                /// </summary>
                this.player = play;
            }
            catch
            {
                /// <summary>
                /// send error if there is any problems in the constructor. 
                /// </summary>
                Console.Out.Write("user window constructor failed");
            }
        }

        /// <summary>
        /// method that runs when the ok buttion is pressed. 
        /// this pulls the data from the text fields and sends the data to the user class. 
        /// it then enables the buttions in the main window and makes any error massages listed hidden if everthing worked. 
        /// it then closes the user window. 
        /// </summary>
        private void SignIn(object sender, RoutedEventArgs e)
        {
            /// <summary>
            /// test to make sure that the text boxs are not blank or have letters or symbols.  
            /// </summary>
            try
            {
                /// <summary>
                /// send the date in the name text box and the data in the age text box to the user object.   
                /// </summary>
                player.login(this.NameTxt.Text, this.AgeTxt.Text);

                /// <summary>
                /// this enables the buttions in the main window  
                /// </summary>
                ((MainWindow)this.Owner).EnableButtions();

                /// <summary>
                /// as there are no errors so far hide the error for blank text boxs.
                /// letters in the text box is handeled by the test method. 
                /// </summary>
                ErrorblankLbl.Visibility = Visibility.Hidden;

                /// <summary>
                /// once everything else is done the window can be closed. 
                /// </summary>
                this.Close();
            }
            catch
            {
                /// <summary>
                /// if the fields are blank display a massage saying so. 
                /// </summary>
                ErrorblankLbl.Visibility = Visibility.Visible;

                /// <summary>
                /// hide the other error if it is not allready hidden so that they are not on top of one another.  
                /// </summary>
                ErrorLbl.Visibility = Visibility.Hidden;
            }
        }

        /// <summary>
        /// this makes sure that there are only number is the age field. of there is anything else it will remove the chariters.  
        /// </summary>
        private void TestInput(object sender, TextChangedEventArgs e)
        {
            /// <summary>
            /// this tests if there is anthing but numbers in the text box. 
            /// it will fail and go to catch if the int.parse fails. 
            /// </summary>
            try
            {
                /// <summary>
                /// the parse will fail if the box is blank this case it taken care of in the buttion event. 
                /// so we just skip the parse if it is empty.
                /// </summary>
                if (AgeTxt.Text.ToString() != "")
                {
                    /// <summary>
                    /// run parse if it fails then it is not a number.   
                    /// </summary>
                    int.Parse(AgeTxt.Text.ToString());

                    /// <summary>
                    /// hide the error saying that there we have been given an invalid char if the parse works. 
                    /// </summary>
                    ErrorLbl.Visibility = Visibility.Hidden;
                }
            }
            catch
            {
                /// <summary>
                /// if the parse fails remove the invlid char. 
                /// </summary>
                AgeTxt.Text = AgeTxt.Text.Remove(AgeTxt.Text.Length - 1);

                /// <summary>
                /// if the parse fails show the error saying that there we have been given an invalid char
                /// </summary>
                ErrorLbl.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// this re-shows the main window when this window closes. 
        /// this works wether we close via "X"
        /// or fill out the form 
        /// </summary>
        private void OpenMain(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /// <summary>
            /// it it fails to show the main window it will send an error to the consol. 
            /// </summary>
            try
            {
                /// <summary>
                /// show the main window. 
                /// </summary>
                App.Current.MainWindow.Show();
            }
            catch
            {
                /// <summary>
                /// send error if there is any problems in the re-showing the main window.  
                /// </summary>
                Console.Out.Write("user window constructor failed");
            }
        }
    }
}
