/****** mjesta gdje nema nijednmog nastavnika  ******/
SELECT TOP (1000) [pbr]
      ,[nazMjesto]
      ,[sifZupanija]
	  ,nastavnik.*
  FROM [Fakultet].[dbo].[mjesto]
  LEFT JOIN nastavnik ON mjesto.pbr=nastavnik.pbrStan
  WHERE nastavnik.koef IS NULL