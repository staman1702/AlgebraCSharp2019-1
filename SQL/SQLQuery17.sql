USE [Fakultet]
GO

SELECT [mbrStud]
      ,[imeStud]
      ,[prezStud]
      ,[pbrRod]
      ,[pbrStan]
      ,[datRodStud]
      ,[jmbgStud]
	  ,(mbrStud%2) AS parnepar
	  , (mbrStud%7) AS svaki7
  FROM [dbo].[stud]
  where (mbrStud%7) =0
  ORDER BY prezStud ASC, imeStud ASC
GO


