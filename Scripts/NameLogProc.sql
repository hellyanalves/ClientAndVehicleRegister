CREATE OR REPLACE FUNCTION log_name_update() RETURNS TRIGGER AS
$log_name$
BEGIN
	IF (OLD.Nome IS DISTINCT FROM NEW.Nome) THEN
		INSERT INTO car_insurance.HistoricoPessoa (IdPessoa,NomeAntigo,NomeAlteracao) VALUES (OLD.IdPessoa, OLD.Nome, New.Nome);
	END IF;
	RETURN NEW;
END;
$log_name$ LANGUAGE plpgsql;

CREATE TRIGGER name_update
    AFTER UPDATE ON car_insurance.Pessoa
    FOR EACH ROW
	EXECUTE PROCEDURE log_name_update();