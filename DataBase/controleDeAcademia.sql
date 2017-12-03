create database academia

create table professor(
	ID_Professor int primary key identity not null,
	NOME_PROFESSOR varchar(50) not null,
	ENDERECO_PROFESSOR varchar(100) not null,
	BAIRRO_PROFESSOR varchar(100) not null,
	CIDADE_PROFESSOR varchar(100) not null,
	CEP_PROFESSOR varchar(25) not null,
	CPF_PROFESSOR varchar(20) not null,
	SALARIO decimal(7,2) not null,
	TELEFONE_PROFESSOR varchar(30) not null,
	OBSERVACAO varchar(100) not null,
)

create table Modalidade(
	ID_MODALIDADE int primary key identity not null,
	NOME_MODALIDADE varchar(50) not null,
	MENSALIDADE decimal(9,2) not null,
	ID_PROFESSOR int foreign key references professor,
)

create table Turma(
	ID_TURMA int primary key identity not null,
	ID_MODALIDADE int foreign key references Modalidade,
	MAXIMO_ALUNOS int not null,
	NUMERO_TURMA int not null,
	ALUNO_MATRICULADO int not null,
)
create table Horario(
	ID_HORARIO int primary key identity not null,
	ID_TURMA int foreign key references Turma,
	DIA_SEMANA varchar(50) not null,
	INICIO varchar(50) not null,
	FIM varchar(50) not null,
) 
create table Aluno(
	ID_Aluno int primary key identity not null,
	NOME_Aluno varchar(50) not null,
	ENDERECO_Aluno varchar(100) not null,
	BAIRRO_Aluno varchar(100) not null,
	CIDADE_Aluno varchar(100) not null,
	CEP_Aluno varchar(25) not null,
	CPF_Aluno varchar(20) not null,
	TELEFONE_Aluno varchar(30) not null,
	CELULAR_Aluno varchar(30) not null,
	OBSERVACAO varchar(100) not null,
	Sexo varchar(10) not null,
)

create table Matricula(
	ID_MATRICULA int primary key identity not null,
	ID_ALUNO int foreign key references Aluno,
	ID_TURMA int foreign key references Turma,
	VENCIMENTO int not null,
	SITUACAO varchar(12) not null,
)

create table MENSALIDADE(
	ID_MENSALIDADE int primary key identity not null,
	ID_MATRICULA int foreign key references Matricula,
	DATA_VENCIMENTO datetime not null,
	SITUACAO varchar(12) not null,
)
