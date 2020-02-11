CREATE DATABASE SpMedicalGroup_Tarde

GO
USE SpMedicalGroup_Tarde;
GO

CREATE TABLE Clinica (
	IdClinica INT PRIMARY KEY IDENTITY,
	Endereco VARCHAR (255) NOT NULL,
	HorarioFuncionamento VARCHAR (255) NOT NULL,
	CNPJ CHAR(14) NOT NULL,
	RazaoSocial VARCHAR (255) NOT NULL
); 

CREATE TABLE Especialidade (
	IdEspecialidade INT PRIMARY KEY IDENTITY,
	Nome VARCHAR (255) NOT NULL
);

CREATE TABLE TipoUsuario (
	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	Nome VARCHAR (255) NOT NULL
);

CREATE TABLE Usuario (
	IdUsuario INT PRIMARY KEY IDENTITY,
	NomeUsuario VARCHAR (255) NOT NULL,
	EmailUsuario VARCHAR (255) NOT NULL,
	Senha VARCHAR (255) NOT NULL,
	IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario)
);

CREATE TABLE Medico (
	IdMedico INT PRIMARY KEY IDENTITY,
	CRM VARCHAR (255) NOT NULL,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario (IdUsuario),
	IdEspecialidade INT FOREIGN KEY REFERENCES Especialidade (IdEspecialidade)
);

CREATE TABLE Prontuario (
	IdProntuario INT PRIMARY KEY IDENTITY,
	Data_Nascimento VARCHAR (255) NOT NULL,
	Telefone VARCHAR (255) NOT NULL,
	RG VARCHAR (255) NOT NULL,
	CPF VARCHAR (255) NOT NULL,
	Endereco VARCHAR (255) NOT NULL,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario (IdUsuario)
);

CREATE TABLE Consulta (
	IdConsulta INT PRIMARY KEY IDENTITY,
	Data_Consulta VARCHAR (255) NOT NULL,
	Situacao VARCHAR (255) NOT NULL,
	IdClinica INT FOREIGN KEY REFERENCES Clinica (IdClinica),
	IdMedico INT FOREIGN KEY REFERENCES Medico (IdMedico),
	IdProntuario INT FOREIGN KEY REFERENCES Prontuario (IdProntuario)
);