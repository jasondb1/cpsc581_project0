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
        public PowerMeter()
        {
            InitializeComponent();
            this.MouseDown += PowerMeter_MouseDown;
        }

        private void PowerMeter_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Robert.animate();
        }
 
    }
}
