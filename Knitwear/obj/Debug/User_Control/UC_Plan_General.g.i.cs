﻿#pragma checksum "..\..\..\User_Control\UC_Plan_General.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E94FFE51A8C1632A8DABA6931C8A565316E13FF03726309366F82CCC862EFEB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Knitwear.User_Control;
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


namespace Knitwear.User_Control {
    
    
    /// <summary>
    /// UC_Plan_General
    /// </summary>
    public partial class UC_Plan_General : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 22 "..\..\..\User_Control\UC_Plan_General.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button New_Plan_Day;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\User_Control\UC_Plan_General.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ex_Plan_Day;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\User_Control\UC_Plan_General.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LV_Plan_Day_;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\User_Control\UC_Plan_General.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LV_Plan_Week_;
        
        #line default
        #line hidden
        
        
        #line 249 "..\..\..\User_Control\UC_Plan_General.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LV_Plan_Month_;
        
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
            System.Uri resourceLocater = new System.Uri("/Knitwear;component/user_control/uc_plan_general.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User_Control\UC_Plan_General.xaml"
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
            this.New_Plan_Day = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\User_Control\UC_Plan_General.xaml"
            this.New_Plan_Day.Click += new System.Windows.RoutedEventHandler(this.New_Plan_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Ex_Plan_Day = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\User_Control\UC_Plan_General.xaml"
            this.Ex_Plan_Day.Click += new System.Windows.RoutedEventHandler(this.Ex_Plan_Day_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LV_Plan_Day_ = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.LV_Plan_Week_ = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.LV_Plan_Month_ = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 4:
            
            #line 136 "..\..\..\User_Control\UC_Plan_General.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_del_Click);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 229 "..\..\..\User_Control\UC_Plan_General.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Del_Week_Click);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 323 "..\..\..\User_Control\UC_Plan_General.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Del_Month_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
