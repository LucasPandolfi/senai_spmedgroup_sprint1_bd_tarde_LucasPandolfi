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

--CRIANDO UMA FUNÇÃO PARA RETORNAR OS FUNCIONARIOS DE UMA MESMA ESPECIALIDADE
CREATE FUNCTION EspecialidadesIguais (@Especialidade INT)
RETURNS VARCHAR
AS
BEGIN
DECLARE @Especiladade INT
SELECT @Especialidade = Especialidade.IdEspecialidade
FROM Medico
WHERE Medico.IdEspecialidade = 17
RETURN @Especialidade
END
