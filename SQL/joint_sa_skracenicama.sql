/****** mjesta gdje nema nijednmog nastavnika  ******/
SELECT TOP (1000) [pbr]
      ,[nazMjesto]
      ,[sifZupanija]
	  ,n.*
  FROM mjesto m
  LEFT JOIN nastavnik n ON m.pbr=n.pbrStan
  WHERE n.koef IS NULL