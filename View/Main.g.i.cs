﻿#pragma checksum "..\..\..\..\View\Main.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0609168717C3D43374241AA367E1E43FF160B537"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Desktop.TaskFolder;
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
    /// Main
    /// </summary>
    public partial class Main : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image profileImageButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserNameBlock;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid menuGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button profileImageSwitch;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border CreateNewTaskB;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel CategorySPanel;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ItemsTasksSPanel;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TaskInfoBlock;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Desktop.TaskFolder.TaskInfo TaskI;
        
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
            System.Uri resourceLocater = new System.Uri("/Desktop;component/view/main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Main.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.profileImageButton = ((System.Windows.Controls.Image)(target));
            
            #line 17 "..\..\..\..\View\Main.xaml"
            this.profileImageButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ProfileImageButton_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UserNameBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.menuGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 19 "..\..\..\..\View\Main.xaml"
            this.menuGrid.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuGrid_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.exitB = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\View\Main.xaml"
            this.exitB.Click += new System.Windows.RoutedEventHandler(this.ExitB_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.profileImageSwitch = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\View\Main.xaml"
            this.profileImageSwitch.Click += new System.Windows.RoutedEventHandler(this.ProfileImageSwitch_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 23 "..\..\..\..\View\Main.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TasksTextBlock_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 24 "..\..\..\..\View\Main.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.HistoryTextBlock_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CreateNewTaskB = ((System.Windows.Controls.Border)(target));
            
            #line 26 "..\..\..\..\View\Main.xaml"
            this.CreateNewTaskB.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CreateNewTaskB_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CategorySPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            
            #line 44 "..\..\..\..\View\Main.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CategoryTextBlock_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 45 "..\..\..\..\View\Main.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CategoryTextBlock_MouseDown);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 46 "..\..\..\..\View\Main.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CategoryTextBlock_MouseDown);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 47 "..\..\..\..\View\Main.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CategoryTextBlock_MouseDown);
            
            #line default
            #line hidden
            return;
            case 14:
            this.ItemsTasksSPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 15:
            this.TaskInfoBlock = ((System.Windows.Controls.Grid)(target));
            return;
            case 16:
            this.TaskI = ((Desktop.TaskFolder.TaskInfo)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

