﻿#pragma checksum "..\..\..\Apresentacao\frmUsuario.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86BC11F117390458D02AA9A025DC2EE37DE8C621"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using SistemaEvolution.Apresentacao;
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


namespace SistemaEvolution.Apresentacao {
    
    
    /// <summary>
    /// frmUsuario
    /// </summary>
    public partial class frmUsuario : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Apresentacao\frmUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbIdUsuario;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Apresentacao\frmUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbSenha;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Apresentacao\frmUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Senha;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Apresentacao\frmUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbConfirmarSenha;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Apresentacao\frmUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCadastrarUsuario;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Apresentacao\frmUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFuncionario;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Apresentacao\frmUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbCliente;
        
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
            System.Uri resourceLocater = new System.Uri("/SistemaEvolution;component/apresentacao/frmusuario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Apresentacao\frmUsuario.xaml"
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
            this.txbIdUsuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txbSenha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Senha = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txbConfirmarSenha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnCadastrarUsuario = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.rbFuncionario = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.rbCliente = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
