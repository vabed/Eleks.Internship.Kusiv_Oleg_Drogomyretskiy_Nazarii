﻿#pragma checksum "..\..\..\Pages\PageStatistic.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B080D64A46FCDCE834C2B3C13698557739536F1E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using VkWPF.Pages;


namespace VkWPF.Pages {
    
    
    /// <summary>
    /// PageStatistic
    /// </summary>
    public partial class PageStatistic : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Pages\PageStatistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VkWPF.Pages.PageStatistic pageStatistic;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\PageStatistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxId;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\PageStatistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFriends;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\PageStatistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFriendsOnline;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\PageStatistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frameFriends;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\PageStatistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frameStatistic;
        
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
            System.Uri resourceLocater = new System.Uri("/VkWPF;component/pages/pagestatistic.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageStatistic.xaml"
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
            this.pageStatistic = ((VkWPF.Pages.PageStatistic)(target));
            return;
            case 2:
            this.tbxId = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\Pages\PageStatistic.xaml"
            this.tbxId.KeyUp += new System.Windows.Input.KeyEventHandler(this.tbxId_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnFriends = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Pages\PageStatistic.xaml"
            this.btnFriends.Click += new System.Windows.RoutedEventHandler(this.btnFriends_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnFriendsOnline = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\PageStatistic.xaml"
            this.btnFriendsOnline.Click += new System.Windows.RoutedEventHandler(this.btnFriendsOnline_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.frameFriends = ((System.Windows.Controls.Frame)(target));
            
            #line 41 "..\..\..\Pages\PageStatistic.xaml"
            this.frameFriends.MouseLeave += new System.Windows.Input.MouseEventHandler(this.frameFriends_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.frameStatistic = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

