// Updated by XamlIntelliSenseFileGenerator Вт 04.04.23 19:26:45
#pragma checksum "..\..\..\Auth_Capt\Auth.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A65EE1DD3DB9735E4CF123C99B5F04096E9BEB4FCBE03C9857A66C4365071F5B"
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
using Knitwear.Auth_Capt;
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


namespace Knitwear.Auth_Capt
{


    /// <summary>
    /// Auth
    /// </summary>
    public partial class Auth : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 74 "..\..\..\Auth_Capt\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;

#line default
#line hidden


#line 81 "..\..\..\Auth_Capt\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;

#line default
#line hidden


#line 116 "..\..\..\Auth_Capt\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;

#line default
#line hidden


#line 141 "..\..\..\Auth_Capt\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;

#line default
#line hidden


#line 159 "..\..\..\Auth_Capt\Auth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Knitwear;component/auth_capt/auth.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Auth_Capt\Auth.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 14 "..\..\..\Auth_Capt\Auth.xaml"
                    ((Knitwear.Auth_Capt.Auth)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);

#line default
#line hidden
                    return;
                case 2:
                    this.btnClose = ((System.Windows.Controls.Button)(target));

#line 76 "..\..\..\Auth_Capt\Auth.xaml"
                    this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.btnMinimize = ((System.Windows.Controls.Button)(target));

#line 83 "..\..\..\Auth_Capt\Auth.xaml"
                    this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.Login = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.Password = ((System.Windows.Controls.PasswordBox)(target));
                    return;
                case 6:
                    this.btnLogin = ((System.Windows.Controls.Button)(target));

#line 167 "..\..\..\Auth_Capt\Auth.xaml"
                    this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.Avt_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

