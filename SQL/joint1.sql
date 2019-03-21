USE [Fakultet]
GO

SELECT [imeNastavnik] AS Ime
      ,[prezNastavnik]      AS Prezime
	  ,[Fakultet].[dbo].[mjesto].nazMjesto AS 'Mjesto u kojem živi'
  FROM [dbo].[nastavnik] INNER JOIN mjesto
  ON nastavnik.pbrStan = mjesto.pbr
GO


