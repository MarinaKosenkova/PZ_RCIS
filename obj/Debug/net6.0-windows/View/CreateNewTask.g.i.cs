﻿#pragma checksum "..\..\..\..\View\CreateNewTask.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36E48726F60C74A9F9380171A63A106D312BD14F"
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
    /// CreateNewTask
    /// </summary>
    public partial class CreateNewTask : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\View\CreateNewTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleNewTaskTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\View\CreateNewTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CategoryNewTaskTextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\View\CreateNewTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateNewTaskDatePicker;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\View\CreateNewTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TimePickerTextBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\View\CreateNewTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DoneNewTaskButton;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\View\CreateNewTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelNewTaskButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Desktop;V1.0.0.0;component/view/createnewtask.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\CreateNewTask.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TitleNewTaskTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CategoryNewTaskTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 35 "..\..\..\..\View\CreateNewTask.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteCategoryMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DateNewTaskDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.TimePickerTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\..\..\View\CreateNewTask.xaml"
            this.TimePickerTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TimePickerTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\..\View\CreateNewTask.xaml"
            this.TimePickerTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TimePickerTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DoneNewTaskButton = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\..\View\CreateNewTask.xaml"
            this.DoneNewTaskButton.Click += new System.Windows.RoutedEventHandler(this.DoneNewTaskButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CancelNewTaskButton = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\View\CreateNewTask.xaml"
            this.CancelNewTaskButton.Click += new System.Windows.RoutedEventHandler(this.CancelNewTaskButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

