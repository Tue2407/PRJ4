﻿#pragma checksum "..\..\slidingPuzzle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "074460B7D6F4D9C99DA772D0D244E038AB238513"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI;
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


namespace GUI {
    
    
    /// <summary>
    /// slidingPuzzle
    /// </summary>
    public partial class slidingPuzzle : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\slidingPuzzle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid slidingPuzzleGrid;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\slidingPuzzle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\slidingPuzzle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button login;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\slidingPuzzle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LblTime;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\slidingPuzzle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\slidingPuzzle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Stop;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\slidingPuzzle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Picture;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\slidingPuzzle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PictureTest;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI;component/slidingpuzzle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\slidingPuzzle.xaml"
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
            this.slidingPuzzleGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 33 "..\..\slidingPuzzle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.New_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 34 "..\..\slidingPuzzle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 36 "..\..\slidingPuzzle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\slidingPuzzle.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.login = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\slidingPuzzle.xaml"
            this.login.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LblTime = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.Start = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\slidingPuzzle.xaml"
            this.Start.Click += new System.Windows.RoutedEventHandler(this.Start_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Stop = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\slidingPuzzle.xaml"
            this.Stop.Click += new System.Windows.RoutedEventHandler(this.Stop_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Picture = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\slidingPuzzle.xaml"
            this.Picture.Click += new System.Windows.RoutedEventHandler(this.Picture_OnClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.PictureTest = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\slidingPuzzle.xaml"
            this.PictureTest.Click += new System.Windows.RoutedEventHandler(this.PictureTest_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

