﻿#pragma checksum "..\..\Statistic_Handle.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D5979EED46DEC9698BD7F9AEFB240DBE30CC8EEAFDF3280F685CD5F6F3EB761A"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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


namespace 马卡龙零售店 {
    
    
    /// <summary>
    /// Statistic_Handle
    /// </summary>
    public partial class Statistic_Handle : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\Statistic_Handle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_From;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Statistic_Handle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_To;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Statistic_Handle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tb_Month_Before;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Statistic_Handle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tb_Month_Now;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Statistic_Handle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tb_Month_After;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Statistic_Handle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tb_Day_Before;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Statistic_Handle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tb_Day_Now;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Statistic_Handle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tb_Day_After;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Statistic_Handle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tb_Back;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Statistic_Handle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_Handles;
        
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
            System.Uri resourceLocater = new System.Uri("/马卡龙零售店;component/statistic_handle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Statistic_Handle.xaml"
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
            
            #line 7 "..\..\Statistic_Handle.xaml"
            ((马卡龙零售店.Statistic_Handle)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_From = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_To = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_Month_Before = ((System.Windows.Controls.Label)(target));
            
            #line 26 "..\..\Statistic_Handle.xaml"
            this.tb_Month_Before.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.tb_Month_Before_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tb_Month_Now = ((System.Windows.Controls.Label)(target));
            
            #line 27 "..\..\Statistic_Handle.xaml"
            this.tb_Month_Now.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.tb_Month_Now_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tb_Month_After = ((System.Windows.Controls.Label)(target));
            
            #line 28 "..\..\Statistic_Handle.xaml"
            this.tb_Month_After.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.tb_Month_After_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tb_Day_Before = ((System.Windows.Controls.Label)(target));
            
            #line 29 "..\..\Statistic_Handle.xaml"
            this.tb_Day_Before.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.tb_Day_Before_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tb_Day_Now = ((System.Windows.Controls.Label)(target));
            
            #line 30 "..\..\Statistic_Handle.xaml"
            this.tb_Day_Now.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.tb_Day_Now_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tb_Day_After = ((System.Windows.Controls.Label)(target));
            
            #line 31 "..\..\Statistic_Handle.xaml"
            this.tb_Day_After.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.tb_Day_After_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tb_Back = ((System.Windows.Controls.Label)(target));
            
            #line 32 "..\..\Statistic_Handle.xaml"
            this.tb_Back.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.tb_Back_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lv_Handles = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

