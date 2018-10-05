create database HELPDESK
go
use HELPDESK
go



CREATE TABLE CadastroFunc (
Cod_Funcionario varchar(5) PRIMARY KEY,
Nome_Tratamento varchar(30),
Nome_Completo varchar(30),
CPF varchar(11),
End_Completo varchar(50),
Stat_Funcionario boleano,
Telefone varchar(11),
ID_usuario varchar(8)
)
go

CREATE TABLE CadastroCLiente (
CNPJ varchar(12),
Cod_Cliente varchar(5) PRIMARY KEY,
Nome_Fantasia varchar(50),
CPF varchar(11),
Email_Contato varchar(30),
Telefone varchar(11),
Raz_Social varchar(30),
Stat_Cliente bit,
ID_usuario varchar(8)
)
go

CREATE TABLE CadTipAtend (
Cod_Atendimento varchar(5) PRIMARY KEY,
Descricao varchar(300),
Prioridade varchar(8)
)
go

CREATE TABLE Produto (
Cod_Produto varchar(5) PRIMARY KEY,
Desc_Produto varchar(100),
Cod_Cliente varchar(5),
FOREIGN KEY(Cod_Cliente) REFERENCES CadastroCLiente (Cod_Cliente)
)
go

CREATE TABLE Usuario (
Acesso bit,
ID_usuario varchar(8) PRIMARY KEY,
Senha varchar(8)
)
go

CREATE TABLE Chamados (
Cod_Chamado varchar(8) PRIMARY KEY,
Desc_Chamado varchar(500),
Data date,
Cod_Produto varchar(5),
Cod_Atendimento varchar(5),
FOREIGN KEY(Cod_Produto) REFERENCES Produto (Cod_Produto),
FOREIGN KEY(Cod_Atendimento) REFERENCES CadTipAtend (Cod_Atendimento)
)
go

ALTER TABLE CadastroFunc ADD FOREIGN KEY(ID_usuario) REFERENCES Usuario (ID_usuario)
ALTER TABLE CadastroCLiente ADD FOREIGN KEY(ID_usuario) REFERENCES Usuario (ID_usuario)
go