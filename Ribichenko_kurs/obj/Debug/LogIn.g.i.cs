﻿#pragma checksum "..\..\LogIn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF7E807DEBF1DF03815EF315D317FE8DF1DB5616B699770C0F57A555E505334A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Ribichenko_kurs;
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


namespace Ribichenko_kurs {
    
    
    /// <summary>
    /// LogIn
    /// </summary>
    public partial class LogIn : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Sver;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Close;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image logo;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox reg_mail;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox reg_pass;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\LogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button login_button;
        
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
            System.Uri resourceLocater = new System.Uri("/Ribichenko_kurs;component/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LogIn.xaml"
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
            this.Button_Sver = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\LogIn.xaml"
            this.Button_Sver.Click += new System.Windows.RoutedEventHandler(this.Button_Sver_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Button_Close = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\LogIn.xaml"
            this.Button_Close.Click += new System.Windows.RoutedEventHandler(this.Button_Close_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.logo = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.img = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.reg_mail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.reg_pass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 89 "..\..\LogIn.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.sbros_link_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.login_button = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\LogIn.xaml"
            this.login_button.Click += new System.Windows.RoutedEventHandler(this.login_button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 106 "..\..\LogIn.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.reg_link_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

