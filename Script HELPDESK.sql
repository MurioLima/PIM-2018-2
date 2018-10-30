create database Evolution
go
use Evolution
go



CREATE TABLE Funcionario (
Cod_Funcionario varchar(5) PRIMARY KEY,
Nome_Completo varchar(30),
Nome_Tratamento varchar(30),
CPF varchar(11),
End_Completo varchar(50),
Email_Contato varchar(30),
Telefone varchar(11),
Stat_Funcionario char,
ID_usuario varchar(8)
)
go

CREATE TABLE Cliente (
Cod_Cliente varchar(5) PRIMARY KEY,
Nome varchar(50),
Razao_Social varchar(30),
CPF varchar(11),
CNPJ varchar(12),
Email_Contato varchar(30),
End_Completo varchar(30),
Telefone varchar(11),
Stat_Cliente char,
ID_usuario varchar(8)
)
go

CREATE TABLE TipoAtendimento (
Cod_Atendimento varchar(5) PRIMARY KEY,
Descricao varchar(300),
Data date,
Prioridade varchar(8)
)
go

CREATE TABLE Produto (
Cod_Produto varchar(5) PRIMARY KEY,
Desc_Produto varchar(100),
Cod_Cliente varchar(5),
FOREIGN KEY(Cod_Cliente) REFERENCES Cliente (Cod_Cliente)
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
FOREIGN KEY(Cod_Atendimento) REFERENCES TipoAtendimento (Cod_Atendimento)
)
go

ALTER TABLE Funcionario ADD FOREIGN KEY(ID_usuario) REFERENCES Usuario (ID_usuario)
ALTER TABLE Cliente ADD FOREIGN KEY(ID_usuario) REFERENCES Usuario (ID_usuario)
go