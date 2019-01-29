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

namespace project0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public UserButton userButton = new UserButton();

        public MainWindow()
        {
            InitializeComponent();

            //event Handlers
            this.KeyUp += OnMainWindowKeyUp;
            this.MainButton.Click += OnMainWindowButtonClick;


        }

        private void OnMainWindowKeyUp(object sender, KeyEventArgs e)
        {
            // if the user 'releases' escape, close the program
            if (e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
        }

        private void OnMainWindowButtonClick(object sender, KeyEventArgs e)
        {
            this.userButton.processClick();
        }

    }
}
