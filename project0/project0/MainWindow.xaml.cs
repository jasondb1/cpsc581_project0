using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace project0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public UserButton userButton = new UserButton();
        public const bool DEBUG = true;

        public MainWindow()
        {

            if (DEBUG) { Console.WriteLine("[Init]"); }
            InitializeComponent();

            //event Handlers
            this.KeyUp += OnMainWindowKeyUp;

            this.userButton.PropertyChanged += OnCounterPropertyChanged;

        }

        #region methods

        /// <summary>
        /// Closes the window with the escape key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMainWindowKeyUp(object sender, KeyEventArgs e)
        {
            // if the user 'releases' escape, close the program
            if (e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
        }

        /// <summary>
        /// Changes the power label when signalled (for debugging - delete when required)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCounterPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (DEBUG) { Console.WriteLine("[On Counter property Change]:" + e); }
            this.powerLabel.Content = this.userButton.Power;
        }

        /// <summary>
        /// Calls the button logic when a button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleUserClick(object sender, System.Windows.RoutedEventArgs e)
        {
            if (DEBUG) { Console.WriteLine("[Handle User Click]"); }
            this.userButton.processClick();

            if (userButton.isMax())
            {
                this.cake.Visibility = Visibility.Visible;
                this.powerMeter.hideRobert();
                this.powerMeter.rotateMeter();
                this.cake.animate();
                //TODO: wait and reset or reset on button
            }

        }
        #endregion

        private void RobertPumping_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void PowerMeter_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void PowerMeter_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void PowerMeter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Implement click and hold
        }
    }
}
