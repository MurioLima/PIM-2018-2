   M S B A M L   `   `   `  ����K  GSistemaEvolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SistemaEvolution.ApresentacaoSistemaEvolution.Apresentacao  5   	   .    (SistemaEvolution.Apresentacao.frmChamado   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SistemaEvolution.Apresentacao     5   	   -   5          �Name$  frmChamado1��5   	    � Title$ frmChamados��5   	   $��627.973��6   $��1264.603��6.    � WindowStartupLocation$ CenterScreen=�6?    � WindowStyle$ 
ToolWindow=�6d    � 
ResizeMode$ NoResize=�6}   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� $
��Left=�6   $	��597��60   $��	-3,0,-5,0q�6=   $	��Top=�6P   $
��1265��6h   .@�5      �� -   5         ��Name$ tbcVisualizarChamados��5      $��Visualizar Chamados��65   .��5      � ���	#FFE5E5E5.+�5      �� -   5         ��Name$ txbCodigoChamado��5      $
��Left=�68   $��40��6S   $��230,144,0,0q�6_    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��119��6�   $��20(�6�   	 �� MaxLines$	 1��6�   
 �� 	MaxLength$
 5��6�   �� 5      $(��"Descrição do chamado do cliente:��6   $
��Left=�6G   $��
452,33,0,0q�6b   $	��Top=�6v   $	��310��6�   $��40��6�   $��20(�6�   �� 5      -   5        $! txbDescriçaoChamadoCliente��5      $
��Left=�6B   $	��202��6]   $��
452,78,0,0q�6j   $
 Wrap=�6~   $	��Top=�6�   $	��781��6�   $��20(�6�   $	 8��6�   $	
 500��6�   �� 5      $��Data do Chamado:��6   $
��Left=�67   $��1063,39,0,0q�6R   $	��Top=�6g   $	��170��6   $��40��6�   $��17(�6�   �� 5      $��Visualizar Chamados��6   $
��Left=�6:   $��46��6U   $��	20,16,0,0q�6a   $	��Top=�6t   $	��282��6�   $��30(�6�   �� 5      $��Código do Chamado:��6   $
��Left=�69   $��
26,144,0,0q�6T   $	��Top=�6h   $	��200��6�   $��40��6�   $��20(�6�   �� 5      $
��Left=�6   $	��173��67   $��
26,189,0,0q�6D   $	��Top=�6X   $	��173��6p   $A��;Imagens/software-clipart-broken-computer-770972-3364939.png��6|    J� RenderTransformOrigin$ 2.405,0.214&�6�    J� OpacityMask 5      �� 5       �� ImageSource$A ;Imagens/software-clipart-broken-computer-770972-3364939.png��6)   5      �� 5      -   5        $ txbCodigoAtendimento��5      $
��Left=�6<   $��40��6W   $��254,374,0,0q�6c   $
 Wrap=�6x   $	��Top=�6�   $	��120��6�   $��20(�6�   �� 5      $��Código do Atendimento:��6   $
��Left=�6=   $��
20,374,0,0q�6X   $	��Top=�6l   $��20(�6�   �� 5      -   5        $$ txbDescricaoChamadoFuncionario��5      $
��Left=�6F   $	��122��6a   $��452,362,0,0q�6n   $
 Wrap=�6�   $	��Top=�6�   $	��781��6�   $��20(�6�   �� 5      $��Prioridade:��6   $
��Left=�62   $��
22,447,0,0q�6M   $	��Top=�6a   $��20(�6y   �� 5      $-��'Descrição do chamado do funcionário:��6   $
��Left=�6K   $��452,320,0,0q�6f   $	��Top=�6{   $��20(�6�   	� 5       -   5         	�Name$ 
rdbUrgente��5    "   $��	0-Urgente��66   $
��Left=�6J   $��137,446,0,0q�6e   $	��Top=�6z   $��18(�6�   	� 5!      -   5        $ rdbSemiUrgente��5!   "   $��2-Semi-Urgente��6:   $
��Left=�6S   $��136,499,0,0q�6n   $	��Top=�6�   $��18(�6�   	� 5"      -	   5        $ rdbPoucoUrgente��5"   "   $��1-Pouco Urgente��6;   $
��Left=�6U   $��137,473,0,0q�6p   $	��Top=�6�   $��18(�6�   	� 5#      -
   5        $ rdbNaoUrgente��5#   "   $��3-Não Urgente��69   $
��Left=�6Q   $��136,526,0,0q�6l   $	��Top=�6�   $��18(�6�   �� 5$      -   5         ��Name$ btnBuscarChamados��5$      $
��Left=�68   $��354,142,0,0q�6S   $	��Top=�6h   $��59��6�   $��20(�6�   $��46��6�   ��6�   Z� ��5%      �� 5&       �� Color$ 	#FF707070��6.    �� Opacity$ 0Q�6@   .��5(      �� $��40��6    $2��,/SistemaEvolution;component/Icone Buscar.png��6,   $
��Fill=�6b   $��58��6q   5)      �� 5*      -   5        $ btnCadastrarAtendimento��5*      $
��Left=�6>   $��1103,489,0,0q�6Y   $	��Top=�6o   $��64��6�   $��60��6�   ��6�   Z� ��5+      �� 5,      $ 	#FF707070��6.   $ 0Q�6@   .��5.      �� $��59��6    $B��</SistemaEvolution;component/Online-Customer-Support-Icon.png��6,   $
��Fill=�6r   $��59��6�   5/      �� 50      $��Cadastrar Atend.��6   $
��Left=�67   $��1075,545,0,0q�6R   $	��Top=�6h   $��Arial Black)�6�   51      52      54      56      57      