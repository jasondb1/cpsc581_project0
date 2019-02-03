﻿using System;
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
    /// Interaction logic for RobertPumping.xaml
    /// </summary>
    public partial class RobertPumping : UserControl
    {
        public RobertPumping()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Animate Robert
        /// </summary>
        public void animate(int timer)
        {
            Storyboard sb = (this.Resources["Pump"] as Storyboard);
            sb.Begin();
        }
    }
}
