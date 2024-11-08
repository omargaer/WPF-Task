﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39309A1195B3A0BA3B78A94EA5FB7B77A44EE624"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
using WPF_Task;


namespace WPF_Task {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 87 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ToDoListBox;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox InProgressListBox;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox DoneListBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF Task;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ToDoListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 88 "..\..\..\MainWindow.xaml"
            this.ToDoListBox.ContextMenuOpening += new System.Windows.Controls.ContextMenuEventHandler(this.ListBox_ContextMenuOpening);
            
            #line default
            #line hidden
            
            #line 89 "..\..\..\MainWindow.xaml"
            this.ToDoListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 91 "..\..\..\MainWindow.xaml"
            this.ToDoListBox.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ListBox_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 92 "..\..\..\MainWindow.xaml"
            this.ToDoListBox.Drop += new System.Windows.DragEventHandler(this.ListBox_Drop);
            
            #line default
            #line hidden
            
            #line 93 "..\..\..\MainWindow.xaml"
            this.ToDoListBox.DragOver += new System.Windows.DragEventHandler(this.ListBox_DragOver);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 96 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MoveToInProgress_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 97 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MoveToDone_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 101 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddTask_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.InProgressListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 110 "..\..\..\MainWindow.xaml"
            this.InProgressListBox.ContextMenuOpening += new System.Windows.Controls.ContextMenuEventHandler(this.ListBox_ContextMenuOpening);
            
            #line default
            #line hidden
            
            #line 111 "..\..\..\MainWindow.xaml"
            this.InProgressListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 113 "..\..\..\MainWindow.xaml"
            this.InProgressListBox.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ListBox_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 114 "..\..\..\MainWindow.xaml"
            this.InProgressListBox.Drop += new System.Windows.DragEventHandler(this.ListBox_Drop);
            
            #line default
            #line hidden
            
            #line 115 "..\..\..\MainWindow.xaml"
            this.InProgressListBox.DragOver += new System.Windows.DragEventHandler(this.ListBox_DragOver);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 118 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MoveToToDo_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 119 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MoveToDone_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DoneListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 131 "..\..\..\MainWindow.xaml"
            this.DoneListBox.ContextMenuOpening += new System.Windows.Controls.ContextMenuEventHandler(this.ListBox_ContextMenuOpening);
            
            #line default
            #line hidden
            
            #line 133 "..\..\..\MainWindow.xaml"
            this.DoneListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 134 "..\..\..\MainWindow.xaml"
            this.DoneListBox.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ListBox_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 135 "..\..\..\MainWindow.xaml"
            this.DoneListBox.Drop += new System.Windows.DragEventHandler(this.ListBox_Drop);
            
            #line default
            #line hidden
            
            #line 136 "..\..\..\MainWindow.xaml"
            this.DoneListBox.DragOver += new System.Windows.DragEventHandler(this.ListBox_DragOver);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 139 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MoveToToDo_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 140 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MoveToInProgress_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

