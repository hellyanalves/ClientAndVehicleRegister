CREATE PROCEDURE car_insurance.insert_cars(nome varchar(20))
LANGUAGE SQL 
AS 
$$
	INSERT INTO car_insurance.Veiculo (Nome) VALUES (nome);
$$