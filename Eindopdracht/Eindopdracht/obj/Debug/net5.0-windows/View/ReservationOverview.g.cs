#pragma checksum "..\..\..\..\View\ReservationOverview.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7DE5623A6B1BA61F9E044FBBA22CC0210D2A7DE8"
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
    /// ReservationOverview
    /// </summary>
    public partial class ReservationOverview : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\View\ReservationOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame _NavigationFrame;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\ReservationOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ReservationGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\ReservationOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridView grdTest;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\View\ReservationOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\View\ReservationOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openAddReservationPage;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\View\ReservationOverview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/Eindopdracht;component/view/reservationoverview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\ReservationOverview.xaml"
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
            this.ReservationGrid = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.grdTest = ((System.Windows.Controls.GridView)(target));
            return;
            case 4:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\View\ReservationOverview.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.OpenUpdateReservationPage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.openAddReservationPage = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\View\ReservationOverview.xaml"
            this.openAddReservationPage.Click += new System.Windows.RoutedEventHandler(this.OpenAddReservationPage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

