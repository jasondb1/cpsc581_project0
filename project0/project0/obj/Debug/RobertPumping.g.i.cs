﻿#pragma checksum "..\..\RobertPumping.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5BB1C1841C1F3BBC7A18D132481A27E48DACDAC9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using project0;


namespace project0 {
    
    
    /// <summary>
    /// RobertPumping
    /// </summary>
    public partial class RobertPumping : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 166 "..\..\RobertPumping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse robertHead;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\RobertPumping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Bar;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\RobertPumping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse rightWeight;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\RobertPumping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse leftWeight;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\RobertPumping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image leftBicep;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\RobertPumping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image rightBicep;
        
        #line default
        #line hidden
        
        
        #line 217 "..\..\RobertPumping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image leftForearm;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\RobertPumping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image rightForearm;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RobertButton;component/robertpumping.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RobertPumping.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\RobertPumping.xaml"
            ((System.Windows.Media.Animation.Storyboard)(target)).Completed += new System.EventHandler(this.Storyboard_Completed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 84 "..\..\RobertPumping.xaml"
            ((System.Windows.Media.Animation.Storyboard)(target)).Completed += new System.EventHandler(this.Storyboard_Completed_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.robertHead = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 4:
            this.Bar = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.rightWeight = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 6:
            this.leftWeight = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 7:
            this.leftBicep = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.rightBicep = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.leftForearm = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.rightForearm = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

