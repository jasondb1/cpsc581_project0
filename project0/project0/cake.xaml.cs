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
    /// Interaction logic for cake.xaml
    /// </summary>
    public partial class cake : UserControl
    {
        public cake()
        {
            InitializeComponent();
        }

        /// <summary>
        /// animate the cake
        /// </summary>
        public void animate()
        {
            Storyboard sb = (this.Resources["CakeRiseSB"] as Storyboard);
            sb.Begin();
        }

        /// <summary>
        /// Reset the cake
        /// </summary>
        public void reset()
        {
            Storyboard sb = (this.Resources["CakeRiseSB"] as Storyboard);
            sb.Seek(TimeSpan.Zero, TimeSeekOrigin.BeginTime);
            sb.Stop();
  
        }


    }

}
