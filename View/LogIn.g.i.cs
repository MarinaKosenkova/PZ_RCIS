﻿#pragma checksum "..\..\..\..\View\LogIn.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1AD2097FEAB68C1EA7F2C4CD80F7CF1824F17ECB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Desktop.View;
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


namespace Desktop.View {
    
    
    /// <summary>
    /// LogIn
    /// </summary>
    public partial class LogIn : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\View\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mailBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\View\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginB;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\View\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button registrationB;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock passBlock;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passPASSwordBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Desktop;component/view/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\LogIn.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mailBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\..\View\LogIn.xaml"
            this.mailBox.GotFocus += new System.Windows.RoutedEventHandler(this.MailBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\..\View\LogIn.xaml"
            this.mailBox.LostFocus += new System.Windows.RoutedEventHandler(this.MailBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.loginB = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\View\LogIn.xaml"
            this.loginB.Click += new System.Windows.RoutedEventHandler(this.LoginB_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.registrationB = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\View\LogIn.xaml"
            this.registrationB.Click += new System.Windows.RoutedEventHandler(this.RegistrationB_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.passBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.passPASSwordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 42 "..\..\..\..\View\LogIn.xaml"
            this.passPASSwordBox.GotFocus += new System.Windows.RoutedEventHandler(this.PassPASSwordBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\..\View\LogIn.xaml"
            this.passPASSwordBox.LostFocus += new System.Windows.RoutedEventHandler(this.PassPASSwordBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\..\View\LogIn.xaml"
            this.passPASSwordBox.PasswordChanged += new System.Windows.RoutedEventHandler(this.PassPASSwordBox_PasswordChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

