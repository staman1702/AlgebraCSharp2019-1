/****** Script for SelectTopNRows command from SSMS  ******/
SELECT o1.sifOrgjed
      ,o1.[nazOrgjed]
      --,o1.[sifNadorgjed]
	  ,COUNT(o2.[nazOrgjed]) AS 'broj zavoda'
  FROM [Fakultet].[dbo].[orgjed] o1 LEFT JOIN orgjed o2
  ON o1.sifOrgjed = o2.sifNadorgjed
  GROUP BY o1.sifOrgjed, o1.[nazOrgjed]
  HAVING count(o2.[nazOrgjed]) !=0
  order by 'broj zavoda' desc