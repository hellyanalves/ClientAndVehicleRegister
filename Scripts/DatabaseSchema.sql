-- Schema and tables creation

CREATE SCHEMA car_insurance
    AUTHORIZATION postgres;
CREATE TABLE car_insurance.Veiculo
(
	IdVeiculo INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	Nome VARCHAR(20)
);
	
CREATE TABLE car_insurance.Pessoa
(
	IdPessoa INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	Nome VARCHAR(30),
	IdVeiculo INTEGER REFERENCES car_insurance.Veiculo(IdVeiculo)
);	
	CREATE TABLE car_insurance.HistoricoPessoa
(
	Id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	IdPessoa INTEGER REFERENCES car_insurance.Pessoa(IdPessoa),
	NomeAntigo VARCHAR(30),
	NomeAlteracao VARCHAR(30)
);
