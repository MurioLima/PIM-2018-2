   M S B A M L   `   `   `  ����K  GSistemaEvolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SistemaEvolution.ApresentacaoSistemaEvolution.Apresentacao  5   	   .    (SistemaEvolution.Apresentacao.frmProduto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SistemaEvolution.Apresentacao     5   	     � Title$  
frmProduto��5   	   $��627.973��6   $��1264.603��6-    � WindowStartupLocation$ CenterScreen=�6>    � WindowStyle$ 
ToolWindow=�6c    � 
ResizeMode$ NoResize=�6|   .��5	      � .+�5
   
   �� $
��Left=�6   $	��597��60   $	��Top=�6=   $
��1265��6U   .@�5      �� -   5         ��Name$ tbcCadastrarProduto��5      $��Cadastrar Produto��63   .��5      � ���	#FFE5E5E5.+�5      �� $
��Left=�6   $	��504��67   $��
136,32,0,0q�6D   $	��Top=�6X   $
��1000��6p   $��Imagens/logoSistema.png��6}    J� Opacity$
 0.04Q�6�    J� OpacityMask 5      �� 5       �� ImageSource$ Imagens/logoSistema.png��6)   5      �� 5      $��Código Produto:��6   $
��Left=�66   $��
26,144,0,0q�6Q   $	��Top=�6e   $	��185��6}   $��40��6�   $��20(�6�   �� 5      -   5         ��Name$ txbCodProduto��5      $
��Left=�65   $��40��6P   $��184,144,0,0q�6\   	 �� TextWrapping$
	 Wrap=�6q   $	��Top=�6�   $	��154��6�   $��20(�6�   
 �� MaxLines$
 1��6�    �� 	MaxLength$ 5��6�   �� 5      $��Descrição do Produto:��6   $
��Left=�6<   $��
26,240,0,0q�6W   $	��Top=�6k   $	��216��6�   $��40��6�   $��20(�6�   �� 5      -   5        $ txbDescProduto��5      $
��Left=�66   $	��188��6Q   $��247,240,0,0q�6^   $
	 Wrap=�6s   $	��Top=�6�   $	��941��6�   $��20(�6�   $
 5��6�   $	 100��6�    J� RenderTransformOrigin$	 1,1&�6�   �� 5      $��Cadastrar Produto��6   $
��Left=�68   $��46��6S   $��	20,16,0,0q�6_   $	��Top=�6r   $	��273��6�   $��30(�6�   �� 5      -   5         ��Name$ btnCadastrarProduto��5      $
��Left=�6:   $��1088,476,0,0q�6U   $	��Top=�6k   $��62��6�   $��65��6�   ��6�   Z� ��5      �� 5       �� Color$ 	#FF707070��6.    �� Opacity$ 0Q�6@   .��5      �� $��60��6    $@��:/SistemaEvolution;component/Icone botao salvar produto.png��6,   $
��Fill=�6p   $��60��6   5      �� 5      $
��Left=�6   $	��160��67   $��1000,42,0,0q�6D   $	��Top=�6Y   $	��158��6q   $��Imagens/produto.png��6}    5      �� 5      $ Imagens/produto.png��6)   5!      �� 5"      -   5        $ txbCodCliente��5"      $
��Left=�65   $��40��6P   $��444,144,0,0q�6\   $
	 Wrap=�6q   $	��Top=�6�   $	��244��6�   $��20(�6�   �� 5#      $��Cliente:��6   $
��Left=�6/   $��364,147,0,0q�6J   $	��Top=�6_   $��20(�6w   �� 5$      $��	Cadastrar��6   $
��Left=�60   $��1083,537,0,0q�6K   $	��Top=�6a   $��Arial Black)�6y   5'      5(      �� 5)      -   5        $ tbcEditarProduto��5)      $��Editar Produto��60   .��5*      � ���	#FFE5E5E5.+�5+      �� $
��Left=�6   $	��504��67   $��
136,32,0,0q�6D   $	��Top=�6X   $
��1000��6p   $��Imagens/logoSistema.png��6}   $
 0.04Q�6�    5,      �� 5-      $ Imagens/logoSistema.png��6)   5/      �� 50      $��Editar Produto��6   $
��Left=�65   $��46��6P   $��	20,16,0,0q�6\   $	��Top=�6o   $	��273��6�   $��30(�6�   �� 51      $��Código Produto:��6   $
��Left=�66   $��
26,144,0,0q�6Q   $	��Top=�6e   $	��185��6}   $��40��6�   $��20(�6�   �� 52      -   5        $ txbEdCodProduto��52      $
��Left=�67   $��40��6R   $��184,144,0,0q�6^   $
	 Wrap=�6s   $	��Top=�6�   $	��154��6�   $��20(�6�   $
 1��6�   $ 5��6�   �� 53      $��Descrição do Produto:��6   $
��Left=�6<   $��
26,240,0,0q�6W   $	��Top=�6k   $	��216��6�   $��40��6�   $��20(�6�   �� 54      -   5        $ txbEdDescricaoProduto��54      $
��Left=�6=   $	��188��6X   $��247,240,0,0q�6e   $
	 Wrap=�6z   $	��Top=�6�   $	��941��6�   $��20(�6�   $
 5��6�   $	 100��6�   �� 55      -	   5        $ btnEditarProduto��55      $
��Left=�67   $��1024,476,0,0q�6R   $	��Top=�6h   $��62��6�   $��65��6�   ��6�   Z� ��56      �� 57      $ 	#FF707070��6.   $ 0Q�6@   .��59      �� $��60��6    $@��:/SistemaEvolution;component/Icone botao Editar produto.png��6,   $
��Fill=�6p   $��60��6   5:      �� 5;      -
   5        $ btnExcluirProduto��5;      $
��Left=�68   $��1122,476,0,0q�6S   $	��Top=�6i   $��65��6�   $��63��6�   ��6�   Z� ��5<      �� 5=      $ 	#FF707070��6.   $ 0Q�6@   .��5?      �� $��60��6    $5��//SistemaEvolution;component/excluir produto.png��6,   $
��Fill=�6e   $��60��6t   5@      �� 5B      $
��Left=�6   $	��160��67   $��1013,45,0,0q�6D   $	��Top=�6Y   $	��158��6q   $��Imagens/produto.png��6}    5C      �� 5D      $ Imagens/produto.png��6)   5F      �� 5G      -   5        $ btnBuscarProduto��5G      $
��Left=�67   $��383,144,0,0q�6R   $	��Top=�6g   $��60��6   $��40��6�   ��5H      �� 5I      $ 	#FF707070��6.   $ 0Q�6@   .��5K      �� $��40��6    $2��,/SistemaEvolution;component/Icone Buscar.png��6,   $
��Fill=�6b   $��58��6q   5L      �� 5M      $��Código do Cliente:��6   $
��Left=�69   $��472,144,0,0q�6T   $	��Top=�6i   $��20(�6�   �� 5N      -   5        $ txbEDCodCliente��5N      $
��Left=�67   $��40��6R   $��651,144,0,0q�6^   $
	 Wrap=�6s   $	��Top=�6�   $	��154��6�   $��20(�6�   �� 5O      $��Excluir��6   $
��Left=�6.   $��1127,534,0,0q�6I   $	��Top=�6_   $��Arial Black)�6w   �� 5P      $��Editar��6   $
��Left=�6-   $��1031,534,0,0q�6H   $	��Top=�6^   $��Arial Black)�6v   5R      5S      5T      5V      5W      