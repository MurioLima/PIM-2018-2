   M S B A M L   `   `   `  ����K  GSistemaEvolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SistemaEvolution.ApresentacaoSistemaEvolution.Apresentacao  5   	   2    ,SistemaEvolution.Apresentacao.frmFuncionario   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SistemaEvolution.Apresentacao     5   	     � Title$  Cadastro de Funcionário��5   	   $��627.973��6)   $��1264.603��6:    � WindowStartupLocation$ CenterScreen=�6K    � WindowStyle$ 
ToolWindow=�6p    � 
ResizeMode$ NoResize=�6�   .��5	      � .+�5
   
   �� $
��Left=�6   $	��597��60   $	��Top=�6=   $
��1265��6U   .@�5      �� -   5         ��Name$ tbcCadastrarFuncionario��5      $��Cadastrar Funcionário��67   .��5      � ���	#FFE5E5E5 � ColumnDefinitions 5      �� 5      $	��76* �6+   �� 5      $	��92* �6+   �� 5      $��1091* �6+   .+�5      �� $
��Left=�6   $	��504��67   $��60.06,32,0,0q�6D   $	��Top=�6Z   $
��1000��6r   $��Imagens/logoSistema.png��6    J� Opacity$
 0.04Q�6�   $��2��6�   $��1��6�    J� OpacityMask 5      �� 5       �� ImageSource$ Imagens/logoSistema.png��6)   5      �� 5      -   5        	 ��Name$	 lblCodFuncionario��5      $��Código Funcionário:��67   $
��Left=�6U   $��
26,120,0,0q�6p   $	��185��6�   $��40��6�   $��20(�6�   $	��Top=�6�   $��3��6�   �� 5      -   5        $	 lblNomeCompleto��5      $��Nome Completo:��65   $
��Left=�6N   $��
26,194,0,0q�6i   $	��185��6}   $��40��6�   $��20(�6�   $	��Top=�6�   $��3��6�   �� 5      -   5        $	 lblNomeTratamento��5      $��Nome Tratamento:��67   $
��Left=�6R   $��
26,265,0,0q�6m   $	��185��6�   $��40��6�   $��20(�6�   $	��Top=�6�   $��3��6�   �� 5      -   5        $	 lblCpf��5      $
��CPF:��6,   $
��Left=�6;   $��
26,336,0,0q�6V   $��53��6j   $��40��6u   $��20(�6�   $	��Top=�6�   $��2��6�   �� 5      -   5        
 ��Name$
 txbCodFuncionario��5      $
��Left=�69   $��40��6T   $��
48,120,0,0q�6`    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��154��6�   $��20(�6�    �� MaxLines$ 1��6�    �� 	MaxLength$ 5��6�   $��2��6�   �� 5      -   5        $
 txbNomeCompleto��5      $
��Left=�67   $��40��6R   $��
37,194,0,0q�6^   $
 Wrap=�6r   $	��Top=�6�   $	��626��6�   $��20(�6�   $ 1��6�   $ 50��6�   $��2��6�   �� 5      -   5        $
 txbNomeTratamento��5      $
��Left=�69   $��40��6T   $��
36,265,0,0q�6`   $
 Wrap=�6t   $	��Top=�6�   $	��624��6�   $��20(�6�   $ 30��6�   $ 1��6�   $��2��6�   �� 5      -	   5        $
 txbCpf��5      $
��Left=�6.   $��40��6I   $��3.06,336,0,0q�6U   $
 Wrap=�6k   $	��Top=�6   $	��253��6�   $��20(�6�   $ 11��6�   $ 1��6�   $ �� HorizontalScrollBarVisibility$
 Auto=�6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   $��2��6  $��1��6)  �� 5      -
   5        $	 lblEndereco��5      $��Endereço Completo:��61   $
��Left=�6N   $��
26,407,0,0q�6i   $	��188��6}   $��40��6�   $��20(�6�   $	��Top=�6�   $��3��6�   �� 5       -   5        $	 lblTelefone��5       $��	Telefone:��61   $
��Left=�6E   $��616,120,0,0q�6`   $	��103��6u   $��40��6�   $��20(�6�   $	��Top=�6�   $��2��6�   �� 5!      -   5        $
 txbTelefone��5!      $
��Left=�63   $��40��6N   $��717,120,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $	��334��6�   $��20(�6�   $ 11��6�   $ 1��6�   $��2��6�   �� 5"      -   5        $
 txbEndereço��5"      $
��Left=�63   $��40��6N   $��
52,407,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $	��999��6�   $��20(�6�   $ 50��6�   $ 1��6�   $
 Auto=�6�   $
 Auto=�6�   $��2��6  �� 5#      $��Cadastrar Funcionário��6   $
��Left=�6<   $��46��6W   $��	20,16,0,0q�6c   $	��Top=�6v   $	��312��6�   $��30(�6�   $��3��6�   �� 5$      -   5         ��Name$ btnCadastrarFuncionario��5$      $
��Left=�6>   $��421,481,0,0q�6Y   $	��Top=�6n   $��63��6�   $��64��6�   $��2��6�   ��6�   Z� ��5%      �� 5&       �� Color$ 	#FF707070��6.    �� Opacity$ 0Q�6@   .��5(      �� $��60��6    $f��`/SistemaEvolution;component/business_application_addmale_useradd_insert_add_user_client_2312.png��6,   $
��Fill=�6�   $��60��6�   5)      	� 5*      -   5         	�Name$ rdbStatusFuncionarioAtivo��5*   "   $��Ativo��6E   $
��Left=�6U   $��856,474,0,0q�6p   $	��Top=�6�   $��20(�6�   $��2��6�   	� 5+      -   5        $! rdbStatusFuncionarioInativo��5+   "   $��Inativo��6G   $
��Left=�6Y   $��942,474,0,0q�6t   $	��Top=�6�   $��20(�6�   $��2��6�   �� 5,      $��Status Funcionário:��6   $
��Left=�6:   $��673,468,0,0q�6U   $	��Top=�6j   $��20(�6�   $��2��6�   �� 5-      -   5        $
 txbEmailContato��5-      $
��Left=�67   $��40��6R   $��469,336,0,0q�6^   $
 Wrap=�6s   $	��Top=�6�   $	��582��6�   $��20(�6�   $��2��6�   �� 5.      -   5        $	 lblEmailContato��5.      $��Email:��65   $
��Left=�6F   $��400,336,0,0q�6a   $	��Top=�6v   $��20(�6�   $��2��6�   �� 5/      $��	Cadastrar��6   $
��Left=�60   $��417,537,0,0q�6K   $	��Top=�6`   $��Arial Black)�6x   $��2��6�   �� 50      -   5        $
 txbIdUsuario��50      $��2��64   $
��Left=�6D   $��40��6_   $��400,120,0,0q�6k   $
 Wrap=�6�   $	��Top=�6�   $	��154��6�   $ 8��6�   $ 1��6�   $��20(�6�   �� 51      -   5        $	 lblCodFuncionario_Copy��51      $��Código Usuário :��6<   $
��Left=�6W   $��238,120,0,0q�6r   $	��186��6�   $��40��6�   $��20(�6�   $	��Top=�6�   $��2��6�   53      54      �� 55      -   5        $ tbcEditarFuncionario��55      $��Editar Funcionário��64   .��56      � ���	#FFE5E5E5.+�57      �� $
��Left=�6   $	��504��67   $��
136,32,0,0q�6D   $	��Top=�6X   $
��1000��6p   $��Imagens/logoSistema.png��6}   $
 0.04Q�6�    58      �� 59      $ Imagens/logoSistema.png��6)   5;      �� 5<      -   5        $	 lblCodFuncionarioo��5<      $��Código Funcionário:��68   $
��Left=�6V   $��
26,120,0,0q�6q   $	��185��6�   $��40��6�   $��20(�6�   $	��Top=�6�   �� 5=      -   5        $	 lblNomeCompletoo��5=      $��Nome Completo:��66   $
��Left=�6O   $��
26,194,0,0q�6j   $	��185��6~   $��40��6�   $��20(�6�   $	��Top=�6�   �� 5>      -   5        $	 lblNomeTratamentoo��5>      $��Nome Tratamento:��68   $
��Left=�6S   $��
26,265,0,0q�6n   $	��185��6�   $��40��6�   $��20(�6�   $	��Top=�6�   �� 5?      -   5        $	 lblCpfo��5?      $
��CPF:��6-   $
��Left=�6<   $��
26,336,0,0q�6W   $	��185��6k   $��40��6w   $��20(�6�   $	��Top=�6�   �� 5@      -   5        $
 txbEDCodFuncionario��5@      $
��Left=�6;   $��40��6V   $��216,120,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $	��154��6�   $��20(�6�   $ 1��6�   $ 5��6�   �� 5A      -   5        $
 txbEDNomeCompleto��5A      $
��Left=�69   $��40��6T   $��205,194,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��626��6�   $��20(�6�   $ 1��6�   $ 50��6�   �� 5B      -   5        $
 txbEDNomeTratamento��5B      $
��Left=�6;   $��40��6V   $��206,265,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $	��614��6�   $��20(�6�   $ 30��6�   $ 1��6�   �� 5C      -   5        $
 txbEDCpf��5C      $
��Left=�60   $��40��6K   $��
79,336,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $	��253��6�   $��20(�6�   $ 11��6�   $ 1��6�   $
 Auto=�6�   $
 Auto=�6�   �� 5D      -   5        $	 lblEnderecoo��5D      $��Endereço Completo:��62   $
��Left=�6O   $��
26,407,0,0q�6j   $	��188��6~   $��40��6�   $��20(�6�   $	��Top=�6�   �� 5E      -   5        $	 lblTelefoneo��5E      $��	Telefone:��62   $
��Left=�6F   $��788,120,0,0q�6a   $	��186��6v   $��40��6�   $��20(�6�   $	��Top=�6�   �� 5F      -    5        $
 txbEDTelefone��5F      $
��Left=�65   $��40��6P   $��885,120,0,0q�6\   $
 Wrap=�6q   $	��Top=�6�   $	��334��6�   $��20(�6�   $ 11��6�   $ 1��6�   �� 5G      -!   5        $
 txbEDEndereco��5G      $
��Left=�65   $��40��6P   $��220,407,0,0q�6\   $
 Wrap=�6q   $	��Top=�6�   $	��999��6�   $��20(�6�   $ 50��6�   $ 1��6�   $
 Auto=�6�   $
 Auto=�6�   �� 5H      $��Editar Funcionário��6   $
��Left=�69   $��46��6T   $��	20,16,0,0q�6`   $	��Top=�6s   $	��312��6�   $��30(�6�   �� 5I      -"   5        $ btnEditarFuncionario��5I      $
��Left=�6;   $��985,477,0,0q�6V   $	��Top=�6k   $��62��6�   $��64��6�   ��6�   Z� ��5J      �� 5K      $ 	#FF707070��6.   $ 0Q�6@   .��5M      �� $��60��6    $4��./SistemaEvolution;component/Edit-Male-User.png��6,   $
��Fill=�6d   $��60��6s   5N      �� 5O      -#   5        $ btnExcluirFuncionario��5O      $
��Left=�6<   $��1091,477,0,0q�6W   $	��Top=�6m   $��63��6�   $��64��6�   ��6�   Z� ��5P      �� 5Q      $ 	#FF707070��6.   $ 0Q�6@   .��5S      �� $��60��6    $`��Z/SistemaEvolution;component/delete_delete_deleteusers_delete_male_user_maleclient_2348.png��6,   $
��Fill=�6�   $��60��6�   5T      �� 5V      -$   5        $ btnBuscarNome��5V      $
��Left=�64   $��866,194,0,0q�6O   $	��Top=�6d   $��61��6|   $��40��6�   ��5W      �� 5X      $ 	#FF707070��6.   $ 0Q�6@   .��5Z      �� $��40��6    $0��*/SistemaEvolution;component/search-img.png��6,   $
��Fill=�6`   $��58��6o   5[      �� 5\      -%   5        $
 txbEDEmailContato��5\      $
��Left=�69   $��40��6T   $��637,336,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��582��6�   $��20(�6�   �� 5]      -&   5        $	 lblEmailContato_Copy��5]      $��Email:��6:   $
��Left=�6K   $��570,339,0,0q�6f   $	��Top=�6{   $��20(�6�   �� 5^      $��Editar��6   $
��Left=�6-   $��992,535,0,0q�6H   $	��Top=�6]   $��Arial Black)�6u   �� 5_      $��Excluir��6   $
��Left=�6.   $��1096,535,0,0q�6I   $	��Top=�6_   $��Arial Black)�6w   	� 5`      -'   5        $! rdbEDStatusFuncionarioAtivo��5`   "   $��Ativo��6G   $
��Left=�6W   $��1047,272,0,0q�6r   $	��Top=�6�   $��20(�6�   	� 5a      -(   5        $# rdbEDStatusFuncionarioInativo��5a   "   $��Inativo��6I   $
��Left=�6[   $��1133,272,0,0q�6v   $	��Top=�6�   $��20(�6�   �� 5b      $��Status Funcionário:��6   $
��Left=�6:   $��864,266,0,0q�6U   $	��Top=�6j   $��20(�6�   �� 5c      -)   5        $
 txbEdIdUsuario��5c      $
��Left=�66   $��40��6Q   $��570,120,0,0q�6]   $
 Wrap=�6r   $	��Top=�6�   $	��154��6�   $ 8��6�   $ 1��6�   $��20(�6�   �� 5d      -*   5        $	 lblCodFuncionario_Copy1��5d      $��Código Usuário :��6=   $
��Left=�6X   $��408,120,0,0q�6s   $	��186��6�   $��40��6�   $��20(�6�   $	��Top=�6�   5f      5g      5h      5l      5m      