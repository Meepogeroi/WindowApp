﻿#pragma checksum "..\..\..\Pages\PageForModer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B13B182F870610653260723B92E2724B5C8CD79F973606FEE3EE14FCA6A39B56"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WindowAppWPF.Pages;


namespace WindowAppWPF.Pages {
    
    
    /// <summary>
    /// PageForModer
    /// </summary>
    public partial class PageForModer : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\PageForModer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataView;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\PageForModer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ForAdmin;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\PageForModer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveChange;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\PageForModer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\PageForModer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButtonForModer;
        
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
            System.Uri resourceLocater = new System.Uri("/WindowAppWPF;component/pages/pageformoder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageForModer.xaml"
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
            this.dataView = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.ForAdmin = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.saveChange = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Pages\PageForModer.xaml"
            this.saveChange.Click += new System.Windows.RoutedEventHandler(this.saveChange_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\PageForModer.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BackButtonForModer = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\PageForModer.xaml"
            this.BackButtonForModer.Click += new System.Windows.RoutedEventHandler(this.BackButtonForModer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

