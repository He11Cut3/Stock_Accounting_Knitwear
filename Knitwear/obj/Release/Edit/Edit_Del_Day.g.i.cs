﻿#pragma checksum "..\..\..\Edit\Edit_Del_Day.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5EC304AD9682D70DAD73A37C1C74EE8D464DFEE143C19D47E898A4828217FC52"
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
    /// Edit_Del_Day
    /// </summary>
    public partial class Edit_Del_Day : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\..\Edit\Edit_Del_Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Edit\Edit_Del_Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DDay_Nomenclature;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Edit\Edit_Del_Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DDay_Volume;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Edit\Edit_Del_Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DDay_Note;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\Edit\Edit_Del_Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LV_User_Grid;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Edit\Edit_Del_Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Plan_Day_Edit;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\Edit\Edit_Del_Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Day_Check;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\Edit\Edit_Del_Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Day_Del;
        
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
            System.Uri resourceLocater = new System.Uri("/Knitwear;component/edit/edit_del_day.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Edit\Edit_Del_Day.xaml"
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
            
            #line 58 "..\..\..\Edit\Edit_Del_Day.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DDay_Nomenclature = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DDay_Volume = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DDay_Note = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LV_User_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.Plan_Day_Edit = ((System.Windows.Controls.Button)(target));
            
            #line 145 "..\..\..\Edit\Edit_Del_Day.xaml"
            this.Plan_Day_Edit.Click += new System.Windows.RoutedEventHandler(this.Plan_Day_Edit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Day_Check = ((System.Windows.Controls.Button)(target));
            
            #line 157 "..\..\..\Edit\Edit_Del_Day.xaml"
            this.Day_Check.Click += new System.Windows.RoutedEventHandler(this.Day_Check_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Day_Del = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\..\Edit\Edit_Del_Day.xaml"
            this.Day_Del.Click += new System.Windows.RoutedEventHandler(this.Day_Del_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

