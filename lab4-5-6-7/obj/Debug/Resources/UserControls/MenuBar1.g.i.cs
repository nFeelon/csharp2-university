﻿#pragma checksum "..\..\..\..\Resources\UserControls\MenuBar1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B701665F8F9B713E467D39A2FC0222844C7E85D02FB08BADE27E966BD53F420E"
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
using lab4_5.Resources.UserControls;


namespace lab4_5.Resources.UserControls {
    
    
    /// <summary>
    /// MenuBar1
    /// </summary>
    public partial class MenuBar1 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RussianButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EnglishButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DarkThemeButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem LightThemeButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ProjectName;
        
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
            System.Uri resourceLocater = new System.Uri("/lab4-5;component/resources/usercontrols/menubar1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
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
            
            #line 17 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.NewProjectButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 19 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 22 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.UndoButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 23 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RedoButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RussianButton = ((System.Windows.Controls.MenuItem)(target));
            
            #line 27 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
            this.RussianButton.Click += new System.Windows.RoutedEventHandler(this.LanguageChangeButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.EnglishButton = ((System.Windows.Controls.MenuItem)(target));
            
            #line 28 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
            this.EnglishButton.Click += new System.Windows.RoutedEventHandler(this.LanguageChangeButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DarkThemeButton = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
            this.DarkThemeButton.Click += new System.Windows.RoutedEventHandler(this.DarkThemeButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.LightThemeButton = ((System.Windows.Controls.MenuItem)(target));
            
            #line 32 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
            this.LightThemeButton.Click += new System.Windows.RoutedEventHandler(this.LightThemeButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 34 "..\..\..\..\Resources\UserControls\MenuBar1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AboutButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ProjectName = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

