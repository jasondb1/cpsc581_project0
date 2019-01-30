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
            this.myButton.Click += OnMyButtonClick;

            this.userButton.PropertyChanged += OnCounterPropertyChanged;


        }

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #region methods

        private void OnMainWindowKeyUp(object sender, KeyEventArgs e)
        {
            // if the user 'releases' escape, close the program
            if (e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
        }

        private void OnCounterPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (DEBUG) { Console.WriteLine("[On Counter property Change]:" + e ); }
            this.powerLabel.Content = this.userButton.Power;
        }

        private void OnMyButtonClick(object sender, RoutedEventArgs e)
        {
            if (DEBUG) { Console.WriteLine("[Button was clicked]"); }
            this.userButton.processClick();
        }
        #endregion

        private void RobertPumping_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void PowerMeter_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
