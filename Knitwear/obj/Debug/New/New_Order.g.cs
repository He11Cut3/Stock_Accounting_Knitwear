﻿#pragma checksum "..\..\..\New\New_Order.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "55D4D0A690F474C3ED2D28F075883FAFCEDD1C43543DCB2A5EA15DC7E4609233"
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
using Knitwear.New;
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


namespace Knitwear.New {
    
    
    /// <summary>
    /// New_Order
    /// </summary>
    public partial class New_Order : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 59 "..\..\..\New\New_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\New\New_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OOrder_Name;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\New\New_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OOrder_Vendor_Code;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\New\New_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OOrder_Weight;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\New\New_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OOrder_Number_Boxes;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\New\New_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OOrder_Date;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\New\New_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OOrder_Status;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\New\New_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Order;
        
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
            System.Uri resourceLocater = new System.Uri("/Knitwear;component/new/new_order.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\New\New_Order.xaml"
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
            
            #line 61 "..\..\..\New\New_Order.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OOrder_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.OOrder_Vendor_Code = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.OOrder_Weight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.OOrder_Number_Boxes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.OOrder_Date = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.OOrder_Status = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Order = ((System.Windows.Controls.Button)(target));
            
            #line 182 "..\..\..\New\New_Order.xaml"
            this.Order.Click += new System.Windows.RoutedEventHandler(this.Order_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

