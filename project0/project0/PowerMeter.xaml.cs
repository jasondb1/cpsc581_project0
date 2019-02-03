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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project0
{
    /// <summary>
    /// Interaction logic for PowerMeter.xaml
    /// </summary>
    public partial class PowerMeter : UserControl
    {
        private static int timer = 0;

        public PowerMeter()
        {
            InitializeComponent();
            this.MouseDown += PowerMeter_MouseDown;
            this.MouseUp += PowerMeter_MouseUp;

        }

        private void PowerMeter_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Provide a routed event for main window or other windwos listening
        /// </summary>
        public static readonly RoutedEvent UserClickEvent = EventManager.RegisterRoutedEvent("UserClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(PowerMeter));

        // Provide CLR accessors for the event
        public event RoutedEventHandler UserClick
        {
            add { AddHandler(UserClickEvent, value); }
            remove { RemoveHandler(UserClickEvent, value); }
        }

        private void RaiseUserClickEvent()
        {
            RoutedEventArgs userClickEventArgs = new RoutedEventArgs();
        }

        /// <summary>
        /// User Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PowerMeter_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Robert.animate(timer);
            this.RaiseEvent(new RoutedEventArgs(UserClickEvent, this));
        }

        /// <summary>
        /// Hide Robert
        /// </summary>
        public void hideRobert()
        {
            this.Robert.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Unhide Robert
        /// </summary>
        public void unhideRobert()
        {
            this.Robert.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Rotate the meter for cake animation
        /// </summary>
        public void rotateMeter()
        {
            Storyboard sb = (this.Resources["PerspectiveRotateSB"] as Storyboard);
            sb.Begin();

        }

        /// <summary>
        /// Reset the Meter
        /// </summary>
        public void resetMeter()
        {
            Storyboard sb = (this.Resources["PerspectiveRotateSB"] as Storyboard);
            //sb.Seek(TimeSpan.Zero);
 
            sb.Seek(TimeSpan.Zero, TimeSeekOrigin.BeginTime);
            sb.Stop();
            unhideRobert();
        }

        public void meterColor(int angle)
        {
            float green;
            float red;
            if (angle < 180)
            {
                green = (255);
                red = (angle * 255 / 180);
            }
            else
            {
                float v = (float)( ((float)angle - (float)180) / 180);
                red = 255;
                green = 255 * (1.0f - v);
            }
            
   
            SolidColorBrush scb = new SolidColorBrush(Color.FromRgb( (byte)red, (byte) green, 50) );
            this.progressBar.Fill = scb;


        }



    }
}