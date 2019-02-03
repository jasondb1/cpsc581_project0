using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
    /// Interaction logic for RobertPumping.xaml
    /// </summary>
    public partial class RobertPumping : UserControl
    {
        Timer timer;
        int currentTime = 1000;

        Storyboard sb;
        Storyboard sbReverse;

        public RobertPumping()
        {
            InitializeComponent();
            sb = (this.Resources["Pump"] as Storyboard);
            sbReverse = (this.Resources["PumpReverse"] as Storyboard);
        }

        /// <summary>
        /// Animate Robert
        /// </summary>
        public void AnimateUp()
        {
            Storyboard sb = (this.Resources["Pump"] as Storyboard);
            sb.Begin();
        }

        public void AnimateDown()
        {
            sb.Pause();
            sbReverse.Begin();
        }


    }
}
