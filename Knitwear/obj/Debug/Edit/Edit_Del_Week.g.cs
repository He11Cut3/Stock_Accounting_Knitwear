﻿#pragma checksum "..\..\..\Edit\Edit_Del_Week.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7643B028CD52ED67213F4AFA2555B222FCAFF3F94B309C5DD58F2B9636D47F1"
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
    /// Edit_Del_Week
    /// </summary>
    public partial class Edit_Del_Week : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\..\Edit\Edit_Del_Week.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Edit\Edit_Del_Week.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nomen;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Edit\Edit_Del_Week.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox myComboBox1;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\Edit\Edit_Del_Week.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Note;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\Edit\Edit_Del_Week.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Plan_Week_Edit;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\Edit\Edit_Del_Week.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Week_Check;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\Edit\Edit_Del_Week.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Week_Del;
        
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
            System.Uri resourceLocater = new System.Uri("/Knitwear;component/edit/edit_del_week.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Edit\Edit_Del_Week.xaml"
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
            
            #line 58 "..\..\..\Edit\Edit_Del_Week.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Nomen = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.myComboBox1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Note = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Plan_Week_Edit = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\Edit\Edit_Del_Week.xaml"
            this.Plan_Week_Edit.Click += new System.Windows.RoutedEventHandler(this.Plan_Week_Edit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Week_Check = ((System.Windows.Controls.Button)(target));
            
            #line 159 "..\..\..\Edit\Edit_Del_Week.xaml"
            this.Week_Check.Click += new System.Windows.RoutedEventHandler(this.Week_Check_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Week_Del = ((System.Windows.Controls.Button)(target));
            
            #line 168 "..\..\..\Edit\Edit_Del_Week.xaml"
            this.Week_Del.Click += new System.Windows.RoutedEventHandler(this.Week_Del_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

