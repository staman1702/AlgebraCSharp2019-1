USE ispit
GO

CREATE VIEW nevraceni_diskovi AS
SELECT ime,prezime,id_diska,
DATEDIFF(day, datumposudbe, GETDATE()) AS 'Dana nevratito!'
FROM dbo.prijatelji JOIN dbo.posudba
ON prijatelji.id = posudba.id
WHERE datumpovrata IS NULL
GO