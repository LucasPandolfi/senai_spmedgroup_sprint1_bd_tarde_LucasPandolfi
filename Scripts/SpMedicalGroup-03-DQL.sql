--CRIANDO DQL
USE SpMedicalGroup_Tarde;

--VINCULANDO A TABELA DE PRONTURIO COM A DE CONSULTA
SELECT Consulta.IdConsulta, Consulta.Situacao, Consulta.Data_Consulta, Prontuario.NomePaciente
FROM Consulta
INNER JOIN Prontuario ON Prontuario.IdProntuario = Consulta.IdProntuario

--VINCULANDO A TEBELA DE PRONTUARIO, CONSULTA E MEDICO 
SELECT Consulta.IdConsulta, Consulta.Situacao, Consulta.Data_Consulta, Medico.NomeMedico, Prontuario.NomePaciente, Prontuario.CPF
FROM Consulta
INNER JOIN Medico ON Medico.IdMedico = Consulta.IdMedico
INNER JOIN Prontuario ON Prontuario.IdProntuario = Consulta.IdProntuario

--VINCULANDO  TABELA DE MÉDICO COM ESPECILIADADE
SELECT Medico.NomeMedico, Medico.CRM, Especialidade.Nome
FROM Medico
INNER JOIN Especialidade ON Especialidade.IdEspecialidade = Medico.IdEspecialidade

--VINCULANDO A TABELA DE MEDICOS COM A TABELA CLINICA
SELECT Medico.NomeMedico, Clinica.RazaoSocial, Clinica.Endereco
FROM Medico
INNER JOIN Clinica ON Clinica.IdClinica = Medico.IdClinica

--CALCULANDO A IDADE DO PACIENTE
SELECT Prontuario.NomePaciente, Prontuario.CPF, DATEDIFF(YEAR,Prontuario.Data_Nascimento, GETDATE()) AS Idade FROM Prontuario

SELECT Prontuario.NomePaciente, CONVERT(VARCHAR, Prontuario.Data_Nascimento, 101) AS DataDeNascimento FROM Prontuario

--CRIANDO A FUNCAO PARA IDENTIFICAR OS MEDICOS COM AS ESPECIALIDADES IGUAIS
GO
CREATE FUNCTION MedicoEspecialidade (@EspecialidadeIguais INT)
RETURNS TABLE 
AS
RETURN SELECT Medico.NomeMedico, Especialidade.Nome 
FROM Medico
INNER JOIN Especialidade ON Especialidade.IdEspecialidade = Medico.IdEspecialidade
WHERE Medico.IdEspecialidade = @EspecialidadeIguais
GO
SELECT * FROM MedicoEspecialidade(17)

--BUSCANDO A IDADE DO USUARIO POR UMA PROCEDURE
GO
CREATE PROCEDURE BuscarIdade
AS
SELECT Prontuario.NomePaciente, DATEDIFF(YEAR, Prontuario.Data_Nascimento, GetDate()) 
as Idade, Prontuario.Cpf, Prontuario.RG, Prontuario.Telefone FROM Prontuario
INNER JOIN Usuario ON Usuario.IdUsuario = Prontuario.IdUsuario
GO
BuscarIdade 
