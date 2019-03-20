/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [mbrStud]
      ,[imeStud]
      ,[prezStud]
      ,[pbrRod]
      ,[pbrStan]
      ,[datRodStud]
      ,len([jmbgStud]) as broj
  FROM [Fakultet].[dbo].[stud]
  ORDER BY broj ASC