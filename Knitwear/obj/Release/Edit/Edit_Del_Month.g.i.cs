﻿#pragma checksum "..\..\..\Edit\Edit_Del_Month.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D85C0F618DEAD83D2D5EF20191180D8250036FF84058DE68BE671FADF2D830EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.Sharp;
using Knitwear.Edit;
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


namespace Knitwear.Edit {
    
    
    /// <summary>
    /// Edit_Del_Month
    /// </summary>
    public partial class Edit_Del_Month : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\..\Edit\Edit_Del_Month.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Edit\Edit_Del_Month.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MMonth_Nomenclature;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Edit\Edit_Del_Month.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MMonth_Volume;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\Edit\Edit_Del_Month.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MMonth_Note;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\Edit\Edit_Del_Month.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Plan_Month_Edit;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\Edit\Edit_Del_Month.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Month_Check;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\Edit\Edit_Del_Month.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Month_Del;
        
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
            System.Uri resourceLocater = new System.Uri("/Knitwear;component/edit/edit_del_month.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Edit\Edit_Del_Month.xaml"
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
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Edit\Edit_Del_Month.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MMonth_Nomenclature = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MMonth_Volume = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.MMonth_Note = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Plan_Month_Edit = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\..\Edit\Edit_Del_Month.xaml"
            this.Plan_Month_Edit.Click += new System.Windows.RoutedEventHandler(this.Plan_Month_Edit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Month_Check = ((System.Windows.Controls.Button)(target));
            
            #line 152 "..\..\..\Edit\Edit_Del_Month.xaml"
            this.Month_Check.Click += new System.Windows.RoutedEventHandler(this.Month_Check_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Month_Del = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\..\Edit\Edit_Del_Month.xaml"
            this.Month_Del.Click += new System.Windows.RoutedEventHandler(this.Month_Del_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

