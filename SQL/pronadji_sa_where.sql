--broj studenata iz svakog mjesta

USE [Fakultet]
GO

SELECT count([mbrStud]) as brojstudenata      
      ,[pbrRod],    
	    count([mbrStud])*2 as duplo,
		88 as osamosam
  FROM [dbo].[stud]
 GROUP BY pbrRod 
 HAVING count([mbrStud])>5
 ORDER BY brojstudenata DESC, pbrRod ASC
GO


