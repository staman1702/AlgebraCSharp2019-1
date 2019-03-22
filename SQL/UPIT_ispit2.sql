USE ispit

SELECT ime,prezime,id_diska,
DATEDIFF(day, datumposudbe, GETDATE()) AS 'Period posudbe'
FROM dbo.prijatelji JOIN dbo.posudba
ON prijatelji.id = posudba.id
WHERE datumpovrata IS NULL
GO