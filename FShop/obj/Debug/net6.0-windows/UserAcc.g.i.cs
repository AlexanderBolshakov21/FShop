﻿#pragma checksum "..\..\..\UserAcc.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C160E674A5740D9EF97EBE8BF571116F3447A0EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FShop;
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


namespace FShop {
    
    
    /// <summary>
    /// User
    /// </summary>
    public partial class User : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\..\UserAcc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label loginlab;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\UserAcc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox logtb;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\UserAcc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fullnamelab;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\UserAcc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fulltb;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\UserAcc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label phonelab;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\UserAcc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phtb;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\UserAcc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridUser;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\UserAcc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeButton;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\UserAcc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FShop;V1.0.0.0;component/useracc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserAcc.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 24 "..\..\..\UserAcc.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.loginlab = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.logtb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.fullnamelab = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.fulltb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.phonelab = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.phtb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.DGridUser = ((System.Windows.Controls.DataGrid)(target));
            
            #line 71 "..\..\..\UserAcc.xaml"
            this.DGridUser.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DGridUser_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ChangeButton = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\UserAcc.xaml"
            this.ChangeButton.Click += new System.Windows.RoutedEventHandler(this.ChangeButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\UserAcc.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

