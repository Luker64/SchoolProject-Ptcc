use master
drop database bdprojescola
create database bdprojescola
use bdprojescola

create table tb_Turma(
	codturma int identity(1,1) primary key,
	nsala int,
	nalunos int,
	horario datetime,
)

create table tb_Aluno(
	nummat int identity(1,1) primary key,
	nome varchar(50),
	idade int,
	codturma int foreign key references tb_Turma(codturma),
	nomeresp varchar(50),
	telefone int,
	email varchar(50)
)

create table tb_Funcionario(
	CPF int primary key,
	nomefunc varchar(50),
	ctrab int,
	rg int,
	dnasc date,
	ende varchar (100),
	tel int ,
	emailfunc varchar(50),
	comiss decimal 
)

create table tb_Professor(
	CPF int primary key,
	Codprof int identity (1,1),
	nomefunc varchar(50),
	ctrab int,
	rg int,
	dnasc date,
	ende varchar (100),
	tel int ,
	emailfunc varchar(50),
	comiss decimal(5,2),
)

create table tb_Materia(
	codmat int identity(1,1) primary key,
	nomemat varchar(50),
)

create table tb_MatProf(
	codmat int foreign key references tb_Materia(codmat),
	CPF int foreign key references tb_Professor(CPF)
)

create table tb_Boletim(
	nummat int foreign key references tb_Aluno(nummat),
	codmat  int foreign key references tb_Materia(codmat),
	nota decimal,
	frequencia int
)

select * from tb_Turma
insert into tb_Turma
values(15, 20, '15-05-2008'
)

select * from tb_Aluno
insert into tb_Aluno
values('Roger', 15, 1, 'Rogerina', 11122233, 'roger_@gmail.com'
)

select * from tb_Funcionario
insert into tb_Funcionario
values( 34425151, 'Junas' , 3212321, 321321, '25/03/1995','AAA n 2548', 3232132, 'junas@gmail.com', 15.30
)

select * from tb_Professor
insert into tb_Professor
values( 34425151, 'Junas' , 3212321, 321321, '25/03/1995','AAA n 2548', 3232132, 'junas@gmail.com', 15.30
)

select * from tb_Materia
insert into tb_Materia
values('Matemática'
)

select * from tb_MatProf
insert into tb_MatProf
values(1,34425151
)

select * from tb_Boletim
insert into tb_Boletim
values(1, 1 , 10, 50
)

select * from tb_Aluno;
select * from tb_Boletim;
select * from tb_Funcionario;
select * from tb_Materia;
select * from tb_MatProf;
select * from tb_Professor;
select * from tb_Turma;

