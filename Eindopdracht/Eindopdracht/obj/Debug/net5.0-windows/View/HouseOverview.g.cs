﻿#pragma checksum "..\..\..\..\View\HouseOverview.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12FE5A91DBB01F0B54229272EFE489225A07730D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Eindopdracht.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Eindopdracht.View {
    
    
    /// <summary>
    /// HouseOverview
    /// </summary>
    public partial class HouseOverview : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\View\HouseOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame _NavigationFrame;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\HouseOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView HouseGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\HouseOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridView grdTest;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\View\HouseOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateHouse;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\View\HouseOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteHouse;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\View\HouseOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openAddHousePage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.14.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Eindopdracht;component/view/houseoverview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\HouseOverview.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.14.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this._NavigationFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.HouseGrid = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.grdTest = ((System.Windows.Controls.GridView)(target));
            return;
            case 4:
            this.btnUpdateHouse = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\View\HouseOverview.xaml"
            this.btnUpdateHouse.Click += new System.Windows.RoutedEventHandler(this.OpenUpdateHousePage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnDeleteHouse = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.openAddHousePage = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\View\HouseOverview.xaml"
            this.openAddHousePage.Click += new System.Windows.RoutedEventHandler(this.OpenAddHousePage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

