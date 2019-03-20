use tvrtka;

ALTER TABLE zaposlenici(
id INT NOT NULL
	CHECK ( id BETWEEN 1 AND 1000),
ime VARCHAR(25) NOT NULL,
prezime VARCHAR(50) NOT NULL

)
GO
