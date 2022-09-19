CREATE DATABASE db_livraria

use db_livraria

--Criando a Tabela Livraria
create table tbl_atendente
(
   cd_Atendente int primary key identity,
   ds_Login varchar(20) not null,
   ds_Senha char(8) not null,
   nm_Atendente varchar(60) not null
)

--inserindo na tabela atendente pelo login
insert into tbl_atendente
(ds_Login,ds_Senha,nm_Atendente)
values('joao','jm123456', 'João Marcos')

--Criando a tabela Livros
create table tbl_Livros
(
	cd_Livro int primary key identity,
	nm_Titulo varchar(60) not null,
	nm_Autor varchar(60) not null,
	nm_Assunto varchar(60) not null,
	nm_Editora varchar(60) not null,
)

--Criando a Tabela Aluno
create table tbl_Aluno
(
	cd_Aluno int primary key identity,
	nm_Nome varchar(60) not null,
	nm_Email varchar(60) not null,
	nm_Curso varchar(60) not null,
)

--Consutando as tabelas criadas
select * from tbl_ALuno
select * from tbl_Livros
select * from tbl_atendente

--Adicionando na tabela Aluno
alter table tbl_Aluno
add ds_status bit not null default (1)

--Adicionando na tabela Atendente
alter table tbl_atendente
add ds_status bit not null default (1)

--Adicionando na tabela Livros
alter table tbl_Livros
add ds_status bit not null default (1)

--exibe apenas funcionarios ativos da livraria 0 ou 1
select * from tbl_atendente
where ds_status = 1














