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

INSERT INTO Usuario (NomeUsuario, EmailUsuario, Senha, IdTipoUsuario)
VALUES  ('Ricardo Lemos', 'ricardo.lemos@spmedicalgroup.com.br', 'Ric123', 2), ('Roberto Possarle', 'roberto.possarle@spmedicalgroup.com.br', 'Poss123', 2), 
('Helena Strada', 'helena.souza@spmedicalgroup.com.br', 'Hel123', 2), ('Ligia', 'Ligia@gmail.com', 'ligia123', 3), ('Alexandre', 'Alexandre@gmail.com', 'Alex123', 3),
('Fernando', 'Fernando@gmail.com', 'Fer123', 3), ('Henrique', 'Henrique@gmail.com', 'Henr123', 3), ('João', 'Joao@gmail.com', 'Joao123', 3), ('Bruno', 'Bruno@gmail.com', 'Bru123', 3),
('Mariana', 'Mariana@gmail.com', 'Mari123', 3);

SELECT * FROM Usuario


INSERT INTO Medico (CRM, IdUsuario, IdEspecialidade)
VALUES ('54356-SP', 1, 2), ('53452-SP', 2, 17), ('65463-SP', 3, 16);

SELECT * FROM Medico
