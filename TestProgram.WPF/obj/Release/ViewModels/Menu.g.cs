﻿#pragma checksum "..\..\..\ViewModels\Menu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5740F7D7065DE51E47134A80A1082AD9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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
using TestProgram.WPF.ViewModels;


namespace TestProgram.WPF.ViewModels {
    
    
    /// <summary>
    /// Menu
    /// </summary>
    public partial class Menu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\ViewModels\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid pnlMenu;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\ViewModels\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlButtonMenu;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\ViewModels\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGroups;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\ViewModels\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock groupTextBlock;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\ViewModels\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMessage;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\ViewModels\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock messageTextBlock;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ViewModels\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSettings;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\ViewModels\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock settingsTextBlock;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\ViewModels\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Separator separatorekXD;
        
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
            System.Uri resourceLocater = new System.Uri("/TestProgram.WPF;component/viewmodels/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewModels\Menu.xaml"
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
            this.pnlMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.pnlButtonMenu = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.btnGroups = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\ViewModels\Menu.xaml"
            this.btnGroups.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnGroups_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.groupTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btnMessage = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\ViewModels\Menu.xaml"
            this.btnMessage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnMessage_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.messageTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.btnSettings = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\ViewModels\Menu.xaml"
            this.btnSettings.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnSettings_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.settingsTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.separatorekXD = ((System.Windows.Controls.Separator)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

