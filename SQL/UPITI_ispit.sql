USE ispit

--UPDATE dbo.posudba
--SET datumpovrata = GETDATE()
--WHERE datumpovrata IS NULL
--GO


SELECT ime,prezime,id_diska,
CASE WHEN datumpovrata IS NULL
		THEN DATEDIFF(day,datumposudbe,GETDATE())
		else DATEDIFF(day,datumposudbe,datumpovrata)
		END AS 'Period posudbe'
FROM dbo.prijatelji JOIN dbo.posudba
ON prijatelji.id = posudba.id
GO