   M S B A M L   `   `   `  ����K  GSistemaEvolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SistemaEvolution.ApresentacaoSistemaEvolution.Apresentacao  5   	   6    0SistemaEvolution.Apresentacao.frmPaginaPrincipal   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SistemaEvolution.Apresentacao     5   	   -   5          �Name$  frmPaginaInicial��5   	    � Title$ Pagina Inicial��5   	   $��627.973��6    $��1264.603��61    � WindowStartupLocation$ CenterScreen=�6B    � WindowStyle$ 
ToolWindow=�6g    � 
ResizeMode$ NoResize=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   o� $
��Left=�6   $��84��6*   $��
155,10,0,0q�66   $	��Top=�6J   $
��1092��6b   .@�5      m� -   5         m�Name$ mniPaginaCadastros��5      $�� ��63   $	��100��6=   $	��164��6J   $��18(�6V   ��5      �� 5       �� ImageSource$( "Imagens/Layout botao cadastros.png��6!    j� Stretch$
 Fill=�6R   	 j� TileMode$	 FlipX=�6a   .@�5      m� -   5        $ mniPaginaUsuarios��5      $�� ��66   $
��Left=�6@   $	��100��6[   $	��167��6h   ��5      �� 5      $&  Imagens/Layout list usuarios.png��6%   5      m� 5      -   5        $ mniPaginaClientes��5      $�� ��66   $
��Left=�6@   $	��100��6[   $	��167��6h   ��5      �� 5      $% Imagens/layout list cliente.png��6%   5      m� 5       -   5        $ mniPaginaProdutos��5       $�� ��66   $
��Left=�6@   $	��100��6[   $	��167��6h   ��5!      �� 5"      $% Imagens/layout list produto.png��6%   5$      m� 5%      -   5        $ mniPaginaFuncionario��5%      $�� ��69   $
��Left=�6C   $	��100��6^   $	��167��6k   ��5&      �� 5'      $* $Imagens/layout botao funcionario.png��6%   5)      5*      m� 5+      $�� ��6   $	��100��6!   $	��177��6.   ��5,      �� 5-      $+ %Imagens/layout botao atendimentos.png��6!   .@�5/      m� -   5        $ mniPaginaChamados��5/      $�� ��66   $	��100��6@   $	��164��6M   $��18(�6Y   ��50      �� 51      $&  Imagens/layout list chamados.png��6%   54      55      56      �� 57   
   $
��Left=�6   $	��192��6+   $��1034,450,0,-45q�68   $	��Top=�6P   $	��198��6h   $!��Imagens/LOGOMIJHSYSTENS.png��6t   $��2��6�   
 J� OpacityMask
 58      �� 59      $! Imagens/LOGOMIJHSYSTENS.png��6   5;      �� 5<   
   $
��Left=�6   $	��360��6+   $��282,173,0,0q�68   $	��Top=�6M   $	��640��6e   $��Imagens/logoSistema.png��6q   
 5=      �� 5>      $ Imagens/logoSistema.png��6   5@      �� 5A   
   $
��Left=�6   $��94��6+   $	��Top=�67   $	��150��6O   �� 5B   
   $��0,7,1102,496q�6   $A��;/SistemaEvolution;component/Layout botao pagina inicial.png��6&   $
��Fill=�6k   5D      5E      