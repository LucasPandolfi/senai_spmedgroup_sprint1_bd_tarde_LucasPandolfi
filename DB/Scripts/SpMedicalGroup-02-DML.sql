--CRIANDO DML

USE SpMedicalGroup_Tarde;

INSERT INTO Clinica (Endereco, HorarioFuncionamento, CNPJ, RazaoSocial)
VALUES ('Av. Barão Limeira, 532, São Paulo, SP', '8:00 às 18:00', '11111111111111', 'SP Medical Group');

SELECT * FROM Clinica;

INSERT INTO Especialidade (Nome)
VALUES ('Acupuntura'), ('Anestesiologia'), ('Angiologia'), ('Cardiologia'), ('Cirurgia Cardiovascular'), ('Cirurgia da Mão'), ('Cirurgia do Aparelho Digestivo'),
('Cirurgia Geral'), ('Cirurgia Pediátrica'), ('Cirurgia Plástica'), ('Cirurgia Torácica'), ('Cirurgia Vascular'), ('Dermatologia'), ('Radioterapia'), ('Urologia'),
('Pediatria'), ('Psiquiatria');

SELECT * FROM Especialidade;

INSERT INTO TipoUsuario (Nome)
VALUES ('Administrador'), ('Médico'), ('Paciente');

SELECT * FROM TipoUsuario;

INSERT INTO Usuario (Email, Senha, IdTipoUsuario)
VALUES  ('ricardo.lemos@spmedicalgroup.com.br', 'Ric123', 2), ('roberto.possarle@spmedicalgroup.com.br', 'Poss123', 2), 
('helena.souza@spmedicalgroup.com.br', 'Hel123', 2), ('Ligia@gmail.com', 'ligia123', 3), ('Alexandre@gmail.com', 'Alex123', 3),
('Fernando@gmail.com', 'Fer123', 3), ('Henrique@gmail.com', 'Henr123', 3), ('Joao@gmail.com', 'Joao123', 3), ('Bruno@gmail.com', 'Bru123', 3),
('Mariana@gmail.com', 'Mari123', 3);

SELECT * FROM Usuario


INSERT INTO Medico (NomeMedico, CRM, IdUsuario, IdEspecialidade, IdClinica)
VALUES ('Ricardo Lemos', '54356-SP', 1, 2, 1), ('Roberto Possarle', '53452-SP', 2, 17, 1), ('Helena Strada', '65463-SP', 3, 16, 1);

SELECT * FROM Medico

INSERT INTO Prontuario (NomePaciente ,Data_Nascimento, Telefone, RG, CPF, Endereco, IdUsuario)
VALUES ('Ligia','13/10/83', '11 3456-7654', '43522543-5', '94839859000', 'Rua Estado do Israel 240, São Paulo, Estado de São Paulo, 04022-000', 4),
('Alexandre', '23/07/01', '11 98765-6543', '32654345-7', '73556944057', 'Av.Paulista, 1578, Bela Vista, São Paulo - SP, 01310-200', 5),
('Fernando', '10/10/78', '11 97208-4453', '54636525-3', '16839338002', 'Av, Ibirapuera - Indianópolis, 2927, São Paulo - SP, 04029-200', 6),
('Henrique', '13/10/85', '11 3456-6543', '54366362-5', '14332654765', 'Rua Vitória, 120 - Vila São Jorge, Barueri - SP, 06402-030', 7),
('João', '27/08/75', '11 7656-6377', 'T32544444-1', '91305348010', 'Rua. Ver. Geraldo de Camargo, 66 - Santa Luzia, Riberão Pires - SP, 09405-380', 8),
('Bruno', '21/03/72', '11 95436-8769', '54566266-7', '79799299004', 'Alameda dos Arapanés, 945 - Indianópolis, São Paulo - SP, 04524-001', 9),
('Mariana', '05/03/18', '11 98654-8975', '5566266-8', '13771913039', 'Rua São Antonio, 232 - Vila Universal, Barueri - SP, 06407-140', 10)

SELECT * FROM Prontuario

INSERT INTO Situacao (Estatus)
VALUES ('Realizada'), ('Agendada'), ('Cancelada');

INSERT INTO Consulta (Data_Consulta, Descricao_Consulta ,IdSituacao ,IdClinica, IdMedico, IdProntuario)
VALUES ('20/01/20 15:00', 'teste1', 1, 1, 3, 7), ('06/01/20 10:00', 'teste2', 3, 1, 2, 2), ('07/02/2020 11:00', 'teste3', 1, 1, 2, 3), ('06/02/2018 10:00', 'teste4', 1, 1, 2, 2),
('07/02/2019 11:00', 'teste5', 3, 1, 1, 4), ('08/03/2020 15:00', 'teste6', 2, 1, 3, 7), ('09/03/2020 11:00', 'teste7', 2, 1, 1, 4);

SELECT * FROM Consulta

